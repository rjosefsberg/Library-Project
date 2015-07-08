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
            this.SaveandExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.authorlast = new System.Windows.Forms.TextBox();
            this.authorfirst = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Pubdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addbookinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbookinfo
            // 
            this.addbookinfo.Controls.Add(this.label6);
            this.addbookinfo.Controls.Add(this.label5);
            this.addbookinfo.Controls.Add(this.Pubdate);
            this.addbookinfo.Controls.Add(this.textBox5);
            this.addbookinfo.Controls.Add(this.authorfirst);
            this.addbookinfo.Controls.Add(this.authorlast);
            this.addbookinfo.Controls.Add(this.label3);
            this.addbookinfo.Controls.Add(this.label2);
            this.addbookinfo.Controls.Add(this.label1);
            this.addbookinfo.Controls.Add(this.SaveandExit);
            this.addbookinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbookinfo.Location = new System.Drawing.Point(25, 5);
            this.addbookinfo.Name = "addbookinfo";
            this.addbookinfo.Size = new System.Drawing.Size(395, 452);
            this.addbookinfo.TabIndex = 0;
            this.addbookinfo.TabStop = false;
            this.addbookinfo.Text = "Book Information";
            this.addbookinfo.Enter += new System.EventHandler(this.addbookinfo_Enter);
            // 
            // SaveandExit
            // 
            this.SaveandExit.Location = new System.Drawing.Point(55, 295);
            this.SaveandExit.Name = "SaveandExit";
            this.SaveandExit.Size = new System.Drawing.Size(226, 80);
            this.SaveandExit.TabIndex = 0;
            this.SaveandExit.Text = "Save\r\n +\r\nExit";
            this.SaveandExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Publication\r\nDate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shelf ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // authorlast
            // 
            this.authorlast.Location = new System.Drawing.Point(140, 48);
            this.authorlast.Name = "authorlast";
            this.authorlast.Size = new System.Drawing.Size(116, 27);
            this.authorlast.TabIndex = 5;
            // 
            // authorfirst
            // 
            this.authorfirst.Location = new System.Drawing.Point(273, 45);
            this.authorfirst.Name = "authorfirst";
            this.authorfirst.Size = new System.Drawing.Size(116, 27);
            this.authorfirst.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 167);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 27);
            this.textBox5.TabIndex = 9;
            // 
            // Pubdate
            // 
            this.Pubdate.Location = new System.Drawing.Point(140, 109);
            this.Pubdate.Name = "Pubdate";
            this.Pubdate.Size = new System.Drawing.Size(116, 27);
            this.Pubdate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "First";
            // 
            // addbookpop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(446, 469);
            this.Controls.Add(this.addbookinfo);
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
        private System.Windows.Forms.TextBox Pubdate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox authorfirst;
        private System.Windows.Forms.TextBox authorlast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
