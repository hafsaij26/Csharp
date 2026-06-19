using static attendence_sys.Form1;

namespace attendence_sys
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        public class Student
        {
            public string Name { get; set; }

            public int PresentDays { get; set; }

            public int AbsentDays { get; set; }

            public int TotalDays { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtboxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbln_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtboxname.Text == "")
            {
                MessageBox.Show("Please do not add First Enter Student Name");
                return;
            }

            Student s = new Student();

            s.Name = txtboxname.Text;
            s.PresentDays = 0;
            s.AbsentDays = 0;
            s.TotalDays = 0;

            students.Add(s);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;

            txtboxname.Clear();
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a student");
                return;
            }

            int index = dataGridView1.CurrentRow.Index;

            students[index].PresentDays++;
            students[index].TotalDays++;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void btnabsent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a student");
                return;
            }

            int index = dataGridView1.CurrentRow.Index;

            students[index].AbsentDays++;
            students[index].TotalDays++;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a student");
                return;
            }

            int index = dataGridView1.CurrentRow.Index;

            if (students[index].TotalDays == 0)
            {
                MessageBox.Show("No attendance record found");
                return;
            }

            double percentage =
                (double)students[index].PresentDays /
                students[index].TotalDays * 100;

            lblr.Text = "Attendance = " +
                        percentage.ToString("F2") + "%";
            if (percentage < 75)
            {
                MessageBox.Show("Warning! Attendance below 75%");
            }
        }

        private void lblr_Click(object sender, EventArgs e)
        {

        }
    }
}
