using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KineticEnergyLibrary
{
    public class Calculate
    {
        // The KineticEnergy method accepts mass and velocity
        // as arguments and returns kinetic energy.
        public static double KineticEnergy(double mass, double velocity)
        {
            return 0.5 * mass * Math.Pow(velocity, 2.0);
        }
    }
}
