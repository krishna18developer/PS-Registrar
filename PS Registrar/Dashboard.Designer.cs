namespace PS_Registrar
{
    partial class Dashboard
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
            this.caseNameBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caseNameBox
            // 
            this.caseNameBox.Location = new System.Drawing.Point(83, 42);
            this.caseNameBox.Name = "caseNameBox";
            this.caseNameBox.Size = new System.Drawing.Size(542, 20);
            this.caseNameBox.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // caseNameLabel
            // 
            this.caseNameLabel.AutoSize = true;
            this.caseNameLabel.Location = new System.Drawing.Point(12, 45);
            this.caseNameLabel.Name = "caseNameLabel";
            this.caseNameLabel.Size = new System.Drawing.Size(65, 13);
            this.caseNameLabel.TabIndex = 2;
            this.caseNameLabel.Text = "Case Name:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 364);
            this.Controls.Add(this.caseNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.caseNameBox);
            this.Name = "Dashboard";
            this.Text = "PS Registrar - Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caseNameBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label caseNameLabel;
    }
}

