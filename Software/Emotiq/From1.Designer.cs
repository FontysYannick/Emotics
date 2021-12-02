
namespace Emotiq
{
    partial class Emotiq
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Overzicht = new System.Windows.Forms.TabPage();
            this.Listemotietabel = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BPM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.O2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactPersonen = new System.Windows.Forms.TabPage();
            this.BTNremove = new System.Windows.Forms.Button();
            this.BTNupdate = new System.Windows.Forms.Button();
            this.BTNadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TBtelefoon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBachternaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBtussen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBvoornaam = new System.Windows.Forms.TextBox();
            this.Listcontact = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Instellingen = new System.Windows.Forms.TabPage();
            this.mySqlDataAdapter2 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlDataAdapter3 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.TabControl.SuspendLayout();
            this.Home.SuspendLayout();
            this.Overzicht.SuspendLayout();
            this.ContactPersonen.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.Home);
            this.TabControl.Controls.Add(this.Overzicht);
            this.TabControl.Controls.Add(this.ContactPersonen);
            this.TabControl.Controls.Add(this.Instellingen);
            this.TabControl.Location = new System.Drawing.Point(1, 1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(541, 750);
            this.TabControl.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::Emotiq.Properties.Resources.Background_emotie;
            this.Home.Controls.Add(this.label2);
            this.Home.Controls.Add(this.label1);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(533, 721);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoe voelt u zich ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Goedemiddag Matthijs";
            // 
            // Overzicht
            // 
            this.Overzicht.Controls.Add(this.Listemotietabel);
            this.Overzicht.Location = new System.Drawing.Point(4, 25);
            this.Overzicht.Name = "Overzicht";
            this.Overzicht.Padding = new System.Windows.Forms.Padding(3);
            this.Overzicht.Size = new System.Drawing.Size(533, 721);
            this.Overzicht.TabIndex = 1;
            this.Overzicht.Text = "Overzicht";
            this.Overzicht.UseVisualStyleBackColor = true;
            // 
            // Listemotietabel
            // 
            this.Listemotietabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listemotietabel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.BPM,
            this.Temp,
            this.O2});
            this.Listemotietabel.HideSelection = false;
            this.Listemotietabel.Location = new System.Drawing.Point(0, 0);
            this.Listemotietabel.Name = "Listemotietabel";
            this.Listemotietabel.Size = new System.Drawing.Size(533, 295);
            this.Listemotietabel.TabIndex = 2;
            this.Listemotietabel.UseCompatibleStateImageBehavior = false;
            this.Listemotietabel.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // BPM
            // 
            this.BPM.Text = "BPM";
            // 
            // Temp
            // 
            this.Temp.Text = "Temp";
            // 
            // O2
            // 
            this.O2.Text = "O2";
            // 
            // ContactPersonen
            // 
            this.ContactPersonen.Controls.Add(this.BTNremove);
            this.ContactPersonen.Controls.Add(this.BTNupdate);
            this.ContactPersonen.Controls.Add(this.BTNadd);
            this.ContactPersonen.Controls.Add(this.label6);
            this.ContactPersonen.Controls.Add(this.TBtelefoon);
            this.ContactPersonen.Controls.Add(this.label5);
            this.ContactPersonen.Controls.Add(this.TBachternaam);
            this.ContactPersonen.Controls.Add(this.label4);
            this.ContactPersonen.Controls.Add(this.TBtussen);
            this.ContactPersonen.Controls.Add(this.label3);
            this.ContactPersonen.Controls.Add(this.TBvoornaam);
            this.ContactPersonen.Controls.Add(this.Listcontact);
            this.ContactPersonen.Location = new System.Drawing.Point(4, 25);
            this.ContactPersonen.Name = "ContactPersonen";
            this.ContactPersonen.Padding = new System.Windows.Forms.Padding(3);
            this.ContactPersonen.Size = new System.Drawing.Size(533, 721);
            this.ContactPersonen.TabIndex = 3;
            this.ContactPersonen.Text = "ContactPersonen";
            this.ContactPersonen.UseVisualStyleBackColor = true;
            // 
            // BTNremove
            // 
            this.BTNremove.Location = new System.Drawing.Point(388, 469);
            this.BTNremove.Name = "BTNremove";
            this.BTNremove.Size = new System.Drawing.Size(85, 31);
            this.BTNremove.TabIndex = 11;
            this.BTNremove.Text = "Remove";
            this.BTNremove.UseVisualStyleBackColor = true;
            this.BTNremove.Click += new System.EventHandler(this.BTNremove_Click);
            // 
            // BTNupdate
            // 
            this.BTNupdate.Location = new System.Drawing.Point(297, 469);
            this.BTNupdate.Name = "BTNupdate";
            this.BTNupdate.Size = new System.Drawing.Size(85, 31);
            this.BTNupdate.TabIndex = 10;
            this.BTNupdate.Text = "Update";
            this.BTNupdate.UseVisualStyleBackColor = true;
            // 
            // BTNadd
            // 
            this.BTNadd.Location = new System.Drawing.Point(206, 469);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(85, 31);
            this.BTNadd.TabIndex = 9;
            this.BTNadd.Text = "Add";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefoonummer";
            // 
            // TBtelefoon
            // 
            this.TBtelefoon.Location = new System.Drawing.Point(37, 473);
            this.TBtelefoon.Name = "TBtelefoon";
            this.TBtelefoon.Size = new System.Drawing.Size(140, 22);
            this.TBtelefoon.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Achternaam";
            // 
            // TBachternaam
            // 
            this.TBachternaam.Location = new System.Drawing.Point(341, 411);
            this.TBachternaam.Name = "TBachternaam";
            this.TBachternaam.Size = new System.Drawing.Size(140, 22);
            this.TBachternaam.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tussenvoegsel";
            // 
            // TBtussen
            // 
            this.TBtussen.Location = new System.Drawing.Point(206, 411);
            this.TBtussen.Name = "TBtussen";
            this.TBtussen.Size = new System.Drawing.Size(60, 22);
            this.TBtussen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voornaam";
            // 
            // TBvoornaam
            // 
            this.TBvoornaam.Location = new System.Drawing.Point(37, 411);
            this.TBvoornaam.Name = "TBvoornaam";
            this.TBvoornaam.Size = new System.Drawing.Size(140, 22);
            this.TBvoornaam.TabIndex = 1;
            // 
            // Listcontact
            // 
            this.Listcontact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Listcontact.HideSelection = false;
            this.Listcontact.Location = new System.Drawing.Point(0, 0);
            this.Listcontact.Name = "Listcontact";
            this.Listcontact.Size = new System.Drawing.Size(533, 372);
            this.Listcontact.TabIndex = 0;
            this.Listcontact.UseCompatibleStateImageBehavior = false;
            this.Listcontact.View = System.Windows.Forms.View.Details;
            this.Listcontact.SelectedIndexChanged += new System.EventHandler(this.Listcontact_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Voornaam";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tussenvoegsel";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Achternaam";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefoonnummer";
            this.columnHeader5.Width = 117;
            // 
            // Instellingen
            // 
            this.Instellingen.Location = new System.Drawing.Point(4, 25);
            this.Instellingen.Name = "Instellingen";
            this.Instellingen.Padding = new System.Windows.Forms.Padding(3);
            this.Instellingen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Instellingen.Size = new System.Drawing.Size(533, 721);
            this.Instellingen.TabIndex = 2;
            this.Instellingen.Text = "Instellingen";
            this.Instellingen.UseVisualStyleBackColor = true;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // mySqlDataAdapter3
            // 
            this.mySqlDataAdapter3.DeleteCommand = null;
            this.mySqlDataAdapter3.InsertCommand = null;
            this.mySqlDataAdapter3.SelectCommand = null;
            this.mySqlDataAdapter3.UpdateCommand = null;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Emotiq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 753);
            this.Controls.Add(this.TabControl);
            this.Name = "Emotiq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.Overzicht.ResumeLayout(false);
            this.ContactPersonen.ResumeLayout(false);
            this.ContactPersonen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Overzicht;
        private System.Windows.Forms.TabPage Instellingen;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter3;
        private System.Windows.Forms.ListView Listemotietabel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader BPM;
        private System.Windows.Forms.ColumnHeader Temp;
        private System.Windows.Forms.ColumnHeader O2;
        private System.Windows.Forms.TabPage ContactPersonen;
        private System.Windows.Forms.ListView Listcontact;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBvoornaam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBtelefoon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBachternaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBtussen;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.Button BTNremove;
        private System.Windows.Forms.Button BTNupdate;
    }
}

