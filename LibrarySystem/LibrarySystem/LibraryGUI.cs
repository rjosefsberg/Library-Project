using MySql.Data.MySqlClient;
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

        private void button1_Click(object sender, EventArgs e)
        {
            addbookpop f2 = new addbookpop();
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
                MessageBox.Show("Book removed from database.");
                removebookbox.Text = String.Empty;
            }
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            removebookbox.MaxLength = 13;
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
                String dbString = "Update books SET Checked_Out = 'N', Out_Date = null, Due_Date = null, By_patron = null WHERE ISBN = " + sISBN + ";";
                DBHelper db = new DBHelper();
                db.dbUpdate(dbString);
                MessageBox.Show("Check in successful.");
                checkinbox.Text = String.Empty;
            }
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

                DBHelper db = new DBHelper();
                MessageBox.Show("Check out successfull.");
                db.dbUpdate(dbString);
                checkoutboxpatron.Text = String.Empty;
                checkoutboxbook.Text = String.Empty;
            }
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
                    case "Patron ID": dbString = "Select * from patron where patron_ID LIKE '%" + boxString + "%' AND NOT Inactive;";
                        break;

                    case "First Name": dbString = "Select * from patron where First_Name LIKE '%" + boxString + "%' AND NOT Inactive;";
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

        private void patronadd_Click(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            MySqlDataReader myReader = null;
            MySqlConnection myConnection = new MySqlConnection("Server = localhost; Database=libdb;Uid = root;password=root");
            MySqlCommand myCommand = new MySqlCommand("select count(Patron_ID) from patron", myConnection);
            String idCount = null;
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                idCount = myReader[0].ToString();
            }

            int intCount = int.Parse(idCount);
            intCount++;

            String newID = null;
            if (idCount.Length == 4)
                newID = "1" + intCount;
            else if (idCount.Length == 3)
                newID = "10" + intCount;
            else if (idCount.Length == 2)
                newID = "100" + intCount;
            else
                newID = "1000" + intCount;


            String addPatron = "INSERT INTO patron (Patron_ID, Last_Name, First_Name, Email, Telephone, Address, City, State, Inactive) values ('" + newID + "','" + this.lastnamebox.Text + "','" + this.firstnamebox.Text + "','" + this.emailbox.Text + "','" + this.phonebox.Text + "','" + addressbox.Text + "','" + this.citybox.Text + "','" + this.statebox.Text + "', FALSE);";


            db.dbUpdate(addPatron);
            MessageBox.Show("Entry created. New Patron ID:" + newID);
            this.lastnamebox.Text = String.Empty;
            this.firstnamebox.Text = String.Empty;
            this.emailbox.Text = String.Empty;
            this.phonebox.Text = String.Empty;
            this.addressbox.Text = String.Empty;
            this.citybox.Text = String.Empty;
            this.statebox.Text = String.Empty;
            myConnection.Close();
        }

        private void removepatronbutton_Click(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            String sPatron_ID = RemovePatronBox.Text;
            if (sPatron_ID.Length != 5)
            {
                MessageBox.Show("Incorrect Length for Patron ID");
            }

            else
            {
                String dbString = "UPDATE patron SET Inactive = TRUE where Patron_ID = " + sPatron_ID + ";";
                db.dbUpdate(dbString);
                MessageBox.Show("Patron "+sPatron_ID+" set to Inactive");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            String Query = "Update patron SET Last_Name = '" + this.editlnamebox.Text + "',First_Name = '" + this.editfnamebox.Text + "',Email = '" + this.editemailbox.Text + "',Address = '" + this.editaddressbox.Text + "',City = '" + editcitybox.Text + "',State = '" + this.editstatebox.Text + "',Telephone = '" + this.editphonebox.Text + "' WHERE patron_ID = '" + editpatronbox.Text + "';";
            db.dbUpdate(Query);
            this.editlnamebox.Text = String.Empty;
            this.editfnamebox.Text = String.Empty;
            this.editemailbox.Text = String.Empty;
            this.editphonebox.Text = String.Empty;
            this.editaddressbox.Text = String.Empty;
            this.editcitybox.Text = String.Empty;
            this.editstatebox.Text = String.Empty;
            this.editpatronbox.Text = String.Empty;

            MessageBox.Show("Update for patron " + editpatronbox.Text + " updated.");

        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            String patronID = editpatronbox.Text;
            DBHelper db = new DBHelper();
            MySqlDataReader myReader = null;
            MySqlConnection myConnection = new MySqlConnection("Server = localhost; Database=libdb;Uid = root;password=root");
            MySqlCommand myCommand = new MySqlCommand("select * from patron where Patron_ID =" + patronID + "", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                editlnamebox.Text = myReader[1].ToString();
                editfnamebox.Text = myReader[2].ToString();
                editemailbox.Text = myReader[3].ToString();
                editphonebox.Text = myReader[4].ToString();
                editaddressbox.Text = myReader[5].ToString();
                editcitybox.Text = myReader[6].ToString();
                editstatebox.Text = myReader[7].ToString();
            }
        }

        private void reactivatePatron_Click_1(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            String sPatron_ID = RemovePatronBox.Text;
            if (sPatron_ID.Length != 5)
            {
                MessageBox.Show("Incorrect Length for Patron ID");
            }

            else
            {
                String dbString = "UPDATE patron SET Inactive = FALSE where Patron_ID = " + sPatron_ID + ";";
                db.dbUpdate(dbString);
                MessageBox.Show("Patron " + sPatron_ID + " status set to Active.");
            }


        }

        private void checkinbox_TextChanged(object sender, EventArgs e)
        {
            checkinbox.MaxLength = 13;
        }

        private void statebox_TextChanged(object sender, EventArgs e)
        {
            statebox.MaxLength = 2;
        }


        private void checkoutboxpatron_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            checkoutboxpatron.MaxLength = 5;
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            editstatebox.MaxLength = 2;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbookradio_CheckedChanged(object sender, EventArgs e)
        {


        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

      

        private void textBox6_TextChanged(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}




