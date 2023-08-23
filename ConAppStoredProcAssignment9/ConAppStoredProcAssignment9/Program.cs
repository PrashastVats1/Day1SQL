using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConAppStoredProcAssignment9
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=OrderDb;trusted_connection=true";
        static void Main(string[] args)
        {
                while (true)
                {
                    Console.WriteLine("Enter Customer Id");
                    int cid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Total Amount");
                    double total_amt = double.Parse(Console.ReadLine());
                    ExecutePlaceOrder(cid, total_amt);
                    Console.WriteLine("Do you want to place another order? (y/n)");
                    string contin = Console.ReadLine();
                    if (contin.ToLower() != "y")
                        break;
                }
        }
        static void ExecutePlaceOrder(int cid, double total_amt)
        {
            try {
                con = new SqlConnection(conStr);
                cmd = new SqlCommand();
                cmd.CommandText = "usp_PlaceOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@CID", cid);
                cmd.Parameters.AddWithValue("@TA", total_amt);
                con.Open();
                reader = cmd.ExecuteReader();
                Console.WriteLine("Order Placed successfully");
            }
        
                catch (Exception ex)
                {
                    Console.WriteLine("Error!!" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            
        }
    }
}
