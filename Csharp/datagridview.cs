namespace datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Student ID");
            dataGridView1.Columns.Add("Name", "Student Name");
            dataGridView1.Columns.Add("Marks", "Marks");

            dataGridView1.Rows.Add("1", "Ali", "85");
            dataGridView1.Rows.Add("2", "Ahmed", "90");
            dataGridView1.Rows.Add("3", "Sara", "88");
        }
    }
}
