using System.Security.Policy;

namespace habittracker
{
    public partial class Form1 : Form

    {
        int totalhabit = 0;
        int completehabit = 0;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listView1.Items.Add(textBox1.Text + " NOT DONE YET");
                textBox1.Clear();
                totalhabit++;
                UpdateProgress();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string item = listView1.SelectedItems[0].Text;

                if (item.Contains("NOT DONE YET"))
                {
                    listView1.SelectedItems[0].Text =
                        item.Replace("NOT DONE YET", "DONE");

                    completehabit++;
                }

                UpdateProgress();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox1.Clear() ;
            totalhabit = 0;
            completehabit = 0;
            progressBar1.Value = 0;
        }

        private void UpdateProgress()
        {
            if (totalhabit == 0)
            {
                progressBar1.Value = 0;
                return;
            }

            int progress = (completehabit * 100) / totalhabit;

            if (progress > 100) progress = 100;
            if (progress < 0) progress = 0;

            progressBar1.Value = progress;
        }
    }
}
