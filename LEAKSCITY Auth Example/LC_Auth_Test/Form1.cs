using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LEAKSCITY_Auth;

namespace LC_Auth_Test
{
    public partial class Form1 : Form
    {
        private readonly Auth _login = new Auth();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var authkey = textBox1.Text;

            Helpers.authModel = _login.Login(authkey);

            if(!Helpers.authModel.AuthStatus)
            {
                MessageBox.Show("Wystąpił błąd poczas logowania");
                return;
            }

            MessageBox.Show("Zalogowano");
        }
    }
}
