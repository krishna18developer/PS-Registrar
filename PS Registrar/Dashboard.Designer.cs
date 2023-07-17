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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.backButton = new System.Windows.Forms.Button();
            this.caseFilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newCaseButton = new System.Windows.Forms.Button();
            this.openDataFolderButton = new System.Windows.Forms.Button();
            this.reloadCasesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FIRSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openCaseWithFIRButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.caseFilesPanel.BackColor = System.Drawing.Color.Transparent;
            this.caseFilesPanel.Location = new System.Drawing.Point(12, 51);
            this.caseFilesPanel.Name = "caseFilesPanel";
            this.caseFilesPanel.Size = new System.Drawing.Size(984, 547);
            this.caseFilesPanel.TabIndex = 2;
            this.caseFilesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.caseFilesPanel_Paint);
            // 
            // newCaseButton
            // 
            this.newCaseButton.Location = new System.Drawing.Point(141, 9);
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
            // reloadCasesButton
            // 
            this.reloadCasesButton.Location = new System.Drawing.Point(270, 9);
            this.reloadCasesButton.Name = "reloadCasesButton";
            this.reloadCasesButton.Size = new System.Drawing.Size(123, 23);
            this.reloadCasesButton.TabIndex = 6;
            this.reloadCasesButton.Text = "Reload Cases";
            this.reloadCasesButton.UseVisualStyleBackColor = true;
            this.reloadCasesButton.Click += new System.EventHandler(this.reloadCasesButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS_Registrar.Properties.Resources.Telangana_Police_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(848, 604);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FIRSearchBox
            // 
            this.FIRSearchBox.Location = new System.Drawing.Point(153, 637);
            this.FIRSearchBox.Name = "FIRSearchBox";
            this.FIRSearchBox.Size = new System.Drawing.Size(200, 20);
            this.FIRSearchBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search By FIR:";
            // 
            // openCaseWithFIRButton
            // 
            this.openCaseWithFIRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCaseWithFIRButton.Location = new System.Drawing.Point(370, 634);
            this.openCaseWithFIRButton.Name = "openCaseWithFIRButton";
            this.openCaseWithFIRButton.Size = new System.Drawing.Size(192, 43);
            this.openCaseWithFIRButton.TabIndex = 10;
            this.openCaseWithFIRButton.Text = "Open Case By FIR";
            this.openCaseWithFIRButton.UseVisualStyleBackColor = true;
            this.openCaseWithFIRButton.Click += new System.EventHandler(this.openCaseWithFIRButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 757);
            this.Controls.Add(this.openCaseWithFIRButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIRSearchBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reloadCasesButton);
            this.Controls.Add(this.openDataFolderButton);
            this.Controls.Add(this.newCaseButton);
            this.Controls.Add(this.caseFilesPanel);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "PS Registrar - Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel caseFilesPanel;
        private System.Windows.Forms.Button newCaseButton;
        private System.Windows.Forms.Button openDataFolderButton;
        private System.Windows.Forms.Button reloadCasesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FIRSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openCaseWithFIRButton;
    }
}

