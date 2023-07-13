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
            this.backButton = new System.Windows.Forms.Button();
            this.caseFilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.testButton = new System.Windows.Forms.Button();
            this.newCaseButton = new System.Windows.Forms.Button();
            this.openDataFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(123, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back To Login";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // caseFilesPanel
            // 
            this.caseFilesPanel.AutoScroll = true;
            this.caseFilesPanel.Location = new System.Drawing.Point(12, 51);
            this.caseFilesPanel.Name = "caseFilesPanel";
            this.caseFilesPanel.Size = new System.Drawing.Size(897, 591);
            this.caseFilesPanel.TabIndex = 2;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(151, 9);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(123, 23);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "Test Button";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // newCaseButton
            // 
            this.newCaseButton.Location = new System.Drawing.Point(289, 9);
            this.newCaseButton.Name = "newCaseButton";
            this.newCaseButton.Size = new System.Drawing.Size(123, 23);
            this.newCaseButton.TabIndex = 4;
            this.newCaseButton.Text = "New Case";
            this.newCaseButton.UseVisualStyleBackColor = true;
            this.newCaseButton.Click += new System.EventHandler(this.newCaseButton_Click);
            // 
            // openDataFolderButton
            // 
            this.openDataFolderButton.Location = new System.Drawing.Point(786, 12);
            this.openDataFolderButton.Name = "openDataFolderButton";
            this.openDataFolderButton.Size = new System.Drawing.Size(123, 23);
            this.openDataFolderButton.TabIndex = 5;
            this.openDataFolderButton.Text = "Open Data Folder";
            this.openDataFolderButton.UseVisualStyleBackColor = true;
            this.openDataFolderButton.Click += new System.EventHandler(this.openDataFolderButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 702);
            this.Controls.Add(this.openDataFolderButton);
            this.Controls.Add(this.newCaseButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.caseFilesPanel);
            this.Controls.Add(this.backButton);
            this.Name = "Dashboard";
            this.Text = "PS Registrar - Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel caseFilesPanel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button newCaseButton;
        private System.Windows.Forms.Button openDataFolderButton;
    }
}

