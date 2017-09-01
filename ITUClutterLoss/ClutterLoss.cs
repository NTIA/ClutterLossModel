using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUClutterLoss
{
    /// <summary>
    /// ITU-R P.2108-0
    /// </summary>
    public class ClutterLoss
    {
        protected Random rando { get; set; }

        public double Ll { get; protected set; }

        public double Ls { get; protected set; }

        public double QInverse { get; protected set; }

        public ClutterLoss(Random rando)
        {
            this.rando = rando;
            
        }
        /// <summary>
        /// ITU-R P.2108-0 Section 3.2. Designed for input P to be random and output Qterm is random
        /// </summary>
        /// <param name="FrequencyGHz">The frequency in GHz</param>
        /// <param name="Distancekm">The distance in km</param>
        /// <param name="p">The p value to use for the inverse q function</param>
        /// <returns>Clutter Loss in Terrestrial Link</returns>
        public double TerrestrialtoTerrestrialClutterLoss(double FrequencyGHz, double Distancekm, double p)
        {
            Ll = 23.5 + 9.6 * Math.Log10(FrequencyGHz);
            Ls = 32.98 + 23.9 * Math.Log10(Distancekm) + 3 * Math.Log10(FrequencyGHz);
            QInverse = QFunction.inverse(p);
            double ClutterLossdB = -5 * Math.Log10(Math.Pow(10, -0.2 * Ll) + Math.Pow(10, -0.2 * Ls)) - 6 * QInverse;

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
