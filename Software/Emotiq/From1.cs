using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Emotiq
{
    public partial class Emotiq : Form
    {
        public Emotiq()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            List<ListViewItem> value = db.opvragen("emotietabel", 4);
            foreach (var item in value)
            {
                Listemotietabel.Items.Add(item);
            }

            List<ListViewItem> contact = db.opvragen("contactpersonen", 5);
            foreach (var item in contact)
            {
                Listcontact.Items.Add(item);
            }
        }

        private void Listcontact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listcontact.SelectedItems.Count > 0)
            {
                ListViewItem item = Listcontact.SelectedItems[0];
                TBvoornaam.Text = item.SubItems[1].Text;
                TBtussen.Text = item.SubItems[2].Text;
                TBachternaam.Text = item.SubItems[3].Text;
                TBtelefoon.Text = item.SubItems[4].Text;
            }
            else
            {
                TBvoornaam.Text = string.Empty;
                TBtussen.Text = string.Empty;
                TBachternaam.Text = string.Empty;
                TBachternaam.Text = string.Empty;
            }
        }
    }
}
