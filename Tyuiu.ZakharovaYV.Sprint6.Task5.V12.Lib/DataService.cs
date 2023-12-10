using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ZakharovaYV.Sprint6.Task5.V12.Lib
{
    public class DataService : ISprint6Task5V12
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
              
            }
            double[] numarrays = new double[len];

            int index = 0;
            using (StreamReader streamreader = new StreamReader(path))
            {
                string line;
                while ((line = streamreader.ReadLine()) != null)
                {

                    numarrays[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numarrays = numarrays.Where(val => val > 5).ToArray();

            return numarrays;
        }
    }
}
