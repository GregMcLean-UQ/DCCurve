using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCCurve
{
    public partial class DCCurveForm : Form
    {
        DATA data;
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
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            fileNameLabel.Text = openFileDialog.FileName;
            data = new DATA(openFileDialog.FileName);
        }
    }
}
