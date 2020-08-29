using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DCCurve
{
    public partial class DCCurveForm : Form
    {
        GENODATA data;
        public DCCurve dCCurve;

        public DCCurveForm()
        {
            InitializeComponent();
        }

        private void ObsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Read the Observed data
            fileNameLabel.Text = "";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            fileNameLabel.Text = openFileDialog.FileName;
            data = new GENODATA(openFileDialog.FileName);

            DisplayData();
        }
        private void DisplayData()
        {
            // Display the data in the grid.
            foreach (DataItem d in data.genoData)
            {
                dataGridView.Rows.Add(d.Ci, d.PAR, d.assimilationRate, d.predicted);
            }
            PlotData();
        }
        private void PlotData()
        {
            // Chart the data
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            foreach (DataItem d in data.genoData)
            {
                chart.Series[0].Points.AddXY(d.PAR, d.assimilationRate);
                chart.Series[1].Points.AddXY(d.PAR, d.predicted);
            }

        }

        private void LoadModelLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // read the xml file with constants and temperature response parameters
            ModelLabel.Text = "";
            openFileDialog.FilterIndex = 2;
            openFileDialog.FileName = @"C:\Projects\DCCurve\DCCurve.xml";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            ModelLabel.Text = openFileDialog.FileName;

            System.Xml.Serialization.XmlSerializer XMLS;
            XMLS = new System.Xml.Serialization.XmlSerializer(new DCCurve().GetType());
            try
            {
                StreamReader sr = new StreamReader(ModelLabel.Text);
                dCCurve = (DCCurve)XMLS.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Do the variable calculations.
            dCCurve.CalcVariales(Convert.ToDouble(tLtextBox.Text));

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //    Save constants and parameters to the xml file

            System.Xml.Serialization.XmlSerializer XMLS;
            XMLS = new System.Xml.Serialization.XmlSerializer(new DCCurve().GetType());
            StreamWriter sw = new StreamWriter(@"C:\Projects\DCCurve\DCCurve_.xml");

            XMLS.Serialize(sw, dCCurve);
            sw.Flush();
            sw.Close();
        }

        private void PlotLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // For each of the observed data calculate a predicted value;
            // Graph the result
            double theta = 0.05;
            double PSlight_absorption = 2.2;
            double Jmaxt = 437.4645449;

            // double Ci = 42.71124566;
            //  double PAR = 1999.392456;

            for (int i = 0; i < data.genoData.Count; i++)
            {
                double Ci = data.genoData[i].Ci;
                double PAR = data.genoData[i].PAR;
                data.genoData[i].predicted =  dCCurve.CalcAj(Ci, PAR, theta, PSlight_absorption, Jmaxt);
            }
            DisplayData();

        }
    }
}
