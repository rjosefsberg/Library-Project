using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication1;

public class LibrarySystem
{
    public static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new LibraryGUI());
        DBHelper db = new DBHelper();
        db.dbPopulate();      
    }
}
