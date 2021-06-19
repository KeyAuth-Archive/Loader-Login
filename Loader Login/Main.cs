using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader_Login
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            expiry.Text = "Expiry: " + Login.KeyAuthApp.user_data.expiry;
            lastLogin.Text = "Last Login: " + DateTime.Now;
            lblRank.Text = "Your Rank: " + Login.KeyAuthApp.user_data.level;

        }
    }
}
