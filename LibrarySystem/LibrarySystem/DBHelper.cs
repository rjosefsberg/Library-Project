using System;
using MySql.Data.MySqlClient;


public class DBHelper
{
    private String cs = "Server = localhost; Database=mydb;Uid = root;password=root";
       
    public void dbConnect()
    {
         try
         {
             String cs = "server=localhost;database=mydb;uid=root;password=root";
             MySqlConnection connect = new MySqlConnection(cs);
             connect.Open();
             MySqlCommand myCommand = new MySqlCommand();
             myCommand.Connection = connect;
             myCommand.CommandText = "select * from department";

             MySqlDataReader myReader = myCommand.ExecuteReader();
               
              while (myReader.Read())
              {
                    Console.WriteLine(myReader["DNAME"].ToString());
                    Console.WriteLine(myReader["DNUMBER"].ToString());
                    Console.WriteLine(myReader["MGRSSN"].ToString());
                    Console.WriteLine(myReader["MGRSTARTDATE"].ToString());
              }
              Console.ReadLine();
              connect.Close();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
}



