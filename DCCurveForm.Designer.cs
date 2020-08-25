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
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
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
            this.LoadModelLabel.Location = new System.Drawing.Point(21, 76);
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
            this.ModelLabel.Location = new System.Drawing.Point(159, 76);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(43, 16);
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Model";
            // 
            // DCCurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
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
    }
}

