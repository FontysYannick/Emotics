
namespace EmotiqApp
{
    partial class frmContacts
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
            this.Listcontact = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrefix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPhonenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBfirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBprefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBlastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBphonenumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNadd = new System.Windows.Forms.Button();
            this.BTNremove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listcontact
            // 
            this.Listcontact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Listcontact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listcontact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmFirstname,
            this.clmPrefix,
            this.clmLastname,
            this.clmPhonenumber});
            this.Listcontact.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Listcontact.ForeColor = System.Drawing.Color.White;
            this.Listcontact.FullRowSelect = true;
            this.Listcontact.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Listcontact.HideSelection = false;
            this.Listcontact.Location = new System.Drawing.Point(12, 12);
            this.Listcontact.Name = "Listcontact";
            this.Listcontact.Size = new System.Drawing.Size(476, 386);
            this.Listcontact.TabIndex = 2;
            this.Listcontact.UseCompatibleStateImageBehavior = false;
            this.Listcontact.View = System.Windows.Forms.View.Details;
            this.Listcontact.SelectedIndexChanged += new System.EventHandler(this.Listcontact_SelectedIndexChanged);
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 0;
            // 
            // clmFirstname
            // 
            this.clmFirstname.Text = "Firstname";
            this.clmFirstname.Width = 90;
            // 
            // clmPrefix
            // 
            this.clmPrefix.Text = "Prefix";
            // 
            // clmLastname
            // 
            this.clmLastname.Text = "Lastname";
            this.clmLastname.Width = 90;
            // 
            // clmPhonenumber
            // 
            this.clmPhonenumber.Text = "Phonenumber";
            this.clmPhonenumber.Width = 117;
            // 
            // TBfirstname
            // 
            this.TBfirstname.BackColor = System.Drawing.SystemColors.Window;
            this.TBfirstname.Location = new System.Drawing.Point(41, 49);
            this.TBfirstname.Name = "TBfirstname";
            this.TBfirstname.Size = new System.Drawing.Size(115, 22);
            this.TBfirstname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firstname*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prefix";
            // 
            // TBprefix
            // 
            this.TBprefix.Location = new System.Drawing.Point(41, 100);
            this.TBprefix.Name = "TBprefix";
            this.TBprefix.Size = new System.Drawing.Size(48, 22);
            this.TBprefix.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lastname*";
            // 
            // TBlastname
            // 
            this.TBlastname.Location = new System.Drawing.Point(41, 151);
            this.TBlastname.Name = "TBlastname";
            this.TBlastname.Size = new System.Drawing.Size(115, 22);
            this.TBlastname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(37, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phonenumber*";
            // 
            // TBphonenumber
            // 
            this.TBphonenumber.Location = new System.Drawing.Point(41, 202);
            this.TBphonenumber.Name = "TBphonenumber";
            this.TBphonenumber.Size = new System.Drawing.Size(115, 22);
            this.TBphonenumber.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BTNremove);
            this.panel1.Controls.Add(this.BTNadd);
            this.panel1.Controls.Add(this.TBlastname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBfirstname);
            this.panel1.Controls.Add(this.TBphonenumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBprefix);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 247);
            this.panel1.TabIndex = 11;
            // 
            // BTNadd
            // 
            this.BTNadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTNadd.FlatAppearance.BorderSize = 0;
            this.BTNadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNadd.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNadd.ForeColor = System.Drawing.Color.White;
            this.BTNadd.Location = new System.Drawing.Point(257, 86);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(117, 39);
            this.BTNadd.TabIndex = 11;
            this.BTNadd.Text = "Add";
            this.BTNadd.UseVisualStyleBackColor = false;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // BTNremove
            // 
            this.BTNremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTNremove.FlatAppearance.BorderSize = 0;
            this.BTNremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNremove.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNremove.ForeColor = System.Drawing.Color.White;
            this.BTNremove.Location = new System.Drawing.Point(257, 131);
            this.BTNremove.Name = "BTNremove";
            this.BTNremove.Size = new System.Drawing.Size(117, 39);
            this.BTNremove.TabIndex = 12;
            this.BTNremove.Text = "Remove";
            this.BTNremove.UseVisualStyleBackColor = false;
            this.BTNremove.Click += new System.EventHandler(this.BTNremove_Click);
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(500, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Listcontact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContacts";
            this.Text = "frmContacts";
            this.Load += new System.EventHandler(this.frmContacts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmFirstname;
        private System.Windows.Forms.ColumnHeader clmPrefix;
        private System.Windows.Forms.ColumnHeader clmLastname;
        private System.Windows.Forms.ColumnHeader clmPhonenumber;
        private System.Windows.Forms.TextBox TBfirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBprefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBlastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBphonenumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.Button BTNremove;
        private System.Windows.Forms.ListView Listcontact;
    }
}