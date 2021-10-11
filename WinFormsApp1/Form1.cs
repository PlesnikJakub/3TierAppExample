using BussinesLayer.DomainModel;
using BussinesLayer.TableModule;
using BussinesLayer.TransactionScript;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loginDetectionLabel.Text = "NO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = new Login();
            var authenticated = login.Execute(textBox1.Text, textBox2.Text);

            if (authenticated)
            {
                loginDetectionLabel.Text = "YES";
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var logout = new Logout().Execute();

            if(logout)
            {
                loginDetectionLabel.Text = "NO";
            }
        }
    }
}
