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
        DATA data;
        System.Xml.Serialization.XmlSerializer XMLS;
        public DCCurve dCCurve;
        public DCCurveForm()
        {
            InitializeComponent();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void ObsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileNameLabel.Text = "";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            fileNameLabel.Text = openFileDialog.FileName;
            data = new DATA(openFileDialog.FileName, Convert.ToDouble(tLtextBox.Text));
        }

        private void LoadModelLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModelLabel.Text = "";
            openFileDialog.FilterIndex = 2;
            openFileDialog.FileName = @"C:\Projects\DCCurve\DCCurve.xml";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            ModelLabel.Text = openFileDialog.FileName;

            XMLS = new System.Xml.Serialization.XmlSerializer(new DCCurve().GetType());
            try
            {
                XElement booksFromFile = XElement.Load(ModelLabel.Text);

                StreamReader sr = new StreamReader(ModelLabel.Text);
                dCCurve = (DCCurve)XMLS.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Enabled = false;
            }

        }
    }
}
