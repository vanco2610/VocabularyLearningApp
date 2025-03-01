using System;
using System.Data.SqlClient;

namespace VocabularyLearningApp
{
    partial class LearnNewWordsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button btnShowMeaning;
        private System.Windows.Forms.Button btnRemembered;
        private System.Windows.Forms.Button btnNotRemembered;
        private System.Windows.Forms.Button btnEndSession;

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
            this.labelWord = new System.Windows.Forms.Label();
            this.btnShowMeaning = new System.Windows.Forms.Button();
            this.btnRemembered = new System.Windows.Forms.Button();
            this.btnNotRemembered = new System.Windows.Forms.Button();
            this.btnEndSession = new System.Windows.Forms.Button();
            this.txbWord = new System.Windows.Forms.TextBox();
            this.txbMeaning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(114, 93);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(67, 30);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "Word";
            // 
            // btnShowMeaning
            // 
            this.btnShowMeaning.AutoSize = true;
            this.btnShowMeaning.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnShowMeaning.Location = new System.Drawing.Point(566, 132);
            this.btnShowMeaning.Name = "btnShowMeaning";
            this.btnShowMeaning.Size = new System.Drawing.Size(138, 40);
            this.btnShowMeaning.TabIndex = 2;
            this.btnShowMeaning.Text = "Show Meaning";
            this.btnShowMeaning.UseVisualStyleBackColor = true;
            this.btnShowMeaning.Click += new System.EventHandler(this.btnShowMeaning_Click);
            // 
            // btnRemembered
            // 
            this.btnRemembered.AutoSize = true;
            this.btnRemembered.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRemembered.Location = new System.Drawing.Point(142, 281);
            this.btnRemembered.Name = "btnRemembered";
            this.btnRemembered.Size = new System.Drawing.Size(148, 40);
            this.btnRemembered.TabIndex = 3;
            this.btnRemembered.Text = "Remembered";
            this.btnRemembered.UseVisualStyleBackColor = true;
            this.btnRemembered.Click += new System.EventHandler(this.btnRemembered_Click);
            // 
            // btnNotRemembered
            // 
            this.btnNotRemembered.AutoSize = true;
            this.btnNotRemembered.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnNotRemembered.Location = new System.Drawing.Point(374, 281);
            this.btnNotRemembered.Name = "btnNotRemembered";
            this.btnNotRemembered.Size = new System.Drawing.Size(148, 40);
            this.btnNotRemembered.TabIndex = 4;
            this.btnNotRemembered.Text = "Not Remembered";
            this.btnNotRemembered.UseVisualStyleBackColor = true;
            this.btnNotRemembered.Click += new System.EventHandler(this.btnNotRemembered_Click);
            // 
            // btnEndSession
            // 
            this.btnEndSession.AutoSize = true;
            this.btnEndSession.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEndSession.Location = new System.Drawing.Point(604, 366);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(136, 35);
            this.btnEndSession.TabIndex = 5;
            this.btnEndSession.Text = "End Session";
            this.btnEndSession.UseVisualStyleBackColor = true;
            this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
            // 
            // txbWord
            // 
            this.txbWord.Location = new System.Drawing.Point(263, 103);
            this.txbWord.Name = "txbWord";
            this.txbWord.Size = new System.Drawing.Size(259, 20);
            this.txbWord.TabIndex = 6;
            // 
            // txbMeaning
            // 
            this.txbMeaning.Location = new System.Drawing.Point(263, 184);
            this.txbMeaning.Name = "txbMeaning";
            this.txbMeaning.Size = new System.Drawing.Size(259, 20);
            this.txbMeaning.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(100, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Meaning";
            // 
            // LearnNewWordsForm
            // 
            this.ClientSize = new System.Drawing.Size(752, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMeaning);
            this.Controls.Add(this.txbWord);
            this.Controls.Add(this.btnEndSession);
            this.Controls.Add(this.btnNotRemembered);
            this.Controls.Add(this.btnRemembered);
            this.Controls.Add(this.btnShowMeaning);
            this.Controls.Add(this.labelWord);
            this.Name = "LearnNewWordsForm";
            this.Text = "Learn New Words";
            this.Load += new System.EventHandler(this.LearnNewWordsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LearnNewWordsForm_Load(object sender, EventArgs e)
        {
            LoadWords();
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            int rememberedCount = 0;
            int notRememberedCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Remember FROM NewWord WHERE Folder = @Folder";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Folder", selectedFolderName);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader["Remember"].ToString();
                            if (status == "R")
                                rememberedCount++;
                            else if (status == "N")
                                notRememberedCount++;
                        }
                    }
                }
            }

            // Mở form báo cáo và truyền số từ đã nhớ và chưa nhớ
            LearningReportForm reportForm = new LearningReportForm(rememberedCount, notRememberedCount);
            reportForm.Show();

            this.Close(); // Đóng form hiện tại
        }

        private void btnRemembered_Click(object sender, EventArgs e)
        {

            UpdateWordRememberStatus("R"); // Đánh dấu từ là đã nhớ
            ShowNextWord();
        }

        private System.Windows.Forms.TextBox txbWord;
        private System.Windows.Forms.TextBox txbMeaning;
        private System.Windows.Forms.Label label1;
    }
}