using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VocabularyLearningApp
{
    public partial class AddNewWordForm : Form
    {
        // Giả sử bạn có CreateFolderForm.selectedFolderName là folder hiện tại
        private string folderName = CreateFolderForm.selectedFolderName; // Đảm bảo bạn đã lấy giá trị folder

        public AddNewWordForm()
        {
            InitializeComponent();
        }

        private void AddNewWordForm_Load(object sender, EventArgs e)
        {
            listViewWords.View = View.Details;
            listViewWords.Columns.Add("Word", 150);
            listViewWords.Columns.Add("Meaning", 200);
            LoadWordsFromFolder(folderName);
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string word = txbWord.Text.Trim();
            string meaning = txbMeaning.Text.Trim();

            if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(meaning))
            {
                MessageBox.Show("Please enter both word and meaning.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=LAPTOP-9SU8K180\\SQLEXPRESS;Initial Catalog=coco;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra xem từ đã tồn tại chưa
                string checkQuery = "SELECT COUNT(*) FROM NewWord WHERE Word = @Word AND Folder = @Folder";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Word", word);
                    checkCommand.Parameters.AddWithValue("@Folder", folderName);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This word already exists in the selected folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Thêm từ vào database
                string query = "INSERT INTO NewWord (Word, Meaning, Folder, Remember) VALUES (@Word, @Meaning, @Folder, @Remember)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Word", word);
                    command.Parameters.AddWithValue("@Meaning", meaning);
                    command.Parameters.AddWithValue("@Folder", folderName);
                    command.Parameters.AddWithValue("@Remember", "R");

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Word added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadWordsFromFolder(folderName);
                        txbWord.Clear();
                        txbMeaning.Clear();
                        txbWord.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error adding word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            txbMeaning.Clear();
            txbWord.Clear();
            if (listViewWords.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a word to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listViewWords.SelectedItems[0];
            string wordToDelete = selectedItem.Text;

            string connectionString = "Data Source=LAPTOP-9SU8K180\\SQLEXPRESS;Initial Catalog=coco;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM NewWord WHERE Word = @Word AND Folder = @Folder";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Word", wordToDelete);
                    command.Parameters.AddWithValue("@Folder", folderName);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Word deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadWordsFromFolder(folderName);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditWord_Click(object sender, EventArgs e)
        {
            
            if (listViewWords.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a word to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string oldWord = listViewWords.SelectedItems[0].Text;
            string newWord = txbWord.Text.Trim();
            string newMeaning = txbMeaning.Text.Trim();

            if (string.IsNullOrEmpty(newWord) || string.IsNullOrEmpty(newMeaning))
            {
                MessageBox.Show("Please enter both word and meaning.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=LAPTOP-9SU8K180\\SQLEXPRESS;Initial Catalog=coco;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra nếu từ mới đã tồn tại trong folder (tránh trùng)
                string checkQuery = "SELECT COUNT(*) FROM NewWord WHERE Word = @NewWord AND Folder = @Folder";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@NewWord", newWord);
                    checkCommand.Parameters.AddWithValue("@Folder", folderName);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0 && !oldWord.Equals(newWord, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("This word already exists in the selected folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Cập nhật từ trong database
                string query = "UPDATE NewWord SET Word = @NewWord, Meaning = @NewMeaning WHERE Word = @OldWord AND Folder = @Folder";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewWord", newWord);
                    command.Parameters.AddWithValue("@NewMeaning", newMeaning);
                    command.Parameters.AddWithValue("@OldWord", oldWord);
                    command.Parameters.AddWithValue("@Folder", folderName);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Word updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadWordsFromFolder(folderName);
                    }
                    else
                    {
                        MessageBox.Show("Error updating word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txbMeaning.Clear();
                txbWord.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            LearnNewWordsForm learnNewWordsForm = new LearnNewWordsForm(CreateFolderForm.selectedFolderName);
            learnNewWordsForm.Show();
            this.Hide();
        }

        private void LoadWordsFromFolder(string folderName)
        {
            // Đảm bảo rằng ListView được làm mới trước khi thêm các item mới
            listViewWords.Items.Clear();

            // Chuỗi kết nối cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-9SU8K180\\SQLEXPRESS;Initial Catalog=coco;Integrated Security=True";

            // Câu lệnh SQL để lấy từ vựng theo tên Folder
            string query = "SELECT Word, Meaning FROM NewWord WHERE Folder = @Folder";

            // Mở kết nối với cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số Folder vào câu lệnh SQL
                    command.Parameters.AddWithValue("@Folder", folderName);

                    // Thực thi câu lệnh và lấy dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Đọc từng dòng dữ liệu trả về từ cơ sở dữ liệu
                        while (reader.Read())
                        {
                            string word = reader.GetString(0);    // Cột Word
                            string meaning = reader.GetString(1); // Cột Meaning

                            // Thêm dữ liệu vào ListView
                            ListViewItem item = new ListViewItem(word);
                            item.SubItems.Add(meaning);
                            listViewWords.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void listViewWords_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(listViewWords.SelectedItems.Count > 0)
    {
                ListViewItem selectedItem = listViewWords.SelectedItems[0];
                txbWord.Text = selectedItem.Text;
                txbMeaning.Text = selectedItem.SubItems[1].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateFolderForm createFolderForm = new CreateFolderForm();
            createFolderForm.Show();
            this.Close();
        }
    }
}
