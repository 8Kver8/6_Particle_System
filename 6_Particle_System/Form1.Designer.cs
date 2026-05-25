namespace _6_Particle_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picDisplay = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tbLeftY = new TrackBar();
            tbRightY = new TrackBar();
            tbLeftX = new TrackBar();
            tbRightX = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            tbParticlesPerTick = new TrackBar();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbLeftY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRightY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbLeftX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRightX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbParticlesPerTick).BeginInit();
            SuspendLayout();
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(816, 385);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.MouseClick += picDisplay_MouseClick;
            picDisplay.MouseMove += picDisplay_MouseMove;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // tbLeftY
            // 
            tbLeftY.Location = new Point(67, 431);
            tbLeftY.Name = "tbLeftY";
            tbLeftY.Orientation = Orientation.Vertical;
            tbLeftY.Size = new Size(56, 130);
            tbLeftY.TabIndex = 1;
            tbLeftY.Scroll += tbLeftY_Scroll;
            // 
            // tbRightY
            // 
            tbRightY.Location = new Point(742, 431);
            tbRightY.Name = "tbRightY";
            tbRightY.Orientation = Orientation.Vertical;
            tbRightY.Size = new Size(56, 130);
            tbRightY.TabIndex = 2;
            tbRightY.Scroll += tbRightY_Scroll;
            // 
            // tbLeftX
            // 
            tbLeftX.Location = new Point(152, 460);
            tbLeftX.Name = "tbLeftX";
            tbLeftX.Size = new Size(200, 56);
            tbLeftX.TabIndex = 3;
            tbLeftX.Scroll += tbLeftX_Scroll;
            // 
            // tbRightX
            // 
            tbRightX.Location = new Point(511, 460);
            tbRightX.Name = "tbRightX";
            tbRightX.Size = new Size(200, 56);
            tbRightX.TabIndex = 4;
            tbRightX.Scroll += tbRightX_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 403);
            label1.Name = "label1";
            label1.Size = new Size(225, 20);
            label1.TabIndex = 5;
            label1.Text = "Управление оранжевой зоной";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(557, 403);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 6;
            label2.Text = "Управление синей зоной";
            // 
            // tbParticlesPerTick
            // 
            tbParticlesPerTick.Location = new Point(272, 571);
            tbParticlesPerTick.Maximum = 100;
            tbParticlesPerTick.Minimum = 1;
            tbParticlesPerTick.Name = "tbParticlesPerTick";
            tbParticlesPerTick.Size = new Size(281, 56);
            tbParticlesPerTick.TabIndex = 7;
            tbParticlesPerTick.Value = 1;
            tbParticlesPerTick.Scroll += tbParticlesPerTick_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 541);
            label3.Name = "label3";
            label3.Size = new Size(243, 20);
            label3.TabIndex = 8;
            label3.Text = " Управление количеством частиц";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 639);
            Controls.Add(label3);
            Controls.Add(tbParticlesPerTick);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbRightX);
            Controls.Add(tbLeftX);
            Controls.Add(tbRightY);
            Controls.Add(tbLeftY);
            Controls.Add(picDisplay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbLeftY).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRightY).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbLeftX).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRightX).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbParticlesPerTick).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbLeftY;
        private TrackBar tbRightY;
        private TrackBar tbLeftX;
        private TrackBar tbRightX;
        private Label label1;
        private Label label2;
        private TrackBar tbParticlesPerTick;
        private Label label3;
    }
}
