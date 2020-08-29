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
        System.Xml.Serialization.XmlSerializer XMLS;
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
            data = new GENODATA(openFileDialog.FileName, Convert.ToDouble(tLtextBox.Text));
        }

        private void LoadModelLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // read the xml file with constants and temperature response parameters
            ModelLabel.Text = "";
            openFileDialog.FilterIndex = 2;
            openFileDialog.FileName = @"C:\Projects\DCCurve\DCCurve.xml";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            ModelLabel.Text = openFileDialog.FileName;

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

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        //    dCCurve = new DCCurve();
        //    dCCurve.constants = new Constants();

            XMLS = new System.Xml.Serialization.XmlSerializer(new DCCurve().GetType());

            StreamWriter sw = new StreamWriter(@"C:\Projects\DCCurve\DCCurve_.xml");

            XMLS.Serialize(sw, dCCurve);

            sw.Flush();

            sw.Close();
        }
    }
}
/*
 * # Input parameters (A46)
theta = 0.05
PSlight_absorption = 2.2
Jmaxt = 437.4645449
*/
