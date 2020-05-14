using System.ComponentModel;

namespace Circles
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MaxBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AvgBar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.MaxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.AvgBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MaxBar
            // 
            this.MaxBar.Location = new System.Drawing.Point(78, 12);
            this.MaxBar.Maximum = 50;
            this.MaxBar.Minimum = 5;
            this.MaxBar.Name = "MaxBar";
            this.MaxBar.Size = new System.Drawing.Size(104, 45);
            this.MaxBar.TabIndex = 0;
            this.MaxBar.TickFrequency = 5;
            this.MaxBar.Value = 25;
            this.MaxBar.Scroll += new System.EventHandler(this.MaxBar_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Avg";
            // 
            // AvgBar
            // 
            this.AvgBar.Location = new System.Drawing.Point(78, 63);
            this.AvgBar.Maximum = 60;
            this.AvgBar.Minimum = 1;
            this.AvgBar.Name = "AvgBar";
            this.AvgBar.Size = new System.Drawing.Size(104, 45);
            this.AvgBar.TabIndex = 2;
            this.AvgBar.TickFrequency = 5;
            this.AvgBar.Value = 25;
            this.AvgBar.Scroll += new System.EventHandler(this.AvgBar_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(67, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "5";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(178, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "50";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(67, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "1";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(178, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "60";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 171);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AvgBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize) (this.MaxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.AvgBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.TrackBar AvgBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TrackBar MaxBar;

        #endregion
    }
}