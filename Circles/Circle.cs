using System;
using System.Drawing;

namespace Circles
{
    public class Circle
    {
        public Color color;
        public PointF point;
        public float radius;
        public float DeathTime = 1f;
        
        private readonly DateTime BirthDay;
        public double LifeTime => (DateTime.Now - BirthDay).TotalSeconds;
        public bool ShouldDie => LifeTime > DeathTime;

        public Circle(Color color, PointF point, float radius)
        {
            this.color = color;
            this.point = point;
            this.radius = radius;
            BirthDay = DateTime.Now;
        }
        public Circle(Color color, PointF point, float radius, float deathTime)
        {
            this.color = color;
            this.point = point;
            this.radius = radius;
            DeathTime = deathTime;
            BirthDay = DateTime.Now;
        }

        public void Add(int x = 1)
        {
            radius += x;
            point.X -= x * 0.5f;
            point.Y -= x * 0.5f;
        }
        
        
        public void Sub(int x = 1)
        {
            radius -= x;
            point.X += x * 0.5f;
            point.Y += x * 0.5f;
        }
    }
}