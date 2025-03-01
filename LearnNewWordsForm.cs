using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VocabularyLearningApp
{
    public partial class LearnNewWordsForm : Form
    {
        private DataTable wordsTable;
        private int currentWordIndex;
        private string selectedFolderName;
        private string connectionString = "Data Source=LAPTOP-9SU8K180\\SQLEXPRESS;Initial Catalog=coco;Integrated Security=True";

        public LearnNewWordsForm(string folderName)
        {
            InitializeComponent();
            selectedFolderName = folderName;
            LoadWords();
        }

        private void LoadWords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Word, Meaning FROM NewWord WHERE Folder = @Folder";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Folder", selectedFolderName);

                wordsTable = new DataTable();
                adapter.Fill(wordsTable);
                currentWordIndex = 0;
                ShowNextWord();
            }
        }

        private void ShowNextWord()
        {
            if (currentWordIndex < wordsTable.Rows.Count)
            {
                txbWord.Text = wordsTable.Rows[currentWordIndex]["Word"].ToString();
                txbMeaning.Text = wordsTable.Rows[currentWordIndex]["Meaning"].ToString();
                txbMeaning.Visible = false;
            }
            else
            {
                RepeatUnrememberedWords();
            }
        }

        private void RepeatUnrememberedWords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Word, Meaning FROM NewWord WHERE Folder = @Folder AND Remember = 'N'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Folder", selectedFolderName);
                wordsTable.Clear();
                adapter.Fill(wordsTable);
                currentWordIndex = 0;

                if (wordsTable.Rows.Count == 0)
                {
                    MessageBox.Show("Congratulations! You've remembered all words.", "Session Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    CreateFolderForm createFolderForm = new CreateFolderForm();
                    createFolderForm.Show();
                    
                }
                else
                {
                    ShowNextWord();
                }
            }
        }

        private void UpdateWordRememberStatus(string status)
        {
            string word = txbWord.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE NewWord SET Remember = @Remember WHERE Word = @Word AND Folder = @Folder";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Remember", status);
                    command.Parameters.AddWithValue("@Word", word);
                    command.Parameters.AddWithValue("@Folder", selectedFolderName);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            currentWordIndex++;
            ShowNextWord();
        }

        private void btnShowMeaning_Click(object sender, EventArgs e)
        {
            txbMeaning.Visible = true;
        }

        private void btnRemember_Click(object sender, EventArgs e)
        {
            UpdateWordRememberStatus("R");
            ShowNextWord();
        }

        private void btnNotRemembered_Click(object sender, EventArgs e)
        {
            UpdateWordRememberStatus("N");
            ShowNextWord();
        }
    }
}
