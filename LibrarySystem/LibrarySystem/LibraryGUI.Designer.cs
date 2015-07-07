namespace WindowsFormsApplication1
{
    partial class LibraryGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryGUI));
            this.tabsystem = new System.Windows.Forms.TabControl();
            this.Circulation = new System.Windows.Forms.TabPage();
            this.Checkinlabel = new System.Windows.Forms.Label();
            this.checkinbox = new System.Windows.Forms.TextBox();
            this.checkoutbutton = new System.Windows.Forms.Button();
            this.checkinbutton = new System.Windows.Forms.Button();
            this.Checkoutlabel = new System.Windows.Forms.Label();
            this.checkoutbox = new System.Windows.Forms.MaskedTextBox();
            this.addbooktextbox1 = new System.Windows.Forms.TextBox();
            this.Addbooklabel = new System.Windows.Forms.Label();
            this.removebookbox = new System.Windows.Forms.TextBox();
            this.RemoveBooklabel = new System.Windows.Forms.Label();
            this.removebookbutton = new System.Windows.Forms.Button();
            this.addbookbutton = new System.Windows.Forms.Button();
            this.Patron = new System.Windows.Forms.TabPage();
            this.patrontabs = new System.Windows.Forms.TabControl();
            this.addpatrontab = new System.Windows.Forms.TabPage();
            this.zipbox = new System.Windows.Forms.TextBox();
            this.statebox = new System.Windows.Forms.TextBox();
            this.citybox = new System.Windows.Forms.TextBox();
            this.patronadd = new System.Windows.Forms.Button();
            this.ziplabel = new System.Windows.Forms.Label();
            this.statelabel = new System.Windows.Forms.Label();
            this.citylabel = new System.Windows.Forms.Label();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.addresslabel = new System.Windows.Forms.Label();
            this.studentidbox = new System.Windows.Forms.TextBox();
            this.firstnamebox = new System.Windows.Forms.TextBox();
            this.lastnamebox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.namelabel1 = new System.Windows.Forms.Label();
            this.userinfolabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.removepatronbutton = new System.Windows.Forms.Button();
            this.RemovePatronBox = new System.Windows.Forms.TextBox();
            this.removePatronlabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.patroneditlabel = new System.Windows.Forms.Label();
            this.editaddresslabel = new System.Windows.Forms.Label();
            this.editidlabel = new System.Windows.Forms.Label();
            this.editnamelabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchbookbutton = new System.Windows.Forms.RadioButton();
            this.searchpatronbutton = new System.Windows.Forms.RadioButton();
            this.searchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabsystem.SuspendLayout();
            this.Circulation.SuspendLayout();
            this.Patron.SuspendLayout();
            this.patrontabs.SuspendLayout();
            this.addpatrontab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsystem
            // 
            this.tabsystem.Controls.Add(this.Circulation);
            this.tabsystem.Controls.Add(this.Patron);
            this.tabsystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsystem.Location = new System.Drawing.Point(3, 143);
            this.tabsystem.Margin = new System.Windows.Forms.Padding(2);
            this.tabsystem.Name = "tabsystem";
            this.tabsystem.SelectedIndex = 0;
            this.tabsystem.Size = new System.Drawing.Size(545, 333);
            this.tabsystem.TabIndex = 0;
            // 
            // Circulation
            // 
            this.Circulation.BackColor = System.Drawing.Color.Gold;
            this.Circulation.Controls.Add(this.Checkinlabel);
            this.Circulation.Controls.Add(this.checkinbox);
            this.Circulation.Controls.Add(this.checkoutbutton);
            this.Circulation.Controls.Add(this.checkinbutton);
            this.Circulation.Controls.Add(this.Checkoutlabel);
            this.Circulation.Controls.Add(this.checkoutbox);
            this.Circulation.Controls.Add(this.addbooktextbox1);
            this.Circulation.Controls.Add(this.Addbooklabel);
            this.Circulation.Controls.Add(this.removebookbox);
            this.Circulation.Controls.Add(this.RemoveBooklabel);
            this.Circulation.Controls.Add(this.removebookbutton);
            this.Circulation.Controls.Add(this.addbookbutton);
            this.Circulation.Location = new System.Drawing.Point(4, 26);
            this.Circulation.Margin = new System.Windows.Forms.Padding(2);
            this.Circulation.Name = "Circulation";
            this.Circulation.Padding = new System.Windows.Forms.Padding(2);
            this.Circulation.Size = new System.Drawing.Size(537, 303);
            this.Circulation.TabIndex = 0;
            this.Circulation.Text = "Circulation";
            this.Circulation.Click += new System.EventHandler(this.Circulation_Click);
            // 
            // Checkinlabel
            // 
            this.Checkinlabel.AutoSize = true;
            this.Checkinlabel.Location = new System.Drawing.Point(6, 202);
            this.Checkinlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Checkinlabel.Name = "Checkinlabel";
            this.Checkinlabel.Size = new System.Drawing.Size(125, 17);
            this.Checkinlabel.TabIndex = 12;
            this.Checkinlabel.Text = "Enter Patron ID:";
            // 
            // checkinbox
            // 
            this.checkinbox.Location = new System.Drawing.Point(230, 199);
            this.checkinbox.Margin = new System.Windows.Forms.Padding(2);
            this.checkinbox.Name = "checkinbox";
            this.checkinbox.Size = new System.Drawing.Size(174, 23);
            this.checkinbox.TabIndex = 11;
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.Location = new System.Drawing.Point(408, 135);
            this.checkoutbutton.Margin = new System.Windows.Forms.Padding(2);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Size = new System.Drawing.Size(82, 50);
            this.checkoutbutton.TabIndex = 10;
            this.checkoutbutton.Text = "Check Out";
            this.checkoutbutton.UseVisualStyleBackColor = true;
            // 
            // checkinbutton
            // 
            this.checkinbutton.Location = new System.Drawing.Point(408, 190);
            this.checkinbutton.Margin = new System.Windows.Forms.Padding(2);
            this.checkinbutton.Name = "checkinbutton";
            this.checkinbutton.Size = new System.Drawing.Size(82, 41);
            this.checkinbutton.TabIndex = 9;
            this.checkinbutton.Text = "Check In";
            this.checkinbutton.UseVisualStyleBackColor = true;
            this.checkinbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // Checkoutlabel
            // 
            this.Checkoutlabel.AutoSize = true;
            this.Checkoutlabel.Location = new System.Drawing.Point(6, 150);
            this.Checkoutlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Checkoutlabel.Name = "Checkoutlabel";
            this.Checkoutlabel.Size = new System.Drawing.Size(218, 17);
            this.Checkoutlabel.TabIndex = 7;
            this.Checkoutlabel.Text = "Enter Book ID and Patron ID:";
            // 
            // checkoutbox
            // 
            this.checkoutbox.Location = new System.Drawing.Point(230, 150);
            this.checkoutbox.Margin = new System.Windows.Forms.Padding(2);
            this.checkoutbox.Name = "checkoutbox";
            this.checkoutbox.Size = new System.Drawing.Size(174, 23);
            this.checkoutbox.TabIndex = 6;
            this.checkoutbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // addbooktextbox1
            // 
            this.addbooktextbox1.Location = new System.Drawing.Point(230, 27);
            this.addbooktextbox1.Margin = new System.Windows.Forms.Padding(2);
            this.addbooktextbox1.Name = "addbooktextbox1";
            this.addbooktextbox1.Size = new System.Drawing.Size(174, 23);
            this.addbooktextbox1.TabIndex = 5;
            // 
            // Addbooklabel
            // 
            this.Addbooklabel.AutoSize = true;
            this.Addbooklabel.Location = new System.Drawing.Point(6, 34);
            this.Addbooklabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addbooklabel.Name = "Addbooklabel";
            this.Addbooklabel.Size = new System.Drawing.Size(218, 17);
            this.Addbooklabel.TabIndex = 4;
            this.Addbooklabel.Text = "Enter Book Id, ISBN, or Title:";
            // 
            // removebookbox
            // 
            this.removebookbox.Location = new System.Drawing.Point(231, 75);
            this.removebookbox.Margin = new System.Windows.Forms.Padding(2);
            this.removebookbox.Name = "removebookbox";
            this.removebookbox.Size = new System.Drawing.Size(174, 23);
            this.removebookbox.TabIndex = 3;
            this.removebookbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RemoveBooklabel
            // 
            this.RemoveBooklabel.AutoSize = true;
            this.RemoveBooklabel.Location = new System.Drawing.Point(5, 77);
            this.RemoveBooklabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemoveBooklabel.Name = "RemoveBooklabel";
            this.RemoveBooklabel.Size = new System.Drawing.Size(218, 17);
            this.RemoveBooklabel.TabIndex = 2;
            this.RemoveBooklabel.Text = "Enter Book Id, ISBN, or Title:";
            this.RemoveBooklabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // removebookbutton
            // 
            this.removebookbutton.Location = new System.Drawing.Point(408, 64);
            this.removebookbutton.Margin = new System.Windows.Forms.Padding(2);
            this.removebookbutton.Name = "removebookbutton";
            this.removebookbutton.Size = new System.Drawing.Size(82, 64);
            this.removebookbutton.TabIndex = 1;
            this.removebookbutton.Text = "Remove Book";
            this.removebookbutton.UseVisualStyleBackColor = true;
            this.removebookbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addbookbutton
            // 
            this.addbookbutton.Location = new System.Drawing.Point(408, 16);
            this.addbookbutton.Margin = new System.Windows.Forms.Padding(2);
            this.addbookbutton.Name = "addbookbutton";
            this.addbookbutton.Size = new System.Drawing.Size(82, 43);
            this.addbookbutton.TabIndex = 0;
            this.addbookbutton.Text = "Add Book";
            this.addbookbutton.UseVisualStyleBackColor = true;
            this.addbookbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Patron
            // 
            this.Patron.BackColor = System.Drawing.Color.Yellow;
            this.Patron.Controls.Add(this.patrontabs);
            this.Patron.Controls.Add(this.splitter1);
            this.Patron.Location = new System.Drawing.Point(4, 26);
            this.Patron.Margin = new System.Windows.Forms.Padding(2);
            this.Patron.Name = "Patron";
            this.Patron.Padding = new System.Windows.Forms.Padding(2);
            this.Patron.Size = new System.Drawing.Size(537, 303);
            this.Patron.TabIndex = 1;
            this.Patron.Text = "Patron";
            // 
            // patrontabs
            // 
            this.patrontabs.Controls.Add(this.addpatrontab);
            this.patrontabs.Controls.Add(this.tabPage2);
            this.patrontabs.Location = new System.Drawing.Point(0, 2);
            this.patrontabs.Margin = new System.Windows.Forms.Padding(2);
            this.patrontabs.Name = "patrontabs";
            this.patrontabs.SelectedIndex = 0;
            this.patrontabs.Size = new System.Drawing.Size(542, 307);
            this.patrontabs.TabIndex = 2;
            // 
            // addpatrontab
            // 
            this.addpatrontab.Controls.Add(this.zipbox);
            this.addpatrontab.Controls.Add(this.statebox);
            this.addpatrontab.Controls.Add(this.citybox);
            this.addpatrontab.Controls.Add(this.patronadd);
            this.addpatrontab.Controls.Add(this.ziplabel);
            this.addpatrontab.Controls.Add(this.statelabel);
            this.addpatrontab.Controls.Add(this.citylabel);
            this.addpatrontab.Controls.Add(this.firstnamelabel);
            this.addpatrontab.Controls.Add(this.lastnamelabel);
            this.addpatrontab.Controls.Add(this.addressbox);
            this.addpatrontab.Controls.Add(this.addresslabel);
            this.addpatrontab.Controls.Add(this.studentidbox);
            this.addpatrontab.Controls.Add(this.firstnamebox);
            this.addpatrontab.Controls.Add(this.lastnamebox);
            this.addpatrontab.Controls.Add(this.label8);
            this.addpatrontab.Controls.Add(this.IDlabel);
            this.addpatrontab.Controls.Add(this.namelabel1);
            this.addpatrontab.Controls.Add(this.userinfolabel);
            this.addpatrontab.ForeColor = System.Drawing.Color.Yellow;
            this.addpatrontab.Location = new System.Drawing.Point(4, 26);
            this.addpatrontab.Margin = new System.Windows.Forms.Padding(2);
            this.addpatrontab.Name = "addpatrontab";
            this.addpatrontab.Padding = new System.Windows.Forms.Padding(2);
            this.addpatrontab.Size = new System.Drawing.Size(534, 277);
            this.addpatrontab.TabIndex = 0;
            this.addpatrontab.Text = "Add Patron ";
            this.addpatrontab.UseVisualStyleBackColor = true;
            // 
            // zipbox
            // 
            this.zipbox.Location = new System.Drawing.Point(282, 192);
            this.zipbox.Margin = new System.Windows.Forms.Padding(2);
            this.zipbox.Name = "zipbox";
            this.zipbox.Size = new System.Drawing.Size(121, 23);
            this.zipbox.TabIndex = 17;
            // 
            // statebox
            // 
            this.statebox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.statebox.Location = new System.Drawing.Point(397, 153);
            this.statebox.Margin = new System.Windows.Forms.Padding(2);
            this.statebox.Name = "statebox";
            this.statebox.Size = new System.Drawing.Size(73, 23);
            this.statebox.TabIndex = 16;
            this.statebox.TextChanged += new System.EventHandler(this.statebox_TextChanged);
            // 
            // citybox
            // 
            this.citybox.Location = new System.Drawing.Point(282, 153);
            this.citybox.Margin = new System.Windows.Forms.Padding(2);
            this.citybox.Name = "citybox";
            this.citybox.Size = new System.Drawing.Size(58, 23);
            this.citybox.TabIndex = 15;
            // 
            // patronadd
            // 
            this.patronadd.ForeColor = System.Drawing.Color.Black;
            this.patronadd.Location = new System.Drawing.Point(38, 235);
            this.patronadd.Margin = new System.Windows.Forms.Padding(2);
            this.patronadd.Name = "patronadd";
            this.patronadd.Size = new System.Drawing.Size(322, 40);
            this.patronadd.TabIndex = 14;
            this.patronadd.Text = "Add Patron";
            this.patronadd.UseVisualStyleBackColor = true;
            // 
            // ziplabel
            // 
            this.ziplabel.AutoSize = true;
            this.ziplabel.ForeColor = System.Drawing.Color.Black;
            this.ziplabel.Location = new System.Drawing.Point(32, 192);
            this.ziplabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ziplabel.Name = "ziplabel";
            this.ziplabel.Size = new System.Drawing.Size(254, 17);
            this.ziplabel.TabIndex = 13;
            this.ziplabel.Text = "Phone No: (No dashes or spaces)";
            // 
            // statelabel
            // 
            this.statelabel.AutoSize = true;
            this.statelabel.ForeColor = System.Drawing.Color.Black;
            this.statelabel.Location = new System.Drawing.Point(352, 155);
            this.statelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(51, 17);
            this.statelabel.TabIndex = 12;
            this.statelabel.Text = "State:";
            this.statelabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.ForeColor = System.Drawing.Color.Black;
            this.citylabel.Location = new System.Drawing.Point(241, 153);
            this.citylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(40, 17);
            this.citylabel.TabIndex = 11;
            this.citylabel.Text = "City:";
            this.citylabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstnamelabel.Location = new System.Drawing.Point(212, 41);
            this.firstnamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(40, 17);
            this.firstnamelabel.TabIndex = 10;
            this.firstnamelabel.Text = "First";
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.ForeColor = System.Drawing.Color.Black;
            this.lastnamelabel.Location = new System.Drawing.Point(116, 44);
            this.lastnamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(44, 17);
            this.lastnamelabel.TabIndex = 9;
            this.lastnamelabel.Text = "Last ";
            this.lastnamelabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(118, 147);
            this.addressbox.Margin = new System.Windows.Forms.Padding(2);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(120, 23);
            this.addressbox.TabIndex = 8;
            this.addressbox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addresslabel.Location = new System.Drawing.Point(32, 151);
            this.addresslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(72, 17);
            this.addresslabel.TabIndex = 7;
            this.addresslabel.Text = "Address:";
            this.addresslabel.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // studentidbox
            // 
            this.studentidbox.Location = new System.Drawing.Point(118, 104);
            this.studentidbox.Margin = new System.Windows.Forms.Padding(2);
            this.studentidbox.Name = "studentidbox";
            this.studentidbox.Size = new System.Drawing.Size(76, 23);
            this.studentidbox.TabIndex = 6;
            this.studentidbox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // firstnamebox
            // 
            this.firstnamebox.Location = new System.Drawing.Point(215, 63);
            this.firstnamebox.Margin = new System.Windows.Forms.Padding(2);
            this.firstnamebox.Name = "firstnamebox";
            this.firstnamebox.Size = new System.Drawing.Size(76, 23);
            this.firstnamebox.TabIndex = 5;
            // 
            // lastnamebox
            // 
            this.lastnamebox.Location = new System.Drawing.Point(118, 63);
            this.lastnamebox.Margin = new System.Windows.Forms.Padding(2);
            this.lastnamebox.Name = "lastnamebox";
            this.lastnamebox.Size = new System.Drawing.Size(76, 23);
            this.lastnamebox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(32, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 3;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.ForeColor = System.Drawing.Color.Black;
            this.IDlabel.Location = new System.Drawing.Point(32, 104);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(52, 17);
            this.IDlabel.TabIndex = 2;
            this.IDlabel.Text = "Email:";
            this.IDlabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // namelabel1
            // 
            this.namelabel1.AutoSize = true;
            this.namelabel1.ForeColor = System.Drawing.Color.Black;
            this.namelabel1.Location = new System.Drawing.Point(32, 63);
            this.namelabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namelabel1.Name = "namelabel1";
            this.namelabel1.Size = new System.Drawing.Size(54, 17);
            this.namelabel1.TabIndex = 1;
            this.namelabel1.Text = "Name:";
            this.namelabel1.Click += new System.EventHandler(this.label6_Click);
            // 
            // userinfolabel
            // 
            this.userinfolabel.AutoSize = true;
            this.userinfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userinfolabel.ForeColor = System.Drawing.Color.Black;
            this.userinfolabel.Location = new System.Drawing.Point(115, 11);
            this.userinfolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userinfolabel.Name = "userinfolabel";
            this.userinfolabel.Size = new System.Drawing.Size(317, 17);
            this.userinfolabel.TabIndex = 0;
            this.userinfolabel.Text = "New User Information (All Boxes Required)";
            this.userinfolabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(534, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remove/Edit Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleName = "removepatronTab";
            this.splitContainer1.Panel1.Controls.Add(this.removepatronbutton);
            this.splitContainer1.Panel1.Controls.Add(this.RemovePatronBox);
            this.splitContainer1.Panel1.Controls.Add(this.removePatronlabel);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleName = "editInfo";
            this.splitContainer1.Panel2.Controls.Add(this.textBox7);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox6);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox5);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.patroneditlabel);
            this.splitContainer1.Panel2.Controls.Add(this.editaddresslabel);
            this.splitContainer1.Panel2.Controls.Add(this.editidlabel);
            this.splitContainer1.Panel2.Controls.Add(this.editnamelabel);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(530, 273);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // removepatronbutton
            // 
            this.removepatronbutton.Location = new System.Drawing.Point(16, 91);
            this.removepatronbutton.Margin = new System.Windows.Forms.Padding(2);
            this.removepatronbutton.Name = "removepatronbutton";
            this.removepatronbutton.Size = new System.Drawing.Size(80, 42);
            this.removepatronbutton.TabIndex = 2;
            this.removepatronbutton.Text = "Remove Patron";
            this.removepatronbutton.UseVisualStyleBackColor = true;
            // 
            // RemovePatronBox
            // 
            this.RemovePatronBox.Location = new System.Drawing.Point(16, 64);
            this.RemovePatronBox.Margin = new System.Windows.Forms.Padding(2);
            this.RemovePatronBox.Name = "RemovePatronBox";
            this.RemovePatronBox.Size = new System.Drawing.Size(80, 23);
            this.RemovePatronBox.TabIndex = 1;
            // 
            // removePatronlabel
            // 
            this.removePatronlabel.AutoSize = true;
            this.removePatronlabel.Location = new System.Drawing.Point(18, 41);
            this.removePatronlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.removePatronlabel.Name = "removePatronlabel";
            this.removePatronlabel.Size = new System.Drawing.Size(81, 17);
            this.removePatronlabel.TabIndex = 0;
            this.removePatronlabel.Text = "Patron ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // patroneditlabel
            // 
            this.patroneditlabel.AutoSize = true;
            this.patroneditlabel.Location = new System.Drawing.Point(8, 33);
            this.patroneditlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patroneditlabel.Name = "patroneditlabel";
            this.patroneditlabel.Size = new System.Drawing.Size(87, 17);
            this.patroneditlabel.TabIndex = 10;
            this.patroneditlabel.Text = "Patron ID*:";
            this.patroneditlabel.Click += new System.EventHandler(this.label17_Click);
            // 
            // editaddresslabel
            // 
            this.editaddresslabel.AutoSize = true;
            this.editaddresslabel.Location = new System.Drawing.Point(8, 197);
            this.editaddresslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editaddresslabel.Name = "editaddresslabel";
            this.editaddresslabel.Size = new System.Drawing.Size(72, 17);
            this.editaddresslabel.TabIndex = 8;
            this.editaddresslabel.Text = "Address:";
            this.editaddresslabel.Click += new System.EventHandler(this.label19_Click);
            // 
            // editidlabel
            // 
            this.editidlabel.AutoSize = true;
            this.editidlabel.Location = new System.Drawing.Point(8, 150);
            this.editidlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editidlabel.Name = "editidlabel";
            this.editidlabel.Size = new System.Drawing.Size(89, 17);
            this.editidlabel.TabIndex = 7;
            this.editidlabel.Text = "Student ID:";
            this.editidlabel.Click += new System.EventHandler(this.label18_Click);
            // 
            // editnamelabel
            // 
            this.editnamelabel.AutoSize = true;
            this.editnamelabel.Location = new System.Drawing.Point(196, 36);
            this.editnamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editnamelabel.Name = "editnamelabel";
            this.editnamelabel.Size = new System.Drawing.Size(54, 17);
            this.editnamelabel.TabIndex = 6;
            this.editnamelabel.Text = "Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 32);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, -2);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "User Information Edit ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(98, 197);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 23);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 150);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(2, 2);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 299);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(466, 5);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(73, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(275, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // searchbookbutton
            // 
            this.searchbookbutton.AutoSize = true;
            this.searchbookbutton.Checked = true;
            this.searchbookbutton.Location = new System.Drawing.Point(461, 28);
            this.searchbookbutton.Margin = new System.Windows.Forms.Padding(2);
            this.searchbookbutton.Name = "searchbookbutton";
            this.searchbookbutton.Size = new System.Drawing.Size(50, 17);
            this.searchbookbutton.TabIndex = 4;
            this.searchbookbutton.TabStop = true;
            this.searchbookbutton.Text = "Book";
            this.searchbookbutton.UseVisualStyleBackColor = true;
            // 
            // searchpatronbutton
            // 
            this.searchpatronbutton.AutoSize = true;
            this.searchpatronbutton.Location = new System.Drawing.Point(461, 51);
            this.searchpatronbutton.Margin = new System.Windows.Forms.Padding(2);
            this.searchpatronbutton.Name = "searchpatronbutton";
            this.searchpatronbutton.Size = new System.Drawing.Size(56, 17);
            this.searchpatronbutton.TabIndex = 5;
            this.searchpatronbutton.Text = "Patron";
            this.searchpatronbutton.UseVisualStyleBackColor = true;
            this.searchpatronbutton.CheckedChanged += new System.EventHandler(this.searchpatronbutton_CheckedChanged);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(406, 5);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(56, 19);
            this.searchbutton.TabIndex = 6;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Address:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(98, 70);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(94, 23);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "State:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(98, 110);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(46, 23);
            this.textBox6.TabIndex = 15;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "City:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(250, 73);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(94, 23);
            this.textBox7.TabIndex = 17;
            // 
            // LibraryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(551, 477);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchpatronbutton);
            this.Controls.Add(this.searchbookbutton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.tabsystem);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LibraryGUI";
            this.Text = "KSU Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabsystem.ResumeLayout(false);
            this.Circulation.ResumeLayout(false);
            this.Circulation.PerformLayout();
            this.Patron.ResumeLayout(false);
            this.patrontabs.ResumeLayout(false);
            this.addpatrontab.ResumeLayout(false);
            this.addpatrontab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsystem;
        private System.Windows.Forms.TabPage Circulation;
        private System.Windows.Forms.Button removebookbutton;
        private System.Windows.Forms.Button addbookbutton;
        private System.Windows.Forms.TabPage Patron;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label RemoveBooklabel;
        private System.Windows.Forms.TextBox removebookbox;
        private System.Windows.Forms.TextBox addbooktextbox1;
        private System.Windows.Forms.Label Addbooklabel;
        private System.Windows.Forms.RadioButton searchpatronbutton;
        private System.Windows.Forms.RadioButton searchbookbutton;
        private System.Windows.Forms.MaskedTextBox checkoutbox;
        private System.Windows.Forms.Button checkoutbutton;
        private System.Windows.Forms.Button checkinbutton;
        private System.Windows.Forms.Label Checkoutlabel;
        private System.Windows.Forms.TextBox checkinbox;
        private System.Windows.Forms.Label Checkinlabel;
        private System.Windows.Forms.TabControl patrontabs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TabPage addpatrontab;
        private System.Windows.Forms.TextBox statebox;
        private System.Windows.Forms.TextBox citybox;
        private System.Windows.Forms.Button patronadd;
        private System.Windows.Forms.Label ziplabel;
        private System.Windows.Forms.Label statelabel;
        private System.Windows.Forms.Label citylabel;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.TextBox studentidbox;
        private System.Windows.Forms.TextBox firstnamebox;
        private System.Windows.Forms.TextBox lastnamebox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label namelabel1;
        private System.Windows.Forms.Label userinfolabel;
        private System.Windows.Forms.TextBox zipbox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label removePatronlabel;
        private System.Windows.Forms.TextBox RemovePatronBox;
        private System.Windows.Forms.Button removepatronbutton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label editaddresslabel;
        private System.Windows.Forms.Label editidlabel;
        private System.Windows.Forms.Label editnamelabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label patroneditlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox7;
    }
}

