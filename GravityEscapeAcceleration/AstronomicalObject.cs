using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceGravityCalculator
{
    public class AstronomicalObject
    {
        public string Name { get; private set; }
        public ExponentionalValues Mass { get; private set; }
        public ExponentionalValues Radius { get; private set; }
        public ExponentionalValues SurfaceGravity { get; private set; }

        public AstronomicalObject(string name, ExponentionalValues mass, ExponentionalValues radius)
        {
            Name = name;
            Mass = mass;
            Radius = radius;
            CalculateIntensityOfGravityAtSurface();
        }

        public AstronomicalObject(string[] values)
        {
            Name = values[0];
            Mass = new ExponentionalValues(
                float.Parse(values[1]),
                int.Parse(values[2]),
                SIUnitConverter.StringToSIUnit(values[3])
                );
            Radius = new ExponentionalValues(
                float.Parse(values[4]),
                int.Parse(values[5]),
                SIUnitConverter.StringToSIUnit(values[6])
                );
            CalculateIntensityOfGravityAtSurface();
        }

        //Easy formating for displaying to Text
        public string SurfaceGravityToString()
        {
            return SurfaceGravity.value.ToString();
        }

        /// <summary>
        /// Using the inverse square law, with respect to gravity;
        /// This calculates the intensity of gravity at the surface of the Celesital Object using
        /// (G * M) / (R^2)
        /// where:
        /// G is the universal constant of Gravity;
        /// M is the mass of the Celestial Object;
        /// R is the radius of the Celestial Object;
        /// </summary>
        private void CalculateIntensityOfGravityAtSurface()
        {
            //Convert from Solar Mass to kg, if nessecary
            ExponentionalValues mass = CheckMassUnits();

            /// The gravitational constant of the universe: 6.674 x 10^-11 N *(m^2)/(kg^2)
            /// (Newton sqaure meters per kilogram squared)
            ExponentionalValues constantOfGravity = new ExponentionalValues(6.674f, -11, SIUnit.NewtonMetersSquaredPerKGSquared);

            //Multiply the mass by universal constant of gravity (G*M)
            ExponentionalValues GravityMassProduct = new ExponentionalValues(
                constantOfGravity.value * mass.value,
                constantOfGravity.exponent + mass.exponent,
                SIUnit.cubicMetersPerSecSquaredPerKG);

            //Evaluate: (radius)^2
            //Convert from Kilometers to Meters, if nessecary
            ExponentionalValues radius = CheckRadiusUnits();
            radius.units = SIUnit.metersSquared;
            radius.Squared();

            //Evaluate: GravityMassProduct / radius
            ExponentionalValues _surfaceGravity = new ExponentionalValues(
                (GravityMassProduct.value / radius.value),
                (GravityMassProduct.exponent - radius.exponent),
                SIUnit.metersPerSecSquared
                );
            //Acceleration of gravity at the surface in m/s^2
            _surfaceGravity.Normalize();
            SurfaceGravity = _surfaceGravity;
        }

        private ExponentionalValues CheckMassUnits()
        {
            switch (Mass.units)
            {
                case SIUnit.kg:
                    return Mass;
                case SIUnit.SolarMass:
                    return SIUnitConverter.SolarMassToKG(Mass);
                default:
                    System.Diagnostics.Debug.Write("\n-----------\n");
                    System.Diagnostics.Debug.Write(Name + ".Mass.units was assigned an invalid value: ["
                        + Mass.units.ToString() + "]");
                    System.Diagnostics.Debug.Write("\n-----------\n");
                    return Mass;
            }
        }

        private ExponentionalValues CheckRadiusUnits()
        {
            switch (Radius.units)
            {
                case SIUnit.m:
                    return Radius;
                case SIUnit.km:
                    return SIUnitConverter.KilometersToMeters(Radius);
                default:
                    System.Diagnostics.Debug.Write("\n-----------\n");
                    System.Diagnostics.Debug.Write(Name + ".Radius.units was assigned an invalid value: ["
                        + Radius.units.ToString() + "]");
                    System.Diagnostics.Debug.Write("\n-----------\n");
                    return Radius;
            }
        }

        public string SaveData()
        {
            // TODO: consider storing surface gravity
            string data = "";
            data = Name + ",";
            data += Mass.value + "," + Mass.exponent + "," + Mass.units.ToString() + ",";
            data += Radius.value + "," + Radius.exponent + "," + Radius.units.ToString();
            return data;
        }
    }
}
