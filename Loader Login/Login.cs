using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader_Login
{
    public partial class Login : Form
    {
        static string name = "chetzss";
        static string ownerid = "jpAm716GCJ";
        static string secret = "d91bdb7502a4fceb637c79d658f6fc3c6f2f50fea75e6c0bf3659b639a174e5b";
        static string version = "1.0";

        public static api KeyAuthApp = new api(name, ownerid, secret, version);
        public Login()
        {
            KeyAuthApp.init();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Save Username & Password
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;

            // Auto Fill Key From TextBox - Add If Key.txt Exists
            if (File.Exists("Key.txt"))
            {
                string line = "";
                System.IO.StreamReader file = new System.IO.StreamReader(@"Key.txt");
                while (!file.EndOfStream)
                {
                    line += file.ReadLine() + "&";
                }
                string[] newLines = line.Split('&');
                txtKey.Text = newLines[0].ToString();
            }
            else
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (KeyAuthApp.login(txtUsername.Text, txtPassword.Text))
            if (KeyAuthApp.license(txtKey.Text))
                {
                    Properties.Settings.Default.Username = txtUsername.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                    //AutoFill Key
                    if (File.Exists("Key.txt"))
                    {

                    }
                    else
                    {
                        TextWriter tw = new StreamWriter(@"Key.txt");
                        tw.WriteLine(txtKey.Text);
                        tw.Close();
                    }
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
