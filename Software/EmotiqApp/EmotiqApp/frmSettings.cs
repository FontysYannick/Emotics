using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmotiqApp
{
    public partial class frmSettings : Form
    {
        
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void BTNsave_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            string Username = TBname.Text;
            frm1.LBuser.Text = "Welcome " + Username;
            frm1.Show();
        }
    }
}
