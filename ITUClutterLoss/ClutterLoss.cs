using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUClutterLoss
{
    public class ClutterLoss
    {
        public Random rando { get; set; }

        public double Nnormaldist { get; set; }

        public ClutterLoss(Random rando)
        {
            this.rando = rando;
        }

        public double TerrestrialtoTerrestrialClutterLoss(double FrequencyGHz, double Distancekm)
        {
            double LldB = 23.5 + 9.6 * Math.Log10(FrequencyGHz);
            double LsdB = 32.98 + 23.9 * Math.Log10(Distancekm) + 3 * Math.Log10(FrequencyGHz);
            Nnormaldist = N(0, 6);
            double ClutterLossdB = -5 * Math.Log10(Math.Pow(10, -0.2 * LldB) + Math.Pow(10, -0.2 * LsdB));

            return ClutterLossdB;
        }

        // Box Muller algorithm
        protected double N(double mean, double std)
        {
            double u1 = 1.0 - rando.NextDouble();
            double u2 = 1.0 - rando.NextDouble();
            double randomStdNormal = Math.Sqrt(-2 * Math.Log(u1)) * Math.Sin(2 * Math.PI * u2);

            return mean + std * randomStdNormal;
        }
    }
}
