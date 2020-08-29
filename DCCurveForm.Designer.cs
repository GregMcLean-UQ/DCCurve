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
            this.CalcLabel = new System.Windows.Forms.LinkLabel();
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
            this.openFileDialog.FileName = "\"C:\\Projects\\DCCurve\\Data\\data.csv\"";
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
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leaf Temperature (oC)";
            // 
            // tLtextBox
            // 
            this.tLtextBox.Location = new System.Drawing.Point(162, 41);
            this.tLtextBox.Name = "tLtextBox";
            this.tLtextBox.Size = new System.Drawing.Size(85, 22);
            this.tLtextBox.TabIndex = 3;
            this.tLtextBox.Text = "30";
            // 
            // LoadModelLabel
            // 
            this.LoadModelLabel.AutoSize = true;
            this.LoadModelLabel.Location = new System.Drawing.Point(21, 270);
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
            this.ModelLabel.Location = new System.Drawing.Point(159, 270);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(43, 16);
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Model";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(400, 9);
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
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Initial Values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "theta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "PSlight_absorption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jmax(T)";
            // 
            // thetaBox
            // 
            this.thetaBox.Location = new System.Drawing.Point(162, 128);
            this.thetaBox.Name = "thetaBox";
            this.thetaBox.Size = new System.Drawing.Size(85, 22);
            this.thetaBox.TabIndex = 11;
            this.thetaBox.Text = "0.05";
            // 
            // psBox
            // 
            this.psBox.Location = new System.Drawing.Point(162, 156);
            this.psBox.Name = "psBox";
            this.psBox.Size = new System.Drawing.Size(85, 22);
            this.psBox.TabIndex = 12;
            this.psBox.Text = "2.2";
            // 
            // jMaxBox
            // 
            this.jMaxBox.Location = new System.Drawing.Point(162, 184);
            this.jMaxBox.Name = "jMaxBox";
            this.jMaxBox.Size = new System.Drawing.Size(85, 22);
            this.jMaxBox.TabIndex = 13;
            this.jMaxBox.Text = "437.4645449";
            // 
            // CalcLabel
            // 
            this.CalcLabel.AutoSize = true;
            this.CalcLabel.Location = new System.Drawing.Point(21, 315);
            this.CalcLabel.Name = "CalcLabel";
            this.CalcLabel.Size = new System.Drawing.Size(119, 16);
            this.CalcLabel.TabIndex = 14;
            this.CalcLabel.TabStop = true;
            this.CalcLabel.Text = "Calculate Variables";
            this.CalcLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CalcLabel_LinkClicked);
            // 
            // DCCurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.CalcLabel);
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
        private System.Windows.Forms.LinkLabel CalcLabel;
    }
}

