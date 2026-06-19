using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace SYS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn1.Enabled = false;
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            btn1.Enabled = !string.IsNullOrEmpty(tb1.Text);
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show(

                "Are you sure you want to submit you information?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes) {
                MessageBox.Show(
                    "Student information submit successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                    );
            }
            else
            {
                MessageBox.Show(
                    "Submittion cancelled.",
                    "Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                    );
            }


        }
    }
}