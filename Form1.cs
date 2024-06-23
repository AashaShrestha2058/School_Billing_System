using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace ScoolBillingSystem_DFA_
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LH59MDA;Initial Catalog=School;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //string query = "insert into Log(Username,Password)values(@username,@pass)";
                string retrive = "select * from Log WHERE Username='"+UserName.Text+"' AND Password = '"+Password.Text+"'";
               // SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd2 = new SqlCommand(retrive, conn);
               // cmd.Parameters.AddWithValue("@username", textBox1.Text);
                //cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                SqlDataReader read = cmd2.ExecuteReader();
                if (UserName.Text == "" || Password.Text=="")
                {
                    label4.Text= "Username or password is empty!";
                }
                else if (read.Read())
                    {
                    this.Hide();
                    DashBoard dobj = new DashBoard();
                    dobj.Show();                }
                else
                {
                   label4.Text = "Incorrect username or password!";
                }
                
                    //UserName.Text =read["Id"].ToString()+" "+read["Username"].ToString() + " "+ read["Password"].ToString();
                
               // cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(" "+ ex);

                this.Hide();
                DashBoard db = new DashBoard();
                db.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
}
