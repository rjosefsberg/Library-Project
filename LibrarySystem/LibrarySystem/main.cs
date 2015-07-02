using System;
using System.Data;

public class LibrarySystem
{
    public static void Main(string[] args)
    {
        DBHelper db = new DBHelper();
        db.dbPopulate();
       
    }
}
