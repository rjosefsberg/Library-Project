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
    public partial class LibraryGUI : Form
    {
        public LibraryGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addbookpop f2 = new addbookpop (); 
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sISBN = removebookbox.Text;
            if (sISBN.Length != 13)
            {
                MessageBox.Show("Incorrect Length for ISBN");
            }
            else
            {
                String dbString = "Delete from books where ISBN = " + sISBN + ";";
                DBHelper db = new DBHelper();
                db.dbUpdate(dbString);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Circulation_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sISBN = checkinbox.Text;
            if (sISBN.Length != 13)
            {
                MessageBox.Show("Incorrect length for ISBN (13)");
            }
            else 
            {
                String dbString = "Update books SET Checked_Out = 'N', Out_Date = null, Due_Date = null, By_patron = null WHERE ISBN = "+sISBN+";";
                DBHelper db = new DBHelper();
                db.dbUpdate(dbString);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void searchpatronbutton_CheckedChanged(object sender, EventArgs e)
        {
            searchCombo.Items.Clear();
            Boolean check = false;
            if (searchpatronradio.Checked && check == false)
            {
                searchCombo.Items.Add("Patron ID");
                searchCombo.Items.Add("First Name");
                searchCombo.Items.Add("Last Name");
                searchCombo.Items.Add("Phone");
                searchCombo.Items.Add("Email");
            }
            else 
            {
                searchCombo.Items.Add("Title");
                searchCombo.Items.Add("Author First");
                searchCombo.Items.Add("Author Last");
                searchCombo.Items.Add("ISBN");
                searchCombo.Items.Add("Shelf");
            }
            
        }

        private void statebox_TextChanged(object sender, EventArgs e)
        {
            statebox.MaxLength = 2;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            textBox6.MaxLength = 2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Checkinlabel_Click(object sender, EventArgs e)
        {

        }

        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            String sISBN = checkoutboxbook.Text;
            String sPatron = checkoutboxpatron.Text;
            if (sISBN.Length != 13)
            {
                MessageBox.Show("Incorrect length for ISBN (13)");
            }
            else if (sPatron.Length != 5)
            {
                MessageBox.Show("Incorrect length for Patron ID (5)");
            }

            else
            {
                DateTime dtToday = DateTime.Today;
                String sOut = dtToday.ToString("yyyy-MM-dd");
                DateTime dtDue = dtToday.AddDays(14.00);
                String sDue = dtDue.ToString("yyyy-MM-dd");

                String dbString = "UPDATE books SET Checked_Out= 'Y',Out_Date= '" + sOut + "', Due_Date= '" + sDue + "', By_patron= " + sPatron + " WHERE ISBN= " + sISBN + ";";

                Console.WriteLine(dbString);

                DBHelper db = new DBHelper();
                db.dbUpdate(dbString);
            }
        }

        private void checkoutboxpatron_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            checkoutboxpatron.MaxLength = 5;
        }
    
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbookradio_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            String searchParam = searchCombo.SelectedItem.ToString();
            String boxString = SearchBox.Text;
            String dbString = null;
            DBHelper db = new DBHelper();

            if (searchpatronradio.Checked)
            {
                switch (searchParam)
                {
                    case "Patron ID": dbString = "Select * from patron where patron_ID LIKE '%"+boxString+"%' AND NOT Inactive;" ;
                        break;

                    case "First Name": dbString = "Select * from patron where First_Name LIKE '%"+boxString+"%' AND NOT Inactive;" ;
                        break;

                    case "Last Name": dbString = "Select * from patron where Last_Name LIKE '%" + boxString + "%' AND NOT Inactive;";
                        break;

                    case "Phone": dbString = "Select * from patron where Telephone LIKE '%" + boxString + "%' AND NOT Inactive;";
                        break;

                    case "Email": dbString = "Select * from patron where Email LIKE '%" + boxString + "%' AND NOT Inactive;";
                        break;
                }
            }
            
            if (searchbookradio.Checked)
            {
                switch (searchParam)
                {
                    case "Title": dbString = "Select * from books where Title LIKE '%" + boxString + "%';"; break;
                    case "Author First": dbString = "Select * from books where Author_Firstname LIKE '%" + boxString + "%';"; break;
                    case "Author Last": dbString = "Select * from books where Author_Lastname LIKE '%" + boxString + "%';"; break;
                    case "ISBN": dbString = "Select * from books where ISBN LIKE '%" + boxString + "%';"; break;
                    case "Shelf": dbString = "Select * from books where Shelf_ID LIKE '%" + boxString + "%';"; break;
                }
            }
            db.dbSearch(dbString, searchResults);
     }

        private void populateButton_Click(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            db.dbPopulate();
        }
            
                
   }
}




