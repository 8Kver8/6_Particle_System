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
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbLeftY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRightY).BeginInit();
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
            tbLeftY.Location = new Point(12, 403);
            tbLeftY.Name = "tbLeftY";
            tbLeftY.Orientation = Orientation.Vertical;
            tbLeftY.Size = new Size(56, 130);
            tbLeftY.TabIndex = 1;
            tbLeftY.Scroll += tbLeftY_Scroll;
            // 
            // tbRightY
            // 
            tbRightY.Location = new Point(772, 403);
            tbRightY.Name = "tbRightY";
            tbRightY.Orientation = Orientation.Vertical;
            tbRightY.Size = new Size(56, 130);
            tbRightY.TabIndex = 2;
            tbRightY.Scroll += tbRightY_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 556);
            Controls.Add(tbRightY);
            Controls.Add(tbLeftY);
            Controls.Add(picDisplay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbLeftY).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRightY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbLeftY;
        private TrackBar tbRightY;
    }
}
