using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioop_project
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void singUpButton_Click(object sender, EventArgs e)
        {

            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string email = emailBox.Text;
            if (int.TryParse(phoneBox.Text, out int phone))
            {
                return;
            }
            if(int.TryParse(idNumberBox.Text, out int id))
            {
                return;
            }
                   

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
