﻿using System;
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
        Database db = new Database();
        private string id;

        public Emotiq()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                TBvoornaam.Text = item.SubItems[1].Text;
                TBtussen.Text = item.SubItems[2].Text;
                TBachternaam.Text = item.SubItems[3].Text;
                TBtelefoon.Text = item.SubItems[4].Text;
            }
            else
            {
                BTNadd.Enabled = true;
                TBvoornaam.Text = string.Empty;
                TBtussen.Text = string.Empty;
                TBachternaam.Text = string.Empty;
                TBtelefoon.Text = string.Empty;
            }
        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
            if (emptyboxcheck())
            {
                string voornaam = TBvoornaam.Text;
                string tv = TBtussen.Text;
                string achternaam = TBachternaam.Text;
                string telefoon = TBtelefoon.Text;

                db.toevoegen(voornaam, tv, achternaam, telefoon);
                clear();
            }    
        }

        private void BTNremove_Click(object sender, EventArgs e)
        {
            db.verwijderen(id);
            BTNadd.Enabled = true;
            BTNremove.Enabled = false;
            clear();
        }

        private void clear() 
        {
            TBvoornaam.Text = "";
            TBtussen.Text = "";
            TBachternaam.Text = "";
            TBtelefoon.Text = "";

            Listemotietabel.Items.Clear();
            Listcontact.Items.Clear();
            BTNremove.Enabled = false;

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

        private bool emptyboxcheck()
        {
            if (String.IsNullOrEmpty(TBvoornaam.Text))
            {
                MessageBox.Show("Vul alle velden");
                return false;
            }
            else if (String.IsNullOrEmpty(TBachternaam.Text))
            {
                MessageBox.Show("Vul alle velden");
                return false;
            }
            else if (String.IsNullOrEmpty(TBtelefoon.Text))
            {
                MessageBox.Show("Vul alle velden");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
