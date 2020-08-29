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

        public void CalcVariales(double leafTemperature)
        {
            vars = new Variables(tResponse, constants, leafTemperature);
        }
        public double CalcAj(double Ci, double PAR, double theta, double PSlight_absorption, double Jmaxt)
        {
            double Aj = 0;
            // # EQN 15
            double I2 = PAR * constants.abs * (1 - constants.f) / PSlight_absorption;
            // # EQN 14
            double Jt = (I2 + Jmaxt - Math.Pow((Math.Pow(I2 + Jmaxt, 2) - 4 * theta * Jmaxt * I2), 0.5)) / (2 * theta);
            // x1 = 1-x)*J/3 (E57)
            double x1 = (1 - constants.x) * Jt / 3;
            double x2 = 7.0 / 3.0 * vars.gammaT;
            double x3 = 0;
            double x4 = 0;
            double x5 = constants.x * Jt / constants.Phi;
            double x6 = 1;
            double x7 = 0;
            double x8 = 1;
            double x9 = 1;
            // #EQN 11
            double a = constants.alpha / 0.047 * vars.RdT * x2 * x9 - constants.alpha / 0.047 * vars.gammaT * x1 * x9 - constants.gbsT * Ci + constants.gbsT * (1 / vars.gmT) * vars.RdT -
                constants.gbsT * (1 / vars.gmT) * x1 - constants.Om * constants.gbsT * x2 - constants.gbsT * x3 + vars.RmT * x8 - Ci * x4 * x8 + (1 / vars.gmT) * vars.RdT *
                x4 * x8 - (1 / vars.gmT) * x1 * x4 * x8 + vars.RdT * x6 * x8 - x1 * x6 * x8 - x5 * x8 + x7 * x8;
            // #EQN 13
            double d = -constants.alpha / 0.047 * x2 * x9 + constants.gbsT * (1 / vars.gmT) + (1 / vars.gmT) * x4 * x8 + x6 * x8;
            //  #EQN 12
            double b = d * (-constants.gbsT * Ci * vars.RdT + constants.gbsT * Ci * x1 - constants.Om * constants.gbsT * vars.RdT * x2 - constants.gbsT * vars.RdT * x3 - constants.Om *
                constants.gbsT * vars.gammaT * x1 + vars.RmT * vars.RdT * x8 - vars.RmT * x1 * x8 - Ci * vars.RdT * x4 * x8 + Ci * x1 * x4 * x8 - vars.RdT * x7 * x8 + x1 * x5 * x8 - x1 * x7 * x8);
            double c = -a;
            //  #EQN 14
            Aj = (-(Math.Pow((Math.Pow(a, 2) - 4 * b), 0.5)) + c) / (2 * d);


            return Aj;
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

