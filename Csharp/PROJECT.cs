namespace bigsys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to exit?",
        "Exit Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("colID", "Student ID");
            dataGridView1.Columns.Add("colName", "Name");
            dataGridView1.Columns.Add("colCourse", "Course");
            dataGridView1.Columns.Add("colGrade", "Grade");

            comboBox1.Items.Add("Machine learning");
            comboBox1.Items.Add("Artifical Intelligence");
            comboBox1.Items.Add("Programming fundaments");
            comboBox1.Items.Add("Database");
            comboBox1.Items.Add("OOP");
            comboBox1.Items.Add("Visual Programming");
            comboBox1.Items.Add("Computer Network");

            if (File.Exists("students.txt"))
            {
                string[] lines = File.ReadAllLines("students.txt");

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');

                    dataGridView1.Rows.Add(
                        data[0],
                        data[1],
                        data[2],
                        data[3]);
                }
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (TID.Text == "" || TN.Text == "" || comboBox1.Text == "" || TG.Text == "")
            {

                MessageBox.Show(
            "Please Fill The Fields First",
            "Warning",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            }

            else
            {
                dataGridView1.Rows.Add(
                    TID.Text, TN.Text, comboBox1.Text, TG.Text);
                MessageBox.Show(
                    "Record added successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );


            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TID.Clear();
            TN.Clear();
            TG.Clear();

            comboBox1.SelectedIndex = -1;

            TID.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;

                    dataGridView1.Rows.RemoveAt(rowIndex);

                    MessageBox.Show(
                        "Record Deleted Successfully",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                TID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TN.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TG.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows[rowIndex].Cells[0].Value = TID.Text;
                dataGridView1.Rows[rowIndex].Cells[1].Value = TN.Text;
                dataGridView1.Rows[rowIndex].Cells[2].Value = comboBox1.Text;
                dataGridView1.Rows[rowIndex].Cells[3].Value = TG.Text;

                MessageBox.Show(
                    "Record Updated Successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null &&
                    row.Cells[1].Value.ToString().ToLower()
                    .Contains(btn5.Text.ToLower()))
                {
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show(
                    "Record Not Found",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
