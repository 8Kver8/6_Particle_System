using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Particle_System
{
    public abstract class IImpactPoint
    {
        public float X;
        public float Y;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }

    public class ColorPoint : IImpactPoint
    {
        public Color Color = Color.Magenta;
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
}
