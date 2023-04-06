using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Login
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "kingjock26" && txt_Password.Text == "boghpoan00")
            {
                // Login successful
                FormProgramming f = new FormProgramming();
                f.Show();
                this.Hide();
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password.");

            }
        }
    }
}
    

