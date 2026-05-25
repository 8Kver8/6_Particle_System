namespace _6_Particle_System
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        RadarPoint radarPoint;
        ColorPoint leftPoint;
        ColorPoint rightPoint;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            picDisplay.MouseWheel += picDisplay_MouseWheel;

            this.emitter = new Emitter
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height + 50,
                Direction = 90,
                Spreading = 100,
                SpeedMin = 15,
                SpeedMax = 20,
                GravitationY = 0.4f,
                ParticlesPerTick = 15,
                ColorFrom = Color.White,
                ColorTo = Color.FromArgb(0, Color.White)
            };
            emitters.Add(this.emitter);

            radarPoint = new RadarPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
                Power = 150
            };
            emitter.impactPoints.Add(radarPoint);

            leftPoint = new ColorPoint
            {
                X = 200,
                Y = picDisplay.Height / 2,
                Color = Color.Orange
            };
            emitter.impactPoints.Add(leftPoint);

            rightPoint = new ColorPoint
            {
                X = picDisplay.Width - 200,
                Y = picDisplay.Height / 2,
                Color = Color.DeepSkyBlue
            };
            emitter.impactPoints.Add(rightPoint);

            tbLeftY.Maximum = picDisplay.Height;
            tbRightY.Maximum = picDisplay.Height;

            tbLeftX.Maximum = picDisplay.Width;
            tbRightX.Maximum = picDisplay.Width;

            tbLeftY.Value = picDisplay.Height / 2;
            tbRightY.Value = picDisplay.Height / 2;

            tbLeftX.Value = (int)leftPoint.X;
            tbRightX.Value = (int)rightPoint.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (radarPoint != null)
            {
                radarPoint.X = e.X;
                radarPoint.Y = e.Y;
            }
        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (radarPoint != null)
            {
                if (e.Delta > 0) radarPoint.Power += 10;
                else if (radarPoint.Power > 10) radarPoint.Power -= 10;
            }
        }

        private void tbLeftY_Scroll(object sender, EventArgs e)
        {
            leftPoint.Y = tbLeftY.Maximum - tbLeftY.Value;
        }

        private void tbRightY_Scroll(object sender, EventArgs e)
        {
            rightPoint.Y = tbRightY.Maximum - tbRightY.Value;
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var counter = new CounterPoint { X = e.X, Y = e.Y };
                emitter.impactPoints.Add(counter);
            }
            else if (e.Button == MouseButtons.Right)
            {
                emitter.impactPoints.RemoveAll(p => p is CounterPoint &&
                   Math.Sqrt(Math.Pow(p.X - e.X, 2) + Math.Pow(p.Y - e.Y, 2)) < CounterPoint.Radius);
            }
        }

        private void tbLeftX_Scroll(object sender, EventArgs e)
        {
            leftPoint.X = tbLeftX.Value;
        }

        private void tbRightX_Scroll(object sender, EventArgs e)
        {
            rightPoint.X = tbRightX.Value;
        }

        private void tbParticlesPerTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbParticlesPerTick.Value;
        }
    }
}
