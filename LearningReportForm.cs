using System;
using System.Windows.Forms;

namespace VocabularyLearningApp
{
    public partial class LearningReportForm : Form
    {
        private int rememberedWords;
        private int notRememberedWords;

        public LearningReportForm(int remembered, int notRemembered)
        {
            InitializeComponent();
            rememberedWords = remembered;
            notRememberedWords = notRemembered;
            LoadReport();
        }

        private void LoadReport()
        {
            txbRemember.Text = $"{rememberedWords}";
            txbNotRemember.Text = $"{notRememberedWords}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateFolderForm createFolderForm = new CreateFolderForm();
            createFolderForm.Show();
            this.Close();
        }
    }

}