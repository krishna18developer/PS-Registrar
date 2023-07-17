namespace PS_Registrar
{
    partial class CaseBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseBox));
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.caseDateReported = new System.Windows.Forms.Label();
            this.openCaseButton = new System.Windows.Forms.Button();
            this.deleteCaseButton = new System.Windows.Forms.Button();
            this.uniqueIDLabel = new System.Windows.Forms.Label();
            this.FIRNoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caseNameLabel
            // 
            this.caseNameLabel.AutoSize = true;
            this.caseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseNameLabel.Location = new System.Drawing.Point(12, 9);
            this.caseNameLabel.Name = "caseNameLabel";
            this.caseNameLabel.Size = new System.Drawing.Size(136, 25);
            this.caseNameLabel.TabIndex = 0;
            this.caseNameLabel.Text = "CASE NAME";
            // 
            // caseDateReported
            // 
            this.caseDateReported.AutoSize = true;
            this.caseDateReported.Location = new System.Drawing.Point(14, 89);
            this.caseDateReported.Name = "caseDateReported";
            this.caseDateReported.Size = new System.Drawing.Size(104, 13);
            this.caseDateReported.TabIndex = 1;
            this.caseDateReported.Text = "Case Date Reported";
            // 
            // openCaseButton
            // 
            this.openCaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCaseButton.Location = new System.Drawing.Point(17, 117);
            this.openCaseButton.Name = "openCaseButton";
            this.openCaseButton.Size = new System.Drawing.Size(133, 37);
            this.openCaseButton.TabIndex = 3;
            this.openCaseButton.Text = "Open Case";
            this.openCaseButton.UseVisualStyleBackColor = true;
            this.openCaseButton.Click += new System.EventHandler(this.openCaseButton_Click);
            // 
            // deleteCaseButton
            // 
            this.deleteCaseButton.BackColor = System.Drawing.Color.Red;
            this.deleteCaseButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteCaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCaseButton.Location = new System.Drawing.Point(287, 117);
            this.deleteCaseButton.Name = "deleteCaseButton";
            this.deleteCaseButton.Size = new System.Drawing.Size(133, 37);
            this.deleteCaseButton.TabIndex = 4;
            this.deleteCaseButton.Text = "Delete Case";
            this.deleteCaseButton.UseVisualStyleBackColor = false;
            this.deleteCaseButton.Click += new System.EventHandler(this.deleteCaseButton_Click);
            // 
            // uniqueIDLabel
            // 
            this.uniqueIDLabel.AutoSize = true;
            this.uniqueIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqueIDLabel.Location = new System.Drawing.Point(291, 89);
            this.uniqueIDLabel.Name = "uniqueIDLabel";
            this.uniqueIDLabel.Size = new System.Drawing.Size(84, 25);
            this.uniqueIDLabel.TabIndex = 5;
            this.uniqueIDLabel.Text = "UNQ ID";
            // 
            // FIRNoLabel
            // 
            this.FIRNoLabel.AutoSize = true;
            this.FIRNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRNoLabel.Location = new System.Drawing.Point(14, 51);
            this.FIRNoLabel.Name = "FIRNoLabel";
            this.FIRNoLabel.Size = new System.Drawing.Size(57, 25);
            this.FIRNoLabel.TabIndex = 6;
            this.FIRNoLabel.Text = "FIR: ";
            // 
            // CaseBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 166);
            this.Controls.Add(this.FIRNoLabel);
            this.Controls.Add(this.uniqueIDLabel);
            this.Controls.Add(this.deleteCaseButton);
            this.Controls.Add(this.openCaseButton);
            this.Controls.Add(this.caseDateReported);
            this.Controls.Add(this.caseNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaseBox";
            this.Text = "CaseBox";
            this.Load += new System.EventHandler(this.CaseBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caseNameLabel;
        private System.Windows.Forms.Label caseDateReported;
        private System.Windows.Forms.Button openCaseButton;
        private System.Windows.Forms.Button deleteCaseButton;
        private System.Windows.Forms.Label uniqueIDLabel;
        private System.Windows.Forms.Label FIRNoLabel;
    }
}