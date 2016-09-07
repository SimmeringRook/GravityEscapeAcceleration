using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceGravityCalculator
{
    static class DataHandler
    {
        private static string dataFilePath = "AstronomicalObjectData.txt";
        private static List<AstronomicalObject> dataAlreadySaved;
        public static List<AstronomicalObject> ReadDataFile()
        {
            dataAlreadySaved = new List<AstronomicalObject>();
            List<AstronomicalObject> storedCelestialObjects = new List<AstronomicalObject>();

            try
            {
                StreamReader dataFile;
                string line;
                AstronomicalObject celesitalBody;// = new AstronomicalObject("", new ExponentionalValues(), new ExponentionalValues());

                char delimiter = ',';
                dataFile = File.OpenText(dataFilePath);
                while (!dataFile.EndOfStream)
                {
                    line = dataFile.ReadLine();

                    string[] tokens = line.Split(delimiter);
                    celesitalBody = new AstronomicalObject(
                        tokens[0],
                        new ExponentionalValues(
                            float.Parse(tokens[1]), 
                            int.Parse(tokens[2]), 
                            (SIUnit)Enum.Parse(typeof(SIUnit), tokens[3])),
                        new ExponentionalValues(
                            float.Parse(tokens[4]), 
                            int.Parse(tokens[5]), 
                            (SIUnit)Enum.Parse(typeof(SIUnit), tokens[6]))
                        );

                    storedCelestialObjects.Add(celesitalBody);
                    dataAlreadySaved.Add(celesitalBody);
                }
                dataFile.Close();
            }
            catch (Exception ex)
            {
                storedCelestialObjects.Add(new AstronomicalObject(
                                    "Pheonix Cluster Black Hole",
                                    new ExponentionalValues(2, 10, SIUnit.SolarMass),
                                    new ExponentionalValues(5.9f, 10, SIUnit.km)));
                storedCelestialObjects.Add(new AstronomicalObject(
                                    "Earth",
                                    new ExponentionalValues(5.972f, 24, SIUnit.kg),
                                    new ExponentionalValues(6.371f, 3, SIUnit.km)));
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return storedCelestialObjects;
        }

        public static bool WriteDataFile(List<AstronomicalObject> celestialObjectsToSave)
        {
            try
            {
                StreamWriter dataFile = new StreamWriter(dataFilePath, true);
                string line = "";

                foreach (AstronomicalObject celestialBody in celestialObjectsToSave)
                {
                    if (dataAlreadySaved.Contains(celestialBody) == false)
                    {
                        line = celestialBody.SaveData();
                        dataFile.WriteLine(line);
                    }
                }

                dataFile.Close();

                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
