namespace treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode uni = treeView1.Nodes.Add("UNIVERSITY");
            TreeNode student = uni.Nodes.Add("Students");
            student.Nodes.Add("MIRHA");
            student.Nodes.Add("LAIBA");
            student.Nodes.Add("HAFSA");

            TreeNode teacher = uni.Nodes.Add("Teacher");
            teacher.Nodes.Add("T. sidra");
            teacher.Nodes.Add("S. ali");
            teacher.Nodes.Add("T. hira");
            teacher.Nodes.Add("S. Ayub");
            teacher.Nodes.Add("S. M.Ashraf");
            treeView1.ExpandAll();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
