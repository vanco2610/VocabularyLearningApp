using System;

namespace VocabularyLearningApp
{
    partial class AddNewWordForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txbWord;
        private System.Windows.Forms.TextBox txbMeaning;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnEditWord;
        private System.Windows.Forms.ListView listViewWords;
        private System.Windows.Forms.Button btnLearn;

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
            this.txbWord = new System.Windows.Forms.TextBox();
            this.txbMeaning = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnEditWord = new System.Windows.Forms.Button();
            this.listViewWords = new System.Windows.Forms.ListView();
            this.btnLearn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbWord
            // 
            this.txbWord.Location = new System.Drawing.Point(280, 48);
            this.txbWord.Name = "txbWord";
            this.txbWord.Size = new System.Drawing.Size(456, 20);
            this.txbWord.TabIndex = 1;
            // 
            // txbMeaning
            // 
            this.txbMeaning.Location = new System.Drawing.Point(280, 114);
            this.txbMeaning.Name = "txbMeaning";
            this.txbMeaning.Size = new System.Drawing.Size(456, 20);
            this.txbMeaning.TabIndex = 2;
            // 
            // btnAddWord
            // 
            this.btnAddWord.AutoSize = true;
            this.btnAddWord.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnAddWord.Location = new System.Drawing.Point(280, 162);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(107, 35);
            this.btnAddWord.TabIndex = 3;
            this.btnAddWord.Text = "Add";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnClose.Location = new System.Drawing.Point(757, 499);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.AutoSize = true;
            this.btnDeleteWord.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnDeleteWord.Location = new System.Drawing.Point(467, 162);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(107, 35);
            this.btnDeleteWord.TabIndex = 5;
            this.btnDeleteWord.Text = "Delete";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // btnEditWord
            // 
            this.btnEditWord.AutoSize = true;
            this.btnEditWord.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEditWord.Location = new System.Drawing.Point(629, 162);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(107, 35);
            this.btnEditWord.TabIndex = 6;
            this.btnEditWord.Text = "Edit";
            this.btnEditWord.UseVisualStyleBackColor = true;
            this.btnEditWord.Click += new System.EventHandler(this.btnEditWord_Click);
            // 
            // listViewWords
            // 
            this.listViewWords.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listViewWords.HideSelection = false;
            this.listViewWords.Location = new System.Drawing.Point(31, 223);
            this.listViewWords.Name = "listViewWords";
            this.listViewWords.Size = new System.Drawing.Size(783, 259);
            this.listViewWords.TabIndex = 7;
            this.listViewWords.UseCompatibleStateImageBehavior = false;
            this.listViewWords.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewWords_ItemSelectionChanged);
            // 
            // btnLearn
            // 
            this.btnLearn.AutoSize = true;
            this.btnLearn.BackColor = System.Drawing.Color.SlateGray;
            this.btnLearn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLearn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLearn.Location = new System.Drawing.Point(707, 427);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(79, 35);
            this.btnLearn.TabIndex = 8;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = false;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(102, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Word";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(93, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Meaning";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button1.Location = new System.Drawing.Point(661, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewWordForm
            // 
            this.ClientSize = new System.Drawing.Size(844, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.listViewWords);
            this.Controls.Add(this.btnEditWord);
            this.Controls.Add(this.btnDeleteWord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.txbMeaning);
            this.Controls.Add(this.txbWord);
            this.Name = "AddNewWordForm";
            this.Text = "Add New Word";
            this.Load += new System.EventHandler(this.AddNewWordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}