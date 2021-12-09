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
    public partial class frmContacts : Form
    {
        DBselect dbselect = new DBselect();
        DBdelete dbdelete = new DBdelete();
        DBaddcontact dbadd = new DBaddcontact();
        private string id;

        public frmContacts()
        {
            InitializeComponent();
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            clear();
            dbselect.Select(DBselect.Tabel.contacts);
        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
            if (emptyboxcheck())
            {
                dbadd.Add(TBfirstname.Text, TBprefix.Text, TBlastname.Text, TBphonenumber.Text);
                clear();
            }
        }

        private void BTNremove_Click(object sender, EventArgs e)
        {
            dbdelete.Delete(id);
            BTNadd.Enabled = true;
            BTNremove.Enabled = false;
            clear();
        }

        private void Listcontact_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTNadd.Enabled = false;
            BTNremove.Enabled = true;
            if (Listcontact.SelectedItems.Count > 0)
            {
                ListViewItem item = Listcontact.SelectedItems[0];
                id = item.SubItems[0].Text;
                TBfirstname.Text = item.SubItems[1].Text;
                TBprefix.Text = item.SubItems[2].Text;
                TBlastname.Text = item.SubItems[3].Text;
                TBphonenumber.Text = item.SubItems[4].Text;
            }
            else
            {
                BTNadd.Enabled = true;
                BTNremove.Enabled = false;
                TBfirstname.Text = string.Empty;
                TBprefix.Text = string.Empty;
                TBlastname.Text = string.Empty;
                TBphonenumber.Text = string.Empty;
            }
        }

        private void clear()
        {
            TBfirstname.Text = "";
            TBprefix.Text = "";
            TBlastname.Text = "";
            TBphonenumber.Text = "";

            Listcontact.Items.Clear();
            BTNremove.Enabled = false;

            List<ListViewItem> contact = dbselect.Select(DBselect.Tabel.contacts);
            foreach (var item in contact)
            {
                Listcontact.Items.Add(item);
            }
        }

        private bool emptyboxcheck()
        {
            if (String.IsNullOrEmpty(TBfirstname.Text))
            {
                MessageBox.Show("Fill in all required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (String.IsNullOrEmpty(TBlastname.Text))
            {
                MessageBox.Show("Fill in all required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (String.IsNullOrEmpty(TBphonenumber.Text))
            {
                MessageBox.Show("Fill in all required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
