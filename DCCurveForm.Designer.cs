namespace DCCurve
{
    partial class DCCurveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ObsLabel = new System.Windows.Forms.LinkLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tLtextBox = new System.Windows.Forms.TextBox();
            this.LoadModelLabel = new System.Windows.Forms.LinkLabel();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.thetaBox = new System.Windows.Forms.TextBox();
            this.psBox = new System.Windows.Forms.TextBox();
            this.jMaxBox = new System.Windows.Forms.TextBox();
            this.PlotLabel = new System.Windows.Forms.LinkLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predicted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // ObsLabel
            // 
            this.ObsLabel.AutoSize = true;
            this.ObsLabel.Location = new System.Drawing.Point(21, 19);
            this.ObsLabel.Name = "ObsLabel";
            this.ObsLabel.Size = new System.Drawing.Size(93, 16);
            this.ObsLabel.TabIndex = 0;
            this.ObsLabel.TabStop = true;
            this.ObsLabel.Text = "Observed Data";
            this.ObsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ObsLabel_LinkClicked);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Data File (*.csv)|*.csv|Model File (*.xml)|*.xms";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(159, 19);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(35, 16);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leaf Temperature (oC)";
            // 
            // tLtextBox
            // 
            this.tLtextBox.Location = new System.Drawing.Point(628, 43);
            this.tLtextBox.Name = "tLtextBox";
            this.tLtextBox.Size = new System.Drawing.Size(85, 22);
            this.tLtextBox.TabIndex = 3;
            this.tLtextBox.Text = "30";
            // 
            // LoadModelLabel
            // 
            this.LoadModelLabel.AutoSize = true;
            this.LoadModelLabel.Location = new System.Drawing.Point(487, 72);
            this.LoadModelLabel.Name = "LoadModelLabel";
            this.LoadModelLabel.Size = new System.Drawing.Size(75, 16);
            this.LoadModelLabel.TabIndex = 4;
            this.LoadModelLabel.TabStop = true;
            this.LoadModelLabel.Text = "Load Model";
            this.LoadModelLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoadModelLabel_LinkClicked);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(487, 103);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(43, 16);
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Model";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1080, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Save XML";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Initial Values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "theta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "PSlight_absorption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(778, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jmax(T)";
            // 
            // thetaBox
            // 
            this.thetaBox.Location = new System.Drawing.Point(919, 43);
            this.thetaBox.Name = "thetaBox";
            this.thetaBox.Size = new System.Drawing.Size(85, 22);
            this.thetaBox.TabIndex = 11;
            this.thetaBox.Text = "0.05";
            // 
            // psBox
            // 
            this.psBox.Location = new System.Drawing.Point(919, 66);
            this.psBox.Name = "psBox";
            this.psBox.Size = new System.Drawing.Size(85, 22);
            this.psBox.TabIndex = 12;
            this.psBox.Text = "2.2";
            // 
            // jMaxBox
            // 
            this.jMaxBox.Location = new System.Drawing.Point(919, 85);
            this.jMaxBox.Name = "jMaxBox";
            this.jMaxBox.Size = new System.Drawing.Size(85, 22);
            this.jMaxBox.TabIndex = 13;
            this.jMaxBox.Text = "437.4645449";
            // 
            // PlotLabel
            // 
            this.PlotLabel.AutoSize = true;
            this.PlotLabel.Location = new System.Drawing.Point(1042, 72);
            this.PlotLabel.Name = "PlotLabel";
            this.PlotLabel.Size = new System.Drawing.Size(31, 16);
            this.PlotLabel.TabIndex = 14;
            this.PlotLabel.TabStop = true;
            this.PlotLabel.Text = "Plot";
            this.PlotLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PlotLabel_LinkClicked);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ci,
            this.PAR,
            this.Observed,
            this.Predicted});
            this.dataGridView.Location = new System.Drawing.Point(24, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(445, 281);
            this.dataGridView.TabIndex = 15;
            // 
            // chart
            // 
            chartArea2.AxisX.Title = "PAR";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Title = "Assimilation Rate";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Location = new System.Drawing.Point(498, 137);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.MarkerBorderColor = System.Drawing.Color.Black;
            series3.MarkerColor = System.Drawing.Color.White;
            series3.MarkerSize = 10;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Observed";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Name = "Predicted";
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(647, 456);
            this.chart.TabIndex = 16;
            this.chart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Photosynthetic light response ";
            this.chart.Titles.Add(title2);
            // 
            // Ci
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Ci.DefaultCellStyle = dataGridViewCellStyle5;
            this.Ci.HeaderText = "Ci";
            this.Ci.Name = "Ci";
            // 
            // PAR
            // 
            dataGridViewCellStyle6.Format = "N2";
            this.PAR.DefaultCellStyle = dataGridViewCellStyle6;
            this.PAR.HeaderText = "PAR";
            this.PAR.Name = "PAR";
            // 
            // Observed
            // 
            dataGridViewCellStyle7.Format = "N2";
            this.Observed.DefaultCellStyle = dataGridViewCellStyle7;
            this.Observed.HeaderText = "Observed";
            this.Observed.Name = "Observed";
            // 
            // Predicted
            // 
            dataGridViewCellStyle8.Format = "N2";
            this.Predicted.DefaultCellStyle = dataGridViewCellStyle8;
            this.Predicted.HeaderText = "Predicted";
            this.Predicted.Name = "Predicted";
            // 
            // DCCurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 619);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.PlotLabel);
            this.Controls.Add(this.jMaxBox);
            this.Controls.Add(this.psBox);
            this.Controls.Add(this.thetaBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.LoadModelLabel);
            this.Controls.Add(this.tLtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.ObsLabel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DCCurveForm";
            this.Text = "DCCurve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ObsLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tLtextBox;
        private System.Windows.Forms.LinkLabel LoadModelLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox thetaBox;
        private System.Windows.Forms.TextBox psBox;
        private System.Windows.Forms.TextBox jMaxBox;
        private System.Windows.Forms.LinkLabel PlotLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predicted;
    }
}

