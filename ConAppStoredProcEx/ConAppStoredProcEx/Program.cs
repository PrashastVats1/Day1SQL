////using stored procedures for CRUD operations
////insert using stored procedures
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConAppStoredProcEx
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day8Db;trusted_connection=true";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conStr);
//                con.Open();
//                cmd = new SqlCommand();
//                cmd.CommandText = "usp_iEmp";
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Connection = con;
//                Console.WriteLine("Enter ID");
//                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter First Name");
//                cmd.Parameters.AddWithValue("@fn", Console.ReadLine());
//                Console.WriteLine("Enter Last Name");
//                cmd.Parameters.AddWithValue("@ln", Console.ReadLine());
//                Console.WriteLine("Enter Designation");
//                cmd.Parameters.AddWithValue("@desg", Console.ReadLine());
//                Console.WriteLine("Enter Salary");
//                cmd.Parameters.AddWithValue("@sal", double.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter Date of Joining");
//                cmd.Parameters.AddWithValue("@doj", DateTime.Parse(Console.ReadLine()));
//                cmd.ExecuteNonQuery();
//                Console.WriteLine("Employee Registration Success!!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}

////delete using stored procedures
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConAppStoredProcEx
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day8Db;trusted_connection=true";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conStr);
//                con.Open();
//                cmd = new SqlCommand();
//                cmd.CommandText = "usp_dEmp";
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Connection = con;
//                Console.WriteLine("Enter Id to delete the record");
//                int id = int.Parse(Console.ReadLine());
//                cmd.Parameters.AddWithValue("@id", id);
//                int noe = cmd.ExecuteNonQuery();
//                if (noe > 0)
//                {
//                    Console.WriteLine($"Employee Record wiih Id: {id} deleted!");
//                }
//                else
//                {
//                    Console.WriteLine($"Record with Id: {id} not found");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}

//search using stored procedures
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppStoredProcEx
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day8Db;trusted_connection=true";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conStr);
                cmd = new SqlCommand();
                cmd.CommandText = "usp_searchEmp";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                Console.WriteLine("Enter Id to find the Employee record");
                int id = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    Console.WriteLine($"Employee Record of Id: {id} found./nDetails as follows");
                    while(reader.Read())
                    {
                        Console.WriteLine(reader["Id"]);
                        Console.WriteLine(reader["Fname"]);
                        Console.WriteLine(reader["Lname"]);
                        Console.WriteLine(reader["Designation"]);
                        Console.WriteLine(reader["Salary"]);
                        Console.WriteLine(reader["DOJ"]);
                    }
                }
                else
                {
                    Console.WriteLine($"No record with Id: {id} found");
                }
            }
            catch (Exception ex)
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

