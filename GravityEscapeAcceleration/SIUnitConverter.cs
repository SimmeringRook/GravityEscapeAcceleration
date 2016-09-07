using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceGravityCalculator
{
    public static class SIUnitConverter
    {
        private static float _solarToKG = 1.988435f;

        /// <summary>
        /// Convert from Solar Mass to Kilograms
        /// </summary>
        /// <param name="massInSM"></param>
        /// <returns></returns>
        public static ExponentionalValues SolarMassToKG(ExponentionalValues massInSM)
        {
            float kg = massInSM.value * _solarToKG;
            int exponents = massInSM.exponent + 30;

            return new ExponentionalValues(kg, exponents, SIUnit.kg);
        }

        /// <summary>
        /// Convert from Kilometers to Meters
        /// </summary>
        /// <param name="radiusInKM"></param>
        /// <returns></returns>
        public static ExponentionalValues KilometersToMeters(ExponentionalValues radiusInKM)
        {
            float meters = radiusInKM.value * 1000;
            int exponents = radiusInKM.exponent;

            return new ExponentionalValues(meters, exponents, SIUnit.m);
        }

        public static SIUnit StringToSIUnit(string unitAsString)
        {
            switch (unitAsString)
            {
                case "kilograms":
                    return SIUnit.kg;
                case "Solar Masses":
                    return SIUnit.SolarMass;
                case "meters":
                    return SIUnit.m;
                case "kilometers":
                    return SIUnit.km;
                default:
                    System.Windows.Forms.MessageBox.Show("Could not parse the SI Unit [" + unitAsString + "] correctly.");
                    return SIUnit.ERROR;
            }
        }
    }
}
