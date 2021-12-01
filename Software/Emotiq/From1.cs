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
            List<ListViewItem> items = db.opvragen(Database.Brandstof.benzine_auto);
            //List<ListViewItem> items = db.opvragen("contactgegevens", 4);

            foreach (var item in items)
            {
                listView1.Items.Add(item);
            }
        }
    }
}
