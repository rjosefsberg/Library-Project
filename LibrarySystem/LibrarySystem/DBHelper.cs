using System;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;


public class DBHelper
{
    private String cs;  
    private String cmd; 
    public DBHelper()
    { 
        cs = "Server = localhost; Database=libdb;Uid = root;password=root";// for now just assume this'll work. That,                                                                    or download MySQL workbench and make a                                                                      simple DB yourself
    }                                                                      

    public DBHelper(String s)
    {
        this.cs = getCS();
        this.cmd = s;
    }
    
    public String getCS()    {return cs;}
    public void setCS(String s)    {cs = s;}
    public String getCMD()    {return cmd;}
    public void setCMD(String s)    {cmd = s;}


    public void dbSearch(String s)//will retrieve whatever table entries you request, but youll need to bind
    {                             //then using BindingSource to a datagridview in the GUI.
        try
        {
            MySqlConnection connect = new MySqlConnection(getCS());
            connect.Open();
            MySqlCommand myCommand = new MySqlCommand(s);
            myCommand.Connection = connect;
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = myCommand;
            DataTable dataset = new DataTable();
            adp.Fill(dataset);
                      
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
    public void dbUpdate(String s) //if you feed this an SQL update string is should just do it. 
    {                               // No confirmation.
        try 
        {
            MySqlConnection connect = new MySqlConnection(getCS());
            MySqlCommand myCommand = new MySqlCommand(s);
            myCommand.Connection = connect;
            connect.Open();
            myCommand.ExecuteNonQuery();
            connect.Close();
        }
    
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    public void dbPopulate()//set up a mySQL database with the info in the connection string in dbConnect(). Thisll populate it with the patron and book table. 
    {
        String patronTableString = "CREATE DATABASE  IF NOT EXISTS `libdb`; USE `libdb`; DROP TABLE IF EXISTS `patron`;" +
        "CREATE TABLE `patron` (" +
          "`Patron_ID` int(5) NOT NULL, " +
          "`Last_Name` varchar(20) DEFAULT NULL, " + 
          "`First_Name` varchar(20) DEFAULT NULL, " +
          "`Email` varchar(30) DEFAULT NULL, " +
          "`Telephone` varchar(30) DEFAULT NULL," +
          "`Address` varchar(30) DEFAULT NULL," +
          "`City` varchar(20) DEFAULT NULL, "+
          "`State` varchar(2) DEFAULT NULL, "+
          "PRIMARY KEY (`Patron_ID`) "+
        ") ENGINE=InnoDB DEFAULT CHARSET=utf8;";

        

        String patronDataString =
            "LOCK TABLES `patron` WRITE;" +

        "INSERT INTO `patron` VALUES (10001,'Clark','Ann','goodgirl@gmail.com','4042992999','310 Simpson Court','Atlanta','Ga')," +

        "(10002,'Ball','Britney','BBall@gmail.com','7708993217','109 Dolphin Street','Atlanta','Ga'),(10003,'Rightner','Patrick','Pat245@yahoo.com','6789562310','569 Drake " +

        "Ave','Roswell','Ga'),(10004,'Peters','Joan','Joni@hotmail.com','4046562312','324 Fronthole Lane','Atlanta','Ga')," +

        "(10005,'Davis','Paul','Paul46@gmail.com','7062354785','1111 Franfort Drive','Atlanta','Ga'),(10006,'Perry','Bo','BOt789@hotmail.com','6485210333','5674 Petersvine " +

        "Road','Snellville','Ga'),(10007,'Dobbs','Bill','Billyboy@gmail.com','7704121236','599 Eggshy View','Kennesaw','Ga')," +

        "(10008,'Broom','Spencer','Spence555@yahoo.com','4044658793','610 Vinnings Court','Atlanta','Ga'),(10009,'Cottle','Barry','CotBarry@gmail.com','7705642132','9987 Bishop " +

        "Dam Drive','Alpharetta','Ga'),(10010,'Sprinter','Bill','Sp2277@hotmail.com','6782675642','45 Will Street','Loganville','Ga')," +

        "(10011,'Butter','John','BiGJohn@yahoo.com','7705214986','2227 Intrinbuck Avenue','Roswell','Ga'),(10012,'Boston','Kipp','Baseloaded@gmail.com','7063935427','5690 Furry " +

        "Fella Park','Atlanta','Ga'),(10013,'Pewtrid','Huckle','hcp49@gmail.com','4041245798','6854 Goodview Circle','College Park','Ga')," +

        "(10014,'Levinson','Ira','Ira7654@gmail.com','4045642139','5845 Anglea Drive','Buckhead','Ga'),(10015,'Penn','Sherry','SpS77@gmail.com','7702315468','4546 Clifford " +

        "Circle','Cummings','Ga'),(10016,'Kenny','Christopher','Chriskissed@hotmail.com','4046563232','611 Hollyview Lane','Sandy Springs','Ga');" +
        "UNLOCK TABLES;";

        String alterString = "LOCK TABLES `patron` WRITE;" +
                             "ALTER TABLE `patron` ADD `Inactive` BOOLEAN DEFAULT FALSE;" +
                             "UNLOCK TABLES;";

        this.dbUpdate(patronTableString);
        this.dbUpdate(patronDataString);
        this.dbUpdate(alterString);

        String bookTableString = "DROP TABLE IF EXISTS `Books`;" +
        "CREATE TABLE Books (" +
        "ISBN BIGINT(13) NOT NULL," +
        "Title Varchar(50),"+ 
        "Author_Lastname Varchar(40)," + 
        "Author_Firstname Varchar(30)," +
        "Publication_date date," +
        "Shelf_ID Varchar(6) NOT NULL," +
        "Checked_Out CHAR(1) NOT NULL DEFAULT 'N'," +
        "Out_Date Varchar (10)," +
        "Due_Date Varchar (10)," +
        "By_patron int(5) NULL," +
        "PRIMARY KEY (ISBN));";

        String bookDataString =
        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) " +

        "VALUES(9870691147147,'Digitized','Bentley','Peter','2011-01-07','004.00','N', null,null);"+

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9781439856185,'Computer Science Literacy','Idziorek','Joseph','2012-11-25','004.01','N', null,null);" +

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9781461411673,'Computer Science','Aho','Alfred','2011-04-21','004.02','N', null,null);"+

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9789535104360,'Software Product Line','Elfaki','Abdelrahman','2012-04-16','004.03','N', null,null);"+

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9780199234004,'A Dictionary of Computing','Wright','Edumund','2008-02-26','004.04','N', null,null);"+

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9781600215186,'Computer Science Reasearch Trends','Yarnall','Casey','2001-12-31','004.05','N', null,null);" +

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) " +

        "VALUES(9781599049380,'Information Security and Ethics','Nemati','Hamid','2007-09-30','004.06','N', null,null);" +

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9780262018326,'On Computing','Rosenbloom','Paul','2013-09-12','004.07','N', null,null);" +

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9781590209745,'Hacking the Future','Stryker','Cole','2012-09-13','004.08','N', null,null);"+

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9780133406955,'Visual Basic 2012 How To Program','Deitel','Paul','2013-05-01','004.09','N', null,null);"+

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9780133439854,'C++11 FOR Programmers','Deitel','Harvey','2013-03-13','004.10','N', null,null);"+

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9781285160719,'Comp TIA a+ 220-801-220-802 Q&a','Staff','John','2013-03-15','004.11','N', null,null);"+

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9781466569935,'IOS Game Development','Lucka','Thomas','2013-09-04','004.12','N', null,null);" +

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9780321918932,'Foundations of Web Design','Michaud','Thomas','2013-08-21','004.13','N', null,null);" +

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9780203909782,'Software Process Quality','Kenett','Ron','1999-01-22','004.14','N', null,null);"+

        "INSERT INTO Books(ISBN,Title,Author_Lastname,Author_Firstname,Publication_Date,Shelf_ID,Checked_Out,Out_Date, Due_Date) "+

        "VALUES(9780387301624,'Encyclopedia of Algorithms','Yang','Ming','2008-07-07','004.15','N', null,null);";

        dbUpdate(bookTableString);
        dbUpdate(bookDataString);
    }
}



