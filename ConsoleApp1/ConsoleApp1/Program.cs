using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConAppAdoReader
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=OurDb;trusted_connection=true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("select * from Employees",con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("ID: " + reader["ID"]);
                    Console.WriteLine("First Name: " + reader["FirstName"]);
                    Console.WriteLine("Last Name: " + reader["LastName"]);
                    Console.WriteLine("Manager ID: " + reader["ManagerId"]);
                    Console.WriteLine("--------------------------------------------------------------");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally 
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
