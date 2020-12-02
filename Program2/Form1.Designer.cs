namespace Program2
{
    partial class Form1
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
            this.packageWeightLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.companyBOutput = new System.Windows.Forms.Label();
            this.companyCOutput = new System.Windows.Forms.Label();
            this.companyAOutput = new System.Windows.Forms.Label();
            this.packageWeightTextBox = new System.Windows.Forms.TextBox();
            this.deliveryTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.lowestCostOutput = new System.Windows.Forms.Label();
            this.companyBLabel = new System.Windows.Forms.Label();
            this.companyALabel = new System.Windows.Forms.Label();
            this.calculationButton = new System.Windows.Forms.Button();
            this.companyCLabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelForResults = new System.Windows.Forms.Panel();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelForResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // packageWeightLabel
            // 
            this.packageWeightLabel.AutoSize = true;
            this.packageWeightLabel.Location = new System.Drawing.Point(80, 82);
            this.packageWeightLabel.Name = "packageWeightLabel";
            this.packageWeightLabel.Size = new System.Drawing.Size(87, 13);
            this.packageWeightLabel.TabIndex = 0;
            this.packageWeightLabel.Text = "Package Weight";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(78, 145);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(82, 13);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Distance (Miles)";
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Location = new System.Drawing.Point(80, 221);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(72, 13);
            this.deliveryLabel.TabIndex = 2;
            this.deliveryLabel.Text = "Delivery Days";
            // 
            // companyBOutput
            // 
            this.companyBOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyBOutput.Location = new System.Drawing.Point(132, 87);
            this.companyBOutput.Name = "companyBOutput";
            this.companyBOutput.Size = new System.Drawing.Size(103, 25);
            this.companyBOutput.TabIndex = 3;
            // 
            // companyCOutput
            // 
            this.companyCOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyCOutput.Location = new System.Drawing.Point(132, 138);
            this.companyCOutput.Name = "companyCOutput";
            this.companyCOutput.Size = new System.Drawing.Size(103, 21);
            this.companyCOutput.TabIndex = 4;
            // 
            // companyAOutput
            // 
            this.companyAOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyAOutput.Location = new System.Drawing.Point(132, 42);
            this.companyAOutput.Name = "companyAOutput";
            this.companyAOutput.Size = new System.Drawing.Size(103, 24);
            this.companyAOutput.TabIndex = 5;
            // 
            // packageWeightTextBox
            // 
            this.packageWeightTextBox.Location = new System.Drawing.Point(208, 75);
            this.packageWeightTextBox.Name = "packageWeightTextBox";
            this.packageWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.packageWeightTextBox.TabIndex = 6;
            // 
            // deliveryTextBox
            // 
            this.deliveryTextBox.Location = new System.Drawing.Point(208, 221);
            this.deliveryTextBox.Name = "deliveryTextBox";
            this.deliveryTextBox.Size = new System.Drawing.Size(100, 20);
            this.deliveryTextBox.TabIndex = 7;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(208, 145);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 8;
            // 
            // lowestCostOutput
            // 
            this.lowestCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestCostOutput.Location = new System.Drawing.Point(25, 183);
            this.lowestCostOutput.Name = "lowestCostOutput";
            this.lowestCostOutput.Size = new System.Drawing.Size(207, 31);
            this.lowestCostOutput.TabIndex = 9;
            // 
            // companyBLabel
            // 
            this.companyBLabel.AutoSize = true;
            this.companyBLabel.Location = new System.Drawing.Point(22, 88);
            this.companyBLabel.Name = "companyBLabel";
            this.companyBLabel.Size = new System.Drawing.Size(85, 13);
            this.companyBLabel.TabIndex = 10;
            this.companyBLabel.Text = "Company B Cost";
            // 
            // companyALabel
            // 
            this.companyALabel.AutoSize = true;
            this.companyALabel.Location = new System.Drawing.Point(22, 43);
            this.companyALabel.Name = "companyALabel";
            this.companyALabel.Size = new System.Drawing.Size(85, 13);
            this.companyALabel.TabIndex = 11;
            this.companyALabel.Text = "Company A Cost";
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(83, 358);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(153, 23);
            this.calculationButton.TabIndex = 12;
            this.calculationButton.Text = "Calculate Cost";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // companyCLabel
            // 
            this.companyCLabel.AutoSize = true;
            this.companyCLabel.Location = new System.Drawing.Point(22, 139);
            this.companyCLabel.Name = "companyCLabel";
            this.companyCLabel.Size = new System.Drawing.Size(85, 13);
            this.companyCLabel.TabIndex = 13;
            this.companyCLabel.Text = "Company C Cost";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelForResults
            // 
            this.panelForResults.Controls.Add(this.resultsLabel);
            this.panelForResults.Controls.Add(this.companyCOutput);
            this.panelForResults.Controls.Add(this.companyCLabel);
            this.panelForResults.Controls.Add(this.companyBLabel);
            this.panelForResults.Controls.Add(this.companyBOutput);
            this.panelForResults.Controls.Add(this.companyAOutput);
            this.panelForResults.Controls.Add(this.companyALabel);
            this.panelForResults.Controls.Add(this.lowestCostOutput);
            this.panelForResults.Location = new System.Drawing.Point(471, 75);
            this.panelForResults.Name = "panelForResults";
            this.panelForResults.Size = new System.Drawing.Size(249, 226);
            this.panelForResults.TabIndex = 14;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(22, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.resultsLabel.TabIndex = 15;
            this.resultsLabel.Text = "Results";
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelForResults);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.deliveryTextBox);
            this.Controls.Add(this.packageWeightTextBox);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.packageWeightLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelForResults.ResumeLayout(false);
            this.panelForResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label packageWeightLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.Label companyBOutput;
        private System.Windows.Forms.Label companyCOutput;
        private System.Windows.Forms.Label companyAOutput;
        private System.Windows.Forms.TextBox packageWeightTextBox;
        private System.Windows.Forms.TextBox deliveryTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label lowestCostOutput;
        private System.Windows.Forms.Label companyBLabel;
        private System.Windows.Forms.Label companyALabel;
        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.Label companyCLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panelForResults;
        private System.Windows.Forms.Label resultsLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
    }
}

