namespace WindowsFormsApplication1
{
    partial class addbookpop
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
            this.addbookinfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pubdatebox = new System.Windows.Forms.TextBox();
            this.addbookshelfidbox = new System.Windows.Forms.TextBox();
            this.addbookauthorfirst = new System.Windows.Forms.TextBox();
            this.addbookauthorlast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveandExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addbookisbnbox = new System.Windows.Forms.TextBox();
            this.addbooktitlebox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addbookinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbookinfo
            // 
            this.addbookinfo.Controls.Add(this.label7);
            this.addbookinfo.Controls.Add(this.addbooktitlebox);
            this.addbookinfo.Controls.Add(this.addbookisbnbox);
            this.addbookinfo.Controls.Add(this.label4);
            this.addbookinfo.Controls.Add(this.label6);
            this.addbookinfo.Controls.Add(this.label5);
            this.addbookinfo.Controls.Add(this.pubdatebox);
            this.addbookinfo.Controls.Add(this.addbookshelfidbox);
            this.addbookinfo.Controls.Add(this.addbookauthorfirst);
            this.addbookinfo.Controls.Add(this.addbookauthorlast);
            this.addbookinfo.Controls.Add(this.label3);
            this.addbookinfo.Controls.Add(this.label2);
            this.addbookinfo.Controls.Add(this.label1);
            this.addbookinfo.Controls.Add(this.SaveandExit);
            this.addbookinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbookinfo.Location = new System.Drawing.Point(11, 4);
            this.addbookinfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbookinfo.Name = "addbookinfo";
            this.addbookinfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbookinfo.Size = new System.Drawing.Size(383, 367);
            this.addbookinfo.TabIndex = 0;
            this.addbookinfo.TabStop = false;
            this.addbookinfo.Text = "Book Information (All Required)";
            this.addbookinfo.Enter += new System.EventHandler(this.addbookinfo_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "First";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last";
            // 
            // pubdatebox
            // 
            this.pubdatebox.Location = new System.Drawing.Point(115, 172);
            this.pubdatebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pubdatebox.Name = "pubdatebox";
            this.pubdatebox.Size = new System.Drawing.Size(117, 23);
            this.pubdatebox.TabIndex = 10;
            // 
            // addbookshelfidbox
            // 
            this.addbookshelfidbox.Location = new System.Drawing.Point(115, 234);
            this.addbookshelfidbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbookshelfidbox.Name = "addbookshelfidbox";
            this.addbookshelfidbox.Size = new System.Drawing.Size(117, 23);
            this.addbookshelfidbox.TabIndex = 9;
            // 
            // addbookauthorfirst
            // 
            this.addbookauthorfirst.Location = new System.Drawing.Point(247, 120);
            this.addbookauthorfirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbookauthorfirst.Name = "addbookauthorfirst";
            this.addbookauthorfirst.Size = new System.Drawing.Size(116, 23);
            this.addbookauthorfirst.TabIndex = 7;
            // 
            // addbookauthorlast
            // 
            this.addbookauthorlast.Location = new System.Drawing.Point(115, 120);
            this.addbookauthorlast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbookauthorlast.Name = "addbookauthorlast";
            this.addbookauthorlast.Size = new System.Drawing.Size(117, 23);
            this.addbookauthorlast.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shelf ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Publication\r\n     Date:\r\n(yyyy-mm-dd)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author Name:";
            // 
            // SaveandExit
            // 
            this.SaveandExit.Location = new System.Drawing.Point(117, 283);
            this.SaveandExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveandExit.Name = "SaveandExit";
            this.SaveandExit.Size = new System.Drawing.Size(170, 65);
            this.SaveandExit.TabIndex = 0;
            this.SaveandExit.Text = "Save\r\n +\r\nExit";
            this.SaveandExit.UseVisualStyleBackColor = true;
            this.SaveandExit.Click += new System.EventHandler(this.SaveandExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "ISBN:";
            // 
            // addbookisbnbox
            // 
            this.addbookisbnbox.Location = new System.Drawing.Point(115, 69);
            this.addbookisbnbox.Name = "addbookisbnbox";
            this.addbookisbnbox.Size = new System.Drawing.Size(191, 23);
            this.addbookisbnbox.TabIndex = 14;
            this.addbookisbnbox.TextChanged += new System.EventHandler(this.addbookisbnbox_TextChanged);
            // 
            // addbooktitlebox
            // 
            this.addbooktitlebox.Location = new System.Drawing.Point(115, 34);
            this.addbooktitlebox.Name = "addbooktitlebox";
            this.addbooktitlebox.Size = new System.Drawing.Size(191, 23);
            this.addbooktitlebox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Title:";
            // 
            // addbookpop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(418, 381);
            this.Controls.Add(this.addbookinfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addbookpop";
            this.Text = "Add Book";
            this.addbookinfo.ResumeLayout(false);
            this.addbookinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addbookinfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveandExit;
        private System.Windows.Forms.TextBox pubdatebox;
        private System.Windows.Forms.TextBox addbookshelfidbox;
        private System.Windows.Forms.TextBox addbookauthorfirst;
        private System.Windows.Forms.TextBox addbookauthorlast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addbooktitlebox;
        private System.Windows.Forms.TextBox addbookisbnbox;
        private System.Windows.Forms.Label label4;
    }
}
