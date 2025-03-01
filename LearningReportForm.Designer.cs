using System;

namespace VocabularyLearningApp
{
    partial class LearningReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTotalWords;
        private System.Windows.Forms.Label labelRememberedWords;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Button btnWordsAddedToday;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTotalWords = new System.Windows.Forms.Label();
            this.labelRememberedWords = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.btnWordsAddedToday = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbRemember = new System.Windows.Forms.TextBox();
            this.txbNotRemember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotalWords
            // 
            this.labelTotalWords.AutoSize = true;
            this.labelTotalWords.Location = new System.Drawing.Point(12, 9);
            this.labelTotalWords.Name = "labelTotalWords";
            this.labelTotalWords.Size = new System.Drawing.Size(68, 13);
            this.labelTotalWords.TabIndex = 0;
            this.labelTotalWords.Text = "Total Words:";
            // 
            // labelRememberedWords
            // 
            this.labelRememberedWords.AutoSize = true;
            this.labelRememberedWords.Location = new System.Drawing.Point(12, 35);
            this.labelRememberedWords.Name = "labelRememberedWords";
            this.labelRememberedWords.Size = new System.Drawing.Size(100, 23);
            this.labelRememberedWords.TabIndex = 0;
            // 
            // labelPercentage
            // 
            this.labelPercentage.Location = new System.Drawing.Point(0, 0);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(100, 23);
            this.labelPercentage.TabIndex = 0;
            // 
            // btnWordsAddedToday
            // 
            this.btnWordsAddedToday.Location = new System.Drawing.Point(0, 0);
            this.btnWordsAddedToday.Name = "btnWordsAddedToday";
            this.btnWordsAddedToday.Size = new System.Drawing.Size(75, 23);
            this.btnWordsAddedToday.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button1.Location = new System.Drawing.Point(190, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbRemember
            // 
            this.txbRemember.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRemember.Location = new System.Drawing.Point(300, 105);
            this.txbRemember.Name = "txbRemember";
            this.txbRemember.Size = new System.Drawing.Size(78, 33);
            this.txbRemember.TabIndex = 1;
            // 
            // txbNotRemember
            // 
            this.txbNotRemember.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNotRemember.Location = new System.Drawing.Point(300, 174);
            this.txbNotRemember.Name = "txbNotRemember";
            this.txbNotRemember.Size = new System.Drawing.Size(78, 33);
            this.txbNotRemember.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(57, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remembered Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(44, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Not Remembered Word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(90, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Learning Session Report";
            // 
            // LearningReportForm
            // 
            this.ClientSize = new System.Drawing.Size(442, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNotRemember);
            this.Controls.Add(this.txbRemember);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Name = "LearningReportForm";
            this.Load += new System.EventHandler(this.LearningReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LearningReportForm_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbRemember;
        private System.Windows.Forms.TextBox txbNotRemember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}