using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class addbookpop : Form
    {
        public addbookpop()
        {
            InitializeComponent();
        }

        private void addbookinfo_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SaveandExit_Click(object sender, EventArgs e)
        {
            String ISBN = addbookisbnbox.Text;
            String title = addbooktitlebox.Text;
            String authorLast = addbookauthorlast.Text;
            String authorFirst = addbookauthorfirst.Text;
            String pubDate = pubdatebox.Text;
            String shelfID = addbookshelfidbox.Text;
            
            if (ISBN.Length != 13)
            {
                MessageBox.Show("Incorrect length for ISBN (13)");
            }
            else
            {
                DBHelper db = new DBHelper();
                String dbString = "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+
                  "VALUES (" + ISBN + ",'" + title + "','" + authorLast + "','" + authorFirst + "','" + pubDate + "','" + shelfID + "', 'N',null,null);";
                Console.WriteLine(dbString);    
                db.dbUpdate(dbString);
            }
        }

        private void addbookisbnbox_TextChanged(object sender, EventArgs e)
        {
            addbookisbnbox.MaxLength = 13;
        }
    }
}
