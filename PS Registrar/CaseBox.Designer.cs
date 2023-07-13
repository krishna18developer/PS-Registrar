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
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.caseDateCreated = new System.Windows.Forms.Label();
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
            // caseDateCreated
            // 
            this.caseDateCreated.AutoSize = true;
            this.caseDateCreated.Location = new System.Drawing.Point(12, 94);
            this.caseDateCreated.Name = "caseDateCreated";
            this.caseDateCreated.Size = new System.Drawing.Size(97, 13);
            this.caseDateCreated.TabIndex = 1;
            this.caseDateCreated.Text = "Case Date Created";
            // 
            // CaseBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 116);
            this.Controls.Add(this.caseDateCreated);
            this.Controls.Add(this.caseNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaseBox";
            this.Text = "CaseBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caseNameLabel;
        private System.Windows.Forms.Label caseDateCreated;
    }
}