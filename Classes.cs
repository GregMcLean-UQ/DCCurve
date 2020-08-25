using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCCurve
{
    class DataItem
    {
        // Ci,PAR,Scorpio
        readonly double Ci;
        readonly double PAR;
        readonly double assimilationRate;
       public DataItem(double[] items)
        {
            Ci = items[0];
            PAR = items[1];
            assimilationRate = items[2];
        }
    }
    class DATA
    {
        readonly double LeafTempereature;
        readonly List<DataItem> genoData;
        public DATA(string fileName)
        {
            // Read the data file and load the ovserved data.
            // Ci,PAR,Scorpio
            //42.71124566,1999.392456,46.43123821,
            genoData = new List<DataItem>();
            var lines = File.ReadAllLines(fileName);
            foreach (string line in lines.Skip(1))
            {
                var items = Array.ConvertAll(line.Split(',').ToArray(), Double.Parse);
                genoData.Add(new DataItem(items));
            }
        }

    }
}
