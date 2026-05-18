using static _6_Particle_System.IImpactPoint;
using static _6_Particle_System.Particle;

namespace _6_Particle_System
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        ColorPoint colorPoint;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height,
                Direction = 90,
                Spreading = 100,
                SpeedMin = 10,
                SpeedMax = 15,
                GravitationY = 0.3f,
                ParticlesPerTick = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red)
            };

            emitters.Add(this.emitter);

            colorPoint = new ColorPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2
            };

            emitter.impactPoints.Add(colorPoint);

            picDisplay.MouseWheel += picDisplay_MouseWheel;
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
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            if (colorPoint != null)
            {
                colorPoint.X = e.X;
                colorPoint.Y = e.Y;
            }
        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                colorPoint.Power += 10;
            }
            else
            {
                if (colorPoint.Power > 10)
                {
                    colorPoint.Power -= 10;
                }
            }
        }
    }
}
