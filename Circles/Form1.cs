using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Circles
{
    public partial class Form1 : Form
    {
        private Graphics _graphics;
        private int MaxCount = 50;
        private int AverageLifeTime = 10;
        private Dictionary<int, Circle> _toDraw = new Dictionary<int, Circle>();
        private int Last;
        private Random _random;
        private List<int> _timesOfLife;
        private int _index = 0; 
        public Form1()
        {
            InitializeComponent();
            _random = new Random();
            var bmp = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            BackgroundImage = bmp;
            _graphics = Graphics.FromImage(BackgroundImage);
            _graphics.Clear(Color.Wheat);
            DrawCanvas();
            CheckForIllegalCrossThreadCalls = false;
            
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            AverageLifeTime = loginForm.AvgBar.Value;
            MaxCount = loginForm.MaxBar.Value;
            LifeTimeProvider.Average = AverageLifeTime;
            LifeTimeProvider.Count = MaxCount;
            _timesOfLife = LifeTimeProvider.GenerateList();
            
            var thread = new Thread(DrawElipse) {IsBackground = true};
            thread.Start();
        }

        public override void Refresh()
        {
            _graphics.Clear(Color.Wheat);
            DrawCanvas();
            Text.Text = _toDraw.Count.ToString();
            var pen = new Pen(Color.Blue, 2f);
            foreach (var el in _toDraw)
            {
                var circle = el.Value;
                pen.Color = circle.color;
                _graphics.DrawEllipse(pen, circle.point.X, circle.point.Y, circle.radius, circle.radius);
            }

            base.Refresh();
        }

        private void AddCircle(Circle circle)
        {
            AddCircle(GetFreeId(), circle);
        }

        private void AddCircle(int id, Circle circle)
        {
            _toDraw.Add(id, circle);
        }

        private int GetFreeId()
        {
            return Last++;
        }

        private Color GetRandomColor()
        {
            return  Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
        }

        private PointF GetRandomPoint(int radius = 0)
        {
            return new PointF(_random.Next(100 + radius + 1, 1000 - radius - 1), _random.Next(100 + radius + 1, 500 - radius - 1));
        }

        private Circle GetRandomCircle(int radius = 10)
        {
            return new Circle(GetRandomColor(), GetRandomPoint(radius), radius, _timesOfLife[_index++]);
        }

        private void DrawCanvas()
        {
            var pen = new Pen(Color.MediumSeaGreen, 3f);
            _graphics.DrawLine(pen, 100f, 100f, 100f, 500f);
            _graphics.DrawLine(pen, 100f, 500f, 1000f, 500f);
            _graphics.DrawLine(pen, 1000f, 500f, 1000f, 100f);
            _graphics.DrawLine(pen, 1000f, 100f, 100f, 100f);
        }

        private void CircleController()
        {
            var id = GetFreeId();
            var circle = GetRandomCircle(_random.Next(5, 15));

            lock (_toDraw)
            {
                AddCircle(id, circle);
                Refresh();
            }

            for (var i = 1; i < 800; i++)
            {
                Thread.Sleep(_random.Next(100, 800));
                lock (_toDraw)
                {
                    if (!_toDraw.ContainsKey(id))
                        return;
                    
                    if (_toDraw[id].ShouldDie)
                    {
                        _toDraw.Remove(id);
                        Refresh();
                        return;
                    }
                    
                    _toDraw[id].Add(_random.Next(1, 5));
                    Refresh();
                }
            }

            lock (_toDraw)
            {
                _toDraw.Remove(id);
                Refresh();
            }
        }

        private void DrawElipse()
        {
            for (var i = 0; i < MaxCount; i++)
            {
                var thread = new Thread(CircleController) {IsBackground = true};
                thread.Start();
                Thread.Sleep(_random.Next(50, 200));
            }
        }
    }
}