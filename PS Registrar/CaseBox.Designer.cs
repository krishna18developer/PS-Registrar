﻿namespace PS_Registrar
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
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.caseDateReported = new System.Windows.Forms.Label();
            this.viewCaseButton = new System.Windows.Forms.Button();
            this.editCaseButton = new System.Windows.Forms.Button();
            this.deleteCaseButton = new System.Windows.Forms.Button();
            this.uniqueIDLabel = new System.Windows.Forms.Label();
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
            this.caseDateReported.Location = new System.Drawing.Point(12, 94);
            this.caseDateReported.Name = "caseDateReported";
            this.caseDateReported.Size = new System.Drawing.Size(104, 13);
            this.caseDateReported.TabIndex = 1;
            this.caseDateReported.Text = "Case Date Reported";
            // 
            // viewCaseButton
            // 
            this.viewCaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCaseButton.Location = new System.Drawing.Point(9, 117);
            this.viewCaseButton.Name = "viewCaseButton";
            this.viewCaseButton.Size = new System.Drawing.Size(133, 37);
            this.viewCaseButton.TabIndex = 2;
            this.viewCaseButton.Text = "View Case";
            this.viewCaseButton.UseVisualStyleBackColor = true;
            // 
            // editCaseButton
            // 
            this.editCaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCaseButton.Location = new System.Drawing.Point(148, 117);
            this.editCaseButton.Name = "editCaseButton";
            this.editCaseButton.Size = new System.Drawing.Size(133, 37);
            this.editCaseButton.TabIndex = 3;
            this.editCaseButton.Text = "Edit Case";
            this.editCaseButton.UseVisualStyleBackColor = true;
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
            // CaseBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 166);
            this.Controls.Add(this.uniqueIDLabel);
            this.Controls.Add(this.deleteCaseButton);
            this.Controls.Add(this.editCaseButton);
            this.Controls.Add(this.viewCaseButton);
            this.Controls.Add(this.caseDateReported);
            this.Controls.Add(this.caseNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaseBox";
            this.Text = "CaseBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caseNameLabel;
        private System.Windows.Forms.Label caseDateReported;
        private System.Windows.Forms.Button viewCaseButton;
        private System.Windows.Forms.Button editCaseButton;
        private System.Windows.Forms.Button deleteCaseButton;
        private System.Windows.Forms.Label uniqueIDLabel;
    }
}