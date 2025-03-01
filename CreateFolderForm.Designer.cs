namespace VocabularyLearningApp
{
    partial class CreateFolderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxFolderName;
        private System.Windows.Forms.Button btnInsertFolder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView listViewFolders;

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
            this.textBoxFolderName = new System.Windows.Forms.TextBox();
            this.btnInsertFolder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listViewFolders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFolderName
            // 
            this.textBoxFolderName.Location = new System.Drawing.Point(139, 41);
            this.textBoxFolderName.Name = "textBoxFolderName";
            this.textBoxFolderName.Size = new System.Drawing.Size(249, 20);
            this.textBoxFolderName.TabIndex = 0;
            // 
            // btnInsertFolder
            // 
            this.btnInsertFolder.AutoSize = true;
            this.btnInsertFolder.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnInsertFolder.Location = new System.Drawing.Point(407, 33);
            this.btnInsertFolder.Name = "btnInsertFolder";
            this.btnInsertFolder.Size = new System.Drawing.Size(81, 35);
            this.btnInsertFolder.TabIndex = 1;
            this.btnInsertFolder.Text = "Insert";
            this.btnInsertFolder.UseVisualStyleBackColor = true;
            this.btnInsertFolder.Click += new System.EventHandler(this.btnInsertFolder_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnClose.Location = new System.Drawing.Point(413, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listViewFolders
            // 
            this.listViewFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewFolders.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listViewFolders.HideSelection = false;
            this.listViewFolders.Location = new System.Drawing.Point(28, 115);
            this.listViewFolders.Name = "listViewFolders";
            this.listViewFolders.Size = new System.Drawing.Size(460, 230);
            this.listViewFolders.TabIndex = 3;
            this.listViewFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFolders.View = System.Windows.Forms.View.Details;
            this.listViewFolders.SelectedIndexChanged += new System.EventHandler(this.listViewFolders_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Folder Name";
            this.columnHeader1.Width = 197;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number of word";
            this.columnHeader2.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Folder Name";
            // 
            // CreateFolderForm
            // 
            this.ClientSize = new System.Drawing.Size(516, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewFolders);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsertFolder);
            this.Controls.Add(this.textBoxFolderName);
            this.Name = "CreateFolderForm";
            this.Text = "Create Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
    }
}