using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public UserForm userForm = new UserForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            userForm.Show();

            this.Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string usuario = rjTextBox1.Texts;
            string contraseña = rjTextBox2.Texts;
            if (usuario == "admin" && contraseña == "admin")
            {
                userForm.Show();

                this.Hide();
            }
            else if (usuario == "" && contraseña == "")
            {
                MessageBox.Show("Porfavor, ingrese los datos.");
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserForm userFormClose = new UserForm();
            userFormClose.Close();
        }
    }
}
