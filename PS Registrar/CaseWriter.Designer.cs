namespace PS_Registrar
{
    partial class CaseWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseWriter));
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.caseNameBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.slNoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FIRBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPDetailsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DORBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.accusedDetailsBox = new System.Windows.Forms.TextBox();
            this.modeOfCrimeBox = new System.Windows.Forms.TextBox();
            this.propertyLostBox = new System.Windows.Forms.TextBox();
            this.remarksBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveCaseButton = new System.Windows.Forms.Button();
            this.caseIDLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.accusedPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.accusedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // caseNameLabel
            // 
            this.caseNameLabel.AutoSize = true;
            this.caseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseNameLabel.Location = new System.Drawing.Point(12, 42);
            this.caseNameLabel.Name = "caseNameLabel";
            this.caseNameLabel.Size = new System.Drawing.Size(96, 20);
            this.caseNameLabel.TabIndex = 4;
            this.caseNameLabel.Text = "Case Name:";
            // 
            // caseNameBox
            // 
            this.caseNameBox.Location = new System.Drawing.Point(177, 42);
            this.caseNameBox.Name = "caseNameBox";
            this.caseNameBox.Size = new System.Drawing.Size(559, 20);
            this.caseNameBox.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(9, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back To Dashboard";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "SL No:";
            // 
            // slNoBox
            // 
            this.slNoBox.Location = new System.Drawing.Point(177, 78);
            this.slNoBox.Name = "slNoBox";
            this.slNoBox.Size = new System.Drawing.Size(559, 20);
            this.slNoBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "FIR No:";
            // 
            // FIRBox
            // 
            this.FIRBox.Location = new System.Drawing.Point(177, 117);
            this.FIRBox.Name = "FIRBox";
            this.FIRBox.Size = new System.Drawing.Size(559, 20);
            this.FIRBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Complaintant Details:";
            // 
            // CPDetailsBox
            // 
            this.CPDetailsBox.Location = new System.Drawing.Point(176, 196);
            this.CPDetailsBox.Multiline = true;
            this.CPDetailsBox.Name = "CPDetailsBox";
            this.CPDetailsBox.Size = new System.Drawing.Size(560, 140);
            this.CPDetailsBox.TabIndex = 12;
            this.CPDetailsBox.TextChanged += new System.EventHandler(this.CPDetailsBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Of Report:";
            // 
            // DORBox
            // 
            this.DORBox.Location = new System.Drawing.Point(176, 160);
            this.DORBox.Name = "DORBox";
            this.DORBox.Size = new System.Drawing.Size(354, 20);
            this.DORBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 672);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Property Lost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mode Of Crime:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Accused Details:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(761, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Remarks:";
            // 
            // accusedDetailsBox
            // 
            this.accusedDetailsBox.Location = new System.Drawing.Point(176, 351);
            this.accusedDetailsBox.Multiline = true;
            this.accusedDetailsBox.Name = "accusedDetailsBox";
            this.accusedDetailsBox.Size = new System.Drawing.Size(560, 140);
            this.accusedDetailsBox.TabIndex = 22;
            // 
            // modeOfCrimeBox
            // 
            this.modeOfCrimeBox.Location = new System.Drawing.Point(177, 509);
            this.modeOfCrimeBox.Multiline = true;
            this.modeOfCrimeBox.Name = "modeOfCrimeBox";
            this.modeOfCrimeBox.Size = new System.Drawing.Size(560, 140);
            this.modeOfCrimeBox.TabIndex = 23;
            // 
            // propertyLostBox
            // 
            this.propertyLostBox.Location = new System.Drawing.Point(177, 655);
            this.propertyLostBox.Multiline = true;
            this.propertyLostBox.Name = "propertyLostBox";
            this.propertyLostBox.Size = new System.Drawing.Size(560, 140);
            this.propertyLostBox.TabIndex = 24;
            // 
            // remarksBox
            // 
            this.remarksBox.Location = new System.Drawing.Point(764, 63);
            this.remarksBox.Multiline = true;
            this.remarksBox.Name = "remarksBox";
            this.remarksBox.Size = new System.Drawing.Size(560, 140);
            this.remarksBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(761, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Accused Picture:";
            // 
            // saveCaseButton
            // 
            this.saveCaseButton.Location = new System.Drawing.Point(176, 10);
            this.saveCaseButton.Name = "saveCaseButton";
            this.saveCaseButton.Size = new System.Drawing.Size(137, 23);
            this.saveCaseButton.TabIndex = 28;
            this.saveCaseButton.Text = "Save Case";
            this.saveCaseButton.UseVisualStyleBackColor = true;
            this.saveCaseButton.Click += new System.EventHandler(this.saveCaseButton_Click);
            // 
            // caseIDLabel
            // 
            this.caseIDLabel.AutoSize = true;
            this.caseIDLabel.Location = new System.Drawing.Point(333, 15);
            this.caseIDLabel.Name = "caseIDLabel";
            this.caseIDLabel.Size = new System.Drawing.Size(51, 13);
            this.caseIDLabel.TabIndex = 29;
            this.caseIDLabel.Text = "Case ID: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(537, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // accusedPictureBox
            // 
            this.accusedPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.accusedPictureBox.Image = global::PS_Registrar.Properties.Resources.click;
            this.accusedPictureBox.Location = new System.Drawing.Point(765, 261);
            this.accusedPictureBox.Name = "accusedPictureBox";
            this.accusedPictureBox.Size = new System.Drawing.Size(237, 243);
            this.accusedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accusedPictureBox.TabIndex = 27;
            this.accusedPictureBox.TabStop = false;
            this.accusedPictureBox.DoubleClick += new System.EventHandler(this.accusedPictureBox_DoubleClick);
            // 
            // CaseWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 815);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.caseIDLabel);
            this.Controls.Add(this.saveCaseButton);
            this.Controls.Add(this.accusedPictureBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.remarksBox);
            this.Controls.Add(this.propertyLostBox);
            this.Controls.Add(this.modeOfCrimeBox);
            this.Controls.Add(this.accusedDetailsBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPDetailsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DORBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIRBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slNoBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.caseNameLabel);
            this.Controls.Add(this.caseNameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaseWriter";
            this.Text = "CaseWriter";
            this.Load += new System.EventHandler(this.CaseWriter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accusedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caseNameLabel;
        private System.Windows.Forms.TextBox caseNameBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox slNoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIRBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPDetailsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DORBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox accusedDetailsBox;
        private System.Windows.Forms.TextBox modeOfCrimeBox;
        private System.Windows.Forms.TextBox propertyLostBox;
        private System.Windows.Forms.TextBox remarksBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox accusedPictureBox;
        private System.Windows.Forms.Button saveCaseButton;
        private System.Windows.Forms.Label caseIDLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}