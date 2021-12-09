
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emotiq));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.LBquote = new System.Windows.Forms.Label();
            this.LBtip = new System.Windows.Forms.Label();
            this.LBemotion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.TabPage();
            this.Listemotietabel = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BPM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.O2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contact = new System.Windows.Forms.TabPage();
            this.BTNremove = new System.Windows.Forms.Button();
            this.BTNadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TBphonenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBlastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBprefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBfirstname = new System.Windows.Forms.TextBox();
            this.Listcontact = new System.Windows.Forms.ListView();
            this.CLMid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLMFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLMPrefix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLMLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLMPhonenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Settings = new System.Windows.Forms.TabPage();
            this.mySqlDataAdapter2 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlDataAdapter3 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.TabControl.SuspendLayout();
            this.Home.SuspendLayout();
            this.Graph.SuspendLayout();
            this.Contact.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.Home);
            this.TabControl.Controls.Add(this.Graph);
            this.TabControl.Controls.Add(this.Contact);
            this.TabControl.Controls.Add(this.Settings);
            this.TabControl.Location = new System.Drawing.Point(1, 1);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(581, 727);
            this.TabControl.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.Controls.Add(this.LBquote);
            this.Home.Controls.Add(this.LBtip);
            this.Home.Controls.Add(this.LBemotion);
            this.Home.Controls.Add(this.label7);
            this.Home.Controls.Add(this.label2);
            this.Home.Controls.Add(this.label1);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Size = new System.Drawing.Size(573, 698);
            this.Home.TabIndex = 0;
            this.Home.Text = "       Home       ";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // LBquote
            // 
            this.LBquote.AutoSize = true;
            this.LBquote.Location = new System.Drawing.Point(57, 507);
            this.LBquote.Name = "LBquote";
            this.LBquote.Size = new System.Drawing.Size(47, 17);
            this.LBquote.TabIndex = 8;
            this.LBquote.Text = "Quote";
            // 
            // LBtip
            // 
            this.LBtip.AutoSize = true;
            this.LBtip.Location = new System.Drawing.Point(57, 415);
            this.LBtip.Name = "LBtip";
            this.LBtip.Size = new System.Drawing.Size(28, 17);
            this.LBtip.TabIndex = 7;
            this.LBtip.Text = "Tip";
            // 
            // LBemotion
            // 
            this.LBemotion.AutoSize = true;
            this.LBemotion.Font = new System.Drawing.Font("Modern No. 20", 26F);
            this.LBemotion.Location = new System.Drawing.Point(260, 358);
            this.LBemotion.Name = "LBemotion";
            this.LBemotion.Size = new System.Drawing.Size(85, 45);
            this.LBemotion.TabIndex = 4;
            this.LBemotion.Text = "Sad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(44, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(480, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "Willy the wizard cast a spell you are now";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.label2.Location = new System.Drawing.Point(164, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "How are you today?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Goodday Matthijs";
            // 
            // Graph
            // 
            this.Graph.BackgroundImage = global::Emotiq.Properties.Resources.Background_emotie;
            this.Graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Graph.Controls.Add(this.Listemotietabel);
            this.Graph.Location = new System.Drawing.Point(4, 25);
            this.Graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Graph.Name = "Graph";
            this.Graph.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Graph.Size = new System.Drawing.Size(573, 698);
            this.Graph.TabIndex = 1;
            this.Graph.Text = "       Graph       ";
            this.Graph.UseVisualStyleBackColor = true;
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
            this.Listemotietabel.Location = new System.Drawing.Point(8, 5);
            this.Listemotietabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Listemotietabel.Name = "Listemotietabel";
            this.Listemotietabel.Size = new System.Drawing.Size(551, 381);
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
            // Contact
            // 
            this.Contact.BackgroundImage = global::Emotiq.Properties.Resources.Background_emotie;
            this.Contact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Contact.Controls.Add(this.BTNremove);
            this.Contact.Controls.Add(this.BTNadd);
            this.Contact.Controls.Add(this.label6);
            this.Contact.Controls.Add(this.TBphonenumber);
            this.Contact.Controls.Add(this.label5);
            this.Contact.Controls.Add(this.TBlastname);
            this.Contact.Controls.Add(this.label4);
            this.Contact.Controls.Add(this.TBprefix);
            this.Contact.Controls.Add(this.label3);
            this.Contact.Controls.Add(this.TBfirstname);
            this.Contact.Controls.Add(this.Listcontact);
            this.Contact.Location = new System.Drawing.Point(4, 25);
            this.Contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contact.Name = "Contact";
            this.Contact.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contact.Size = new System.Drawing.Size(573, 698);
            this.Contact.TabIndex = 3;
            this.Contact.Text = "       Contact       ";
            this.Contact.UseVisualStyleBackColor = true;
            // 
            // BTNremove
            // 
            this.BTNremove.BackColor = System.Drawing.Color.Transparent;
            this.BTNremove.Location = new System.Drawing.Point(323, 549);
            this.BTNremove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNremove.Name = "BTNremove";
            this.BTNremove.Size = new System.Drawing.Size(128, 59);
            this.BTNremove.TabIndex = 11;
            this.BTNremove.Text = "Remove";
            this.BTNremove.UseVisualStyleBackColor = false;
            this.BTNremove.Click += new System.EventHandler(this.BTNremove_Click);
            // 
            // BTNadd
            // 
            this.BTNadd.Location = new System.Drawing.Point(323, 485);
            this.BTNadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(128, 59);
            this.BTNadd.TabIndex = 9;
            this.BTNadd.Text = "Add";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phonenumber";
            // 
            // TBphonenumber
            // 
            this.TBphonenumber.Location = new System.Drawing.Point(128, 614);
            this.TBphonenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBphonenumber.Name = "TBphonenumber";
            this.TBphonenumber.Size = new System.Drawing.Size(151, 22);
            this.TBphonenumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lastname";
            // 
            // TBlastname
            // 
            this.TBlastname.Location = new System.Drawing.Point(128, 567);
            this.TBlastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBlastname.Name = "TBlastname";
            this.TBlastname.Size = new System.Drawing.Size(151, 22);
            this.TBlastname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prefix";
            // 
            // TBprefix
            // 
            this.TBprefix.Location = new System.Drawing.Point(125, 517);
            this.TBprefix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBprefix.Name = "TBprefix";
            this.TBprefix.Size = new System.Drawing.Size(153, 22);
            this.TBprefix.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firstname";
            // 
            // TBfirstname
            // 
            this.TBfirstname.Location = new System.Drawing.Point(128, 465);
            this.TBfirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBfirstname.Name = "TBfirstname";
            this.TBfirstname.Size = new System.Drawing.Size(151, 22);
            this.TBfirstname.TabIndex = 1;
            // 
            // Listcontact
            // 
            this.Listcontact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listcontact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CLMid,
            this.CLMFirstname,
            this.CLMPrefix,
            this.CLMLastname,
            this.CLMPhonenumber});
            this.Listcontact.HideSelection = false;
            this.Listcontact.Location = new System.Drawing.Point(8, 5);
            this.Listcontact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Listcontact.Name = "Listcontact";
            this.Listcontact.Size = new System.Drawing.Size(551, 374);
            this.Listcontact.TabIndex = 0;
            this.Listcontact.UseCompatibleStateImageBehavior = false;
            this.Listcontact.View = System.Windows.Forms.View.Details;
            this.Listcontact.SelectedIndexChanged += new System.EventHandler(this.Listcontact_SelectedIndexChanged);
            // 
            // CLMid
            // 
            this.CLMid.Text = "ID";
            this.CLMid.Width = 40;
            // 
            // CLMFirstname
            // 
            this.CLMFirstname.Text = "Firstname";
            this.CLMFirstname.Width = 100;
            // 
            // CLMPrefix
            // 
            this.CLMPrefix.Text = "Prefix";
            // 
            // CLMLastname
            // 
            this.CLMLastname.Text = "Lastname";
            this.CLMLastname.Width = 100;
            // 
            // CLMPhonenumber
            // 
            this.CLMPhonenumber.Text = "Phonenumber";
            this.CLMPhonenumber.Width = 120;
            // 
            // Settings
            // 
            this.Settings.BackgroundImage = global::Emotiq.Properties.Resources.Background_emotie;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Location = new System.Drawing.Point(4, 25);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Settings.Size = new System.Drawing.Size(573, 698);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "       Settings       ";
            this.Settings.UseVisualStyleBackColor = true;
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
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(581, 734);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Emotiq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.Graph.ResumeLayout(false);
            this.Contact.ResumeLayout(false);
            this.Contact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Graph;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter3;
        private System.Windows.Forms.ListView Listemotietabel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader BPM;
        private System.Windows.Forms.ColumnHeader Temp;
        private System.Windows.Forms.ColumnHeader O2;
        private System.Windows.Forms.TabPage Contact;
        private System.Windows.Forms.ListView Listcontact;
        private System.Windows.Forms.ColumnHeader CLMFirstname;
        private System.Windows.Forms.ColumnHeader CLMPrefix;
        private System.Windows.Forms.ColumnHeader CLMLastname;
        private System.Windows.Forms.ColumnHeader CLMPhonenumber;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBfirstname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBphonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBlastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBprefix;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.Button BTNremove;
        private System.Windows.Forms.ColumnHeader CLMid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBemotion;
        private System.Windows.Forms.Label LBquote;
        private System.Windows.Forms.Label LBtip;
    }
}

