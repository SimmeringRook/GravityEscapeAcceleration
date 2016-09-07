using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceGravityCalculator
{
    public enum SIUnit
    {
        m,
        km,
        SolarMass,
        kg,
        cubicMetersPerSecSquaredPerKG,
        cubicMetersPerSecSquared,
        metersSquared,
        metersPerSecSquared,
        NewtonMetersSquaredPerKGSquared,
        ERROR
    }
    /// <summary>
    /// Data structure to allow calculations of massive numbers, 
    /// greater than the precision of "long" and "decimal", by
    /// storing the information in exponential format
    /// </summary>
    public struct ExponentionalValues
    {
        public float value;
        public int exponent;
        public SIUnit units;

        public ExponentionalValues(float value, int exponent, SIUnit unit)
        {
            this.value = value;
            this.exponent = exponent;
            this.units = unit;
            RecalculateExponents();
        }

        /// <summary>
        /// Analyzes the number to ensure correct Exponential notation,
        /// in order to keep the value within the precision of a float,
        /// and correctly keep track of the number of decimal places.
        /// </summary>
        private void RecalculateExponents()
        {
     
            if (value / 10 > 1)
            {
                //Number can be simplified
                //E.g. xx.xxx
                while (value / 10 > 1)
                {
                    if (value / 10 < 1) 
                        //Number can't be simplified any further
                        return;
                    exponent += 1; //Increment the exponent tracker
                    value /= 10; // Decrease the size of the number
                }
            }
            else if (value / 10 < 1)
            {
                //The number is now smaller than 0
                //E.g.   0.xxxxx
                while (value / 10 < 1)
                {
                    if (value / 10 > 1)
                        //The number has returned to proper notation, exit
                        return;
                    exponent -= 1; //Decrement the exponent tracker
                    value *= 10; //Increase the size of the number
                }
            }

        }

        /// <summary>
        /// This function finishes evaluating the formula,
        /// by removing exponential notation.
        /// The values have been reduced and simplified at
        /// point to fit within the precision of a float.
        /// </summary>
        public void Normalize()
        {
            this.value *= (float) Math.Pow(10, exponent);
        }

        /// <summary>
        /// Helper function to remove the need of casting varriables back to floats/ints.
        /// (Instead of using Math.Pow(x,2) )
        /// </summary>
        public void Squared()
        {
            value *= value;
            exponent *= 2;
            RecalculateExponents();
        }
    }
}
