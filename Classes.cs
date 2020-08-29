using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    class GENODATA
    {
        readonly double leafTempereature;
        readonly List<DataItem> genoData;
        public GENODATA(string fileName, double lt)
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
            leafTempereature = lt;
        }

    }
    public class Constants
    {
        public double abs, f, gm25, x, alpha, gbsT, Om, Rd25, Phi;

    }
    public class TResponse
    {
        public double KcP25, KcEa, KoP25, KoEa, VcmaxP25, VcmaxEa, Vcmax_VomaxP25, Vcmax_VomaxEa, KpP25, KpEa,
            VpmaxP25, VpmaxEa, RdP25, RdEa, JP25, JTMin, JTOpt, JTMax, JMaxC, Jbeta, GmP25, GmTMin, GmTOpt, GmTMax, GmMaxC, Gmbeta;

    }
    public class DCCurve
    {
        public Constants constants;
        public TResponse tResponse;
        Variables vars;
        double theta = 0.05;
        double PSlight_absorption = 2.2;
        double Jmaxt = 437.4645449;
        public void CalcVariales(double leafTemperature)
        {
            vars = new Variables(tResponse, constants, leafTemperature);
        }

    }

    public class Variables
    {
        public double GmLn, gmT, KcT, KoT, Vcmax_VomaxT, gammaT, RdT, RmT;

        public Variables(TResponse tR, Constants c, double leafTemperature)
        {
            //# Table 3
            GmLn = Math.Log(2) / Math.Log((tR.GmTMax - tR.GmTMin) / (tR.GmTOpt - tR.GmTMin));
            //#EQN 9 
            gmT = c.gm25 * (((2 * Math.Pow((leafTemperature - tR.GmTMin), GmLn) * Math.Pow((tR.GmTOpt - tR.GmTMin), GmLn) - Math.Pow((leafTemperature - tR.GmTMin), (2 * GmLn)))
                / Math.Pow((Math.Pow((tR.GmTOpt - tR.GmTMin), (2 * GmLn))), tR.Gmbeta) / tR.GmMaxC));
            // # EQN 8
            KcT = tR.KcP25 * Math.Exp(tR.KcEa * (leafTemperature + 273 - 298.15) / (298.15 * 8.314 * (leafTemperature + 273)));
            KoT = tR.KoP25 * Math.Exp(tR.KoEa * (leafTemperature + 273 - 298.15) / (298.15 * 8.314 * (leafTemperature + 273)));
            Vcmax_VomaxT = tR.Vcmax_VomaxP25 * Math.Exp(tR.Vcmax_VomaxEa * (leafTemperature + 273 - 298.15) / (298.15 * 8.314 * (leafTemperature + 273)));
            gammaT = 0.5 / (KoT / KcT * Vcmax_VomaxT);
            RdT = c.Rd25 * Math.Exp(tR.RdEa * (leafTemperature + 273 - 298.15) / (298.15 * 8.314 * (leafTemperature + 273)));
            RmT = RdT / 2;
        }
    }
}

