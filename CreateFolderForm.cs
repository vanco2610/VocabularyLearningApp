using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VocabularyLearningApp
{
    public partial class CreateFolderForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable foldersTable;
        public static string selectedFolderName = ""; 

        public CreateFolderForm()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            connection = new SqlConnection("Data Source=LAPTOP-9SU8K180\\SQLEXPRESS;Initial Catalog=coco;Integrated Security=True");
            listViewFolders.View = View.Details;
            LoadFolders();
        }

        private void LoadFolders()
        {
            listViewFolders.Items.Clear();
            string query = "SELECT Folder, COUNT(*) AS WordCount FROM NewWord GROUP BY Folder";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string folderName = reader["Folder"].ToString();
                    string wordCount = reader["WordCount"].ToString();
                    ListViewItem item = new ListViewItem(folderName);
                    item.SubItems.Add(wordCount);
                    listViewFolders.Items.Add(item);
                }
                reader.Close();
                connection.Close();
            }
        }

        private void btnInsertFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFolderName.Text))
            {
                MessageBox.Show("Please enter a folder name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            selectedFolderName = textBoxFolderName.Text; 
            AddNewWordForm addNewWordForm = new AddNewWordForm();
            addNewWordForm.Show();
            this.Hide();
        }

        private void btnOpenAddWordForm_Click(object sender, EventArgs e)
        {
           
        }

        private void listViewFolders_ItemActivate(object sender, EventArgs e)
        {
            if (listViewFolders.SelectedItems.Count > 0)
            {
                selectedFolderName = listViewFolders.SelectedItems[0].Text; // Lưu folder đang chọn
                AddNewWordForm addNewWordForm = new AddNewWordForm();
                addNewWordForm.Show();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
