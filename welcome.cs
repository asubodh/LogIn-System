using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class welcome : Form
    {
        string accountuser;
        public welcome( string username )
        {
            accountuser = username;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtWelcome.Text = "Welcome" + accountuser + "";
        }
    }
}
