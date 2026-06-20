namespace gridtotree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("NAME", "NAME");

            dataGridView1.Rows.Add("101", "hafsa");
            dataGridView1.Rows.Add("102", "zeba");
            dataGridView1.Rows.Add("103", "fiza");




        }

        private void btn1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string id = row.Cells[0].Value.ToString();
                    string name = row.Cells[1].Value.ToString();

                    treeView1.Nodes.Add(id + " - " + name);
                }
            }
        }
    }
}