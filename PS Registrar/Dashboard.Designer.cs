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
            this.caseListView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // caseListView
            // 
            this.caseListView.HideSelection = false;
            this.caseListView.Location = new System.Drawing.Point(12, 47);
            this.caseListView.Name = "caseListView";
            this.caseListView.Size = new System.Drawing.Size(973, 595);
            this.caseListView.TabIndex = 0;
            this.caseListView.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(991, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 156);
            this.panel1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caseListView);
            this.Controls.Add(this.backButton);
            this.Name = "Dashboard";
            this.Text = "PS Registrar - Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView caseListView;
        private System.Windows.Forms.Panel panel1;
    }
}

