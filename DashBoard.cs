using ScoolBillingSystem_DFA_.Usercontrols;
using System;
using System.Windows.Forms;

namespace ScoolBillingSystem_DFA_
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            DashBoardUserControl du = new DashBoardUserControl();
            addUserControl(du);
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
;        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DashBoardUserControl du = new DashBoardUserControl();
            addUserControl(du);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FeeStructureUserControl Fu = new FeeStructureUserControl();
            addUserControl(Fu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateBillUserControl Gu = new GenerateBillUserControl();
            addUserControl(Gu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentsUserControl SU = new StudentsUserControl();
            addUserControl(SU);
        }
    }
}
