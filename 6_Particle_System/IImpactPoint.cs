namespace _6_Particle_System
{
    public abstract class IImpactPoint
    {
        public float X;
        public float Y;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red), X - 5, Y - 5, 10, 10);
        }
    }

    public class ColorPoint : IImpactPoint
    {
        public Color Color = Color.Purple;
        public int Power = 100;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r < Power / 2)
            {
                if (particle is Particle.ParticleColorful p)
                {
                    p.FromColor = Color;
                    p.ToColor = Color.FromArgb(0, Color);
                }
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color, 2), X - Power / 2, Y - Power / 2, Power, Power);
        }
    }

    public class CounterPoint : IImpactPoint
    {
        public int Count = 0;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r < 30)
            {
                Count++;
                particle.Life = 0;
            }
        }

        public override void Render(Graphics g)
        {
            int redValue = Math.Min(255, Count);
            var color = Color.FromArgb(255, redValue, 255 - redValue, 0);

            g.DrawEllipse(new Pen(color, 2), X - 30, Y - 30, 60, 60);

            var font = new Font("Verdana", 12, FontStyle.Bold);
            var str = $"{Count}";
            var size = g.MeasureString(str, font);

            g.DrawString(str, font, new SolidBrush(color), X - size.Width / 2, Y - size.Height / 2);
        }
    }

    public class RadarPoint : IImpactPoint
    {
        private List<(float X, float Y, float Radius)> echoes = new List<(float, float, float)>();
        public int Power = 150;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r < Power / 2)
            {
                echoes.Add((particle.X, particle.Y, particle.Radius));
            }
        }

        public override void Render(Graphics g)
        {
            Color radarColor = Color.DarkGreen;
            g.DrawEllipse(new Pen(radarColor, 2), X - Power / 2, Y - Power / 2, Power, Power);

            foreach (var echo in echoes)
            {
                var brush = new SolidBrush(Color.FromArgb(180, radarColor));
                g.FillEllipse(brush, echo.X - echo.Radius, echo.Y - echo.Radius, echo.Radius * 2, echo.Radius * 2);
                brush.Dispose();
            }

            var text = $"{echoes.Count}";
            var font = new Font("Verdana", 10, FontStyle.Bold);
            var size = g.MeasureString(text, font);
            float offsetY = 10;

            g.DrawString(text, font, Brushes.White, X - size.Width / 2, Y - size.Height / 2 - offsetY);

            echoes.Clear();
        }
    }
}
