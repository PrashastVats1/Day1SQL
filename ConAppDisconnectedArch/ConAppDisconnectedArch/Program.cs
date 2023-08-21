//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace ConAppDisconnectedArch
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataAdapter adapter;
//        static DataSet ds;
//        static SqlDataReader reader;
//        static string conString = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day7DB;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                adapter = new SqlDataAdapter(cmd);
//                con.Open();
//                ds = new DataSet();
//                adapter.Fill(ds);
//                con.Close();
//                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
//                {
//                    Console.WriteLine("ID: " + ds.Tables[0].Rows[i]["Id"]);
//                    Console.WriteLine("Name: " + ds.Tables[0].Rows[i]["Name"]);
//                    Console.WriteLine("OD Limit: " + ds.Tables[0].Rows[i]["ODLimit"]);
//                    Console.WriteLine("Start Date: " + ds.Tables[0].Rows[i]["SStartDate"]);
//                    Console.WriteLine("End Date: " + ds.Tables[0].Rows[i]["SEndDate"]);
//                }
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("End of Program");
//                Console.ReadKey();
//            }
//        }
//    }
//}

// try with data reader
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace ConAppDisconnectedArch
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataAdapter adapter;
//        static DataSet ds;
//        static SqlDataReader reader;
//        static string conString = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day7DB;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                adapter = new SqlDataAdapter(cmd);
//                con.Open();
//                reader = cmd.ExecuteReader();
//                while (reader.Read())
//                {
//                    Console.WriteLine("ID: " + reader["Id"]);
//                    Console.WriteLine("Name: " + reader["Name"]);
//                    Console.WriteLine("OD Limit: " + reader["ODLimit"]);
//                    Console.WriteLine("Start Date: " + reader["SStartDate"]);
//                    Console.WriteLine("End Date: " + reader["SEndDate"]);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.WriteLine("End of Program");
//                Console.ReadKey();
//            }
//        }
//    }
//}

//inserting data into table
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace ConAppDisconnectedArch
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static string conString = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day7DB;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                con.Open();
//                cmd = new SqlCommand();
//                cmd.CommandText = "insert into Customer(Id,Name,ODLimit,SStartDate,SEndDate) values (@id,@name,@odlimit,@sd,@ed)";
//                cmd.Connection = con;
//                Console.WriteLine("Enter ID");
//                cmd.Parameters.AddWithValue("@id",int.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter Name");
//                cmd.Parameters.AddWithValue("@name", Console.ReadLine());
//                Console.WriteLine("Enter OD Limit");
//                cmd.Parameters.AddWithValue("@odlimit", float.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter Start Date");
//                cmd.Parameters.AddWithValue("@sd", DateTime.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter End Date");
//                cmd.Parameters.AddWithValue("@ed", DateTime.Parse(Console.ReadLine()));
//                cmd.ExecuteNonQuery();
//                Console.WriteLine("Added!!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("End of Program");
//                Console.ReadKey();
//            }
//        }
//    }
//}

////insering data into table using data adapter without using indexes
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;
//namespace conappdisconnectedarch
//{
//    internal class program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataAdapter adapter;
//        static DataSet ds;
//        static string conString = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day7DB;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                adapter = new SqlDataAdapter(cmd);
//                con.Open();
//                ds = new DataSet();
//                adapter.Fill(ds, "Customer");
//                DataTable dt = ds.Tables["Customer"]; //use table name to access datatable
//                DataRow dr = dt.NewRow();
//                Console.WriteLine("Enter Id");
//                dr["id"] = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Name");
//                dr["name"] = Console.ReadLine();
//                Console.WriteLine("Enter ODLimit");
//                dr["odlimit"] = float.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Start Date");
//                dr["SStartDate"] = DateTime.Parse(Console.ReadLine());
//                Console.WriteLine("Enter End Date");
//                dr["SEndDate"] = DateTime.Parse(Console.ReadLine());
//                dt.Rows.Add(dr);
//                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
//                adapter.Update(ds, "Customer");
//                Console.WriteLine("Added");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("End of Program");
//                Console.ReadKey();
//            }
//        }
//    }
//}

//inserting data into table using data adapter
//using indexes
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;
//namespace conappdisconnectedarch
//{
//    internal class program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataAdapter adapter;
//        static DataSet ds;
//        static string conString = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day7DB;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                adapter = new SqlDataAdapter(cmd);
//                con.Open();
//                ds = new DataSet();
//                adapter.Fill(ds);
//                DataTable dt = ds.Tables[0]; //use table name to access datatable
//                DataRow dr = dt.NewRow();
//                Console.WriteLine("Enter Id");
//                dr["id"] = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Name");
//                dr["name"] = Console.ReadLine();
//                Console.WriteLine("Enter ODLimit");
//                dr["odlimit"] = float.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Start Date");
//                dr["SStartDate"] = DateTime.Parse(Console.ReadLine());
//                Console.WriteLine("Enter End Date");
//                dr["SEndDate"] = DateTime.Parse(Console.ReadLine());
//                dt.Rows.Add(dr);
//                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
//                adapter.Update(ds);
//                Console.WriteLine("Added");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("End of Program");
//                Console.ReadKey();
//            }
//        }
//    }
//}

//deleting records using data adapter
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;
//namespace conappdisconnectedarch
//{
//    internal class program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataAdapter adapter;
//        static DataSet ds;
//        static string conString = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day7DB;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                adapter = new SqlDataAdapter(cmd);
//                con.Open();
//                ds = new DataSet();
//                adapter.Fill(ds);
//                DataTable dt = ds.Tables[0]; //use table name to access datatable
//                Console.WriteLine("Enter Customer Id to delete the record");
//                int cid = int.Parse(Console.ReadLine());
//                DataRow dr = null;
//                for (int i = 0; i < dt.Rows.Count; i++)
//                {
//                    if ((int)dt.Rows[i]["Id"] == cid)
//                    {
//                        dr = dt.Rows[i];
//                        break;
//                    }
//                }
//                if (dr != null)
//                {
//                    dr.Delete();
//                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
//                    adapter.Update(ds);
//                    Console.WriteLine("Record Deleted");
//                }
//                else
//                {
//                    Console.WriteLine("No such record exists");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("End of Program");
//                Console.ReadKey();
//            }
//        }
//    }
//}

//updating records using data adapter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace conappdisconnectedarch
{
    internal class program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataSet ds;
        static string conString = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=Day7DB;trusted_connection=true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conString);
                cmd = new SqlCommand("select * from Customer", con);
                adapter = new SqlDataAdapter(cmd);
                con.Open();
                ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0]; //use table name to access datatable
                Console.WriteLine("Enter Customer Id to update the record");
                int cid = int.Parse(Console.ReadLine());
                DataRow dr = null;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((int)dt.Rows[i]["Id"] == cid)
                    {
                        dr = dt.Rows[i];
                        break;
                    }
                }
                if (dr != null)
                {
                    Console.WriteLine("Enter the new Name");
                    dr["Name"] = Console.ReadLine();
                    Console.WriteLine("Enter the new OD Limit");
                    dr["ODLimit"] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the new Start Date");
                    dr["SStartDate"] = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the new End Date");
                    dr["SEndDate"] = DateTime.Parse(Console.ReadLine());
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);
                    Console.WriteLine("Record Updateed");
                }
                else
                {
                    Console.WriteLine("No such record exists");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
                Console.ReadKey();
            }
        }
    }
}