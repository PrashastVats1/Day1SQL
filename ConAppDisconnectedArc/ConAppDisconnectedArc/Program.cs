//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;

//namespace ConAppDisconnectedArc
//{
//    internal class Program
//    {
//        static SqlDataReader reader;
//        static SqlCommand cmd;
//        static SqlConnection con;
//        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=EmpsDb;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conStr);
//                cmd = new SqlCommand("select * from Emps", con);
//                con.Open();
//                reader = cmd.ExecuteReader();
//                Console.WriteLine("ID\tFirstName\tLastName\tSalary\tDesignation ");
//                while (reader.Read())
//                {
//                    Console.Write(reader["Id"] + "\t");
//                    Console.Write(reader["Fname"] + "\t\t");
//                    Console.Write(reader["Lname"] + "\t\t");
//                    Console.Write(reader["Salary"] + "\t\t");
//                    Console.Write(reader["Designation"] + "\t");
//                    Console.WriteLine("\n");
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
//inserting records
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace ConAppDisconnectedArc
//{
//    internal class Program
//    {
//        static SqlDataReader reader;
//        static SqlCommand cmd;
//        static SqlConnection con;
//        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=EmpsDb;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conStr);
//                cmd = new SqlCommand()
//                {
//                    CommandText = "Insert into Emps(Id, Fname, Lname, Salary, Designation) values (@id,@fn,@ln,@sal,@desg)",
//                    Connection = con
//                };
//                Console.WriteLine("Enter Employee ID");
//                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter Employee First Name");
//                cmd.Parameters.AddWithValue("@fn", Console.ReadLine());
//                Console.WriteLine("Enter Employee Last Name");
//                cmd.Parameters.AddWithValue("@ln", Console.ReadLine());
//                Console.WriteLine("Enter Employee Salary");
//                cmd.Parameters.AddWithValue("@sal", float.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter Employee Designation");
//                cmd.Parameters.AddWithValue("@desg", Console.ReadLine());
//                con.Open();
//                int nor=cmd.ExecuteNonQuery();
//                if (nor >= 1)
//                {
//                    Console.WriteLine("Record Inserted!!");
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

//deleting records
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace ConAppDisconnectedArc
//{
//    internal class Program
//    {
//        static SqlDataReader reader;
//        static SqlCommand cmd;
//        static SqlConnection con;
//        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=EmpsDb;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conStr);
//                cmd = new SqlCommand()
//                {
//                    CommandText = "Delete from Emps where Id = @id",
//                    Connection = con
//                };
//                Console.WriteLine("Enter Employee ID to delete");
//                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
//                con.Open();
//                int nor = cmd.ExecuteNonQuery();
//                if (nor >= 1)
//                {
//                    Console.WriteLine("Record Deleted!!");
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

//searching records
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace ConAppDisconnectedArc
//{
//    internal class Program
//    {
//        static SqlDataReader reader;
//        static SqlCommand cmd;
//        static SqlConnection con;
//        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=EmpsDb;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                int id;
//                Console.WriteLine("Enter ID to find its details");
//                id = int.Parse(Console.ReadLine());
//                con = new SqlConnection(conStr);
//                cmd = new SqlCommand()
//                {
//                    CommandText = "Select * from Emps where Id = @id",
//                    Connection = con
//                };
//                cmd.Parameters.AddWithValue("@id", id);
//                con.Open();
//                reader = cmd.ExecuteReader();
//                if (reader.HasRows)
//                {
//                    Console.WriteLine($"Record Found for ID: {id} and details are as follows");
//                    while (reader.Read())
//                    {
//                        Console.WriteLine("ID: \t" + reader["Id"]);
//                        Console.WriteLine("First Name: \t" + reader["Fname"]);
//                        Console.WriteLine("Last Name: \t" + reader["Lname"]);
//                        Console.WriteLine("Salary: \t" + reader["Salary"]);
//                        Console.WriteLine("Designation: \t" + reader["Designation"]);
//                    }
//                }
//                else
//                {
//                    Console.WriteLine($"ID {id} is not present within the database EmpsDb");
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

//search and update records
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace ConAppDisconnectedArc
//{
//    internal class Program
//    {
//        static SqlDataReader reader;
//        static SqlCommand cmd;
//        static SqlConnection con;
//        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=EmpsDb;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                int id;
//                Console.WriteLine("Enter ID to update its details");
//                id = int.Parse(Console.ReadLine());
//                con = new SqlConnection(conStr);
//                cmd = new SqlCommand()
//                {
//                    CommandText = "Select * from Emps where Id = @id",
//                    Connection = con
//                };
//                cmd.Parameters.AddWithValue("@id", id);
//                con.Open();
//                reader = cmd.ExecuteReader();
//                if (reader.HasRows)
//                {
//                    con.Close();
//                    con.Open();
//                    cmd.CommandText = "update Emps set Fname=@fn,Lname=@ln,Salary=@sal,Designation=@desg where Id=@eid";
//                    Console.WriteLine("Enter New First Name");
//                    cmd.Parameters.AddWithValue("@fn", Console.ReadLine());
//                    Console.WriteLine("Enter New Last Name");
//                    cmd.Parameters.AddWithValue("@ln", Console.ReadLine());
//                    Console.WriteLine("Enter New Salary");
//                    cmd.Parameters.AddWithValue("@sal", float.Parse(Console.ReadLine()));
//                    Console.WriteLine("Enter New Designation");
//                    cmd.Parameters.AddWithValue("@desg", Console.ReadLine());
//                    cmd.Parameters.AddWithValue("@eid", id);
//                    cmd.ExecuteNonQuery();
//                    Console.WriteLine("Record Updated!! ");
//                }
//                else
//                {
//                    Console.WriteLine($"ID {id} is not present within the database EmpsDb");
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

//Scalar Example
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace ConAppDisconnectedArc
//{
//    internal class Program
//    {
//        static SqlCommand cmd;
//        static SqlConnection con;
//        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=EmpsDb;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conStr);
//                cmd = new SqlCommand("select count(Id) from Emps",con);
//                con.Open();
//                Console.WriteLine("Number of Employees are: " + cmd.ExecuteScalar());
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

//Using switch cases for logical operations
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConAppDisconnectedArc
{
    internal class Program
    {
        static SqlCommand cmd;
        static SqlConnection con;
        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=EmpsDb;trusted_connection=true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conStr);
                cmd = new SqlCommand();
                Console.WriteLine("Enter your choice for: 1.Avg, 2.Max, 3.Min 4.Sum of Salary");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        cmd.CommandText = "select avg(Salary) from Emps";
                        break;
                    case 2:
                        cmd.CommandText = "select max(Salary) from Emps";
                        break;
                    case 3:
                        cmd.CommandText = "select min(Salary) from Emps";
                        break;
                    case 4:
                        cmd.CommandText = "select sum(Salary) from Emps";
                        break;
                    default:
                        Console.WriteLine("Invalid operation choice");
                        return;
                }
                cmd.Connection = con;
                con.Open();
                Console.WriteLine("Result: " + cmd.ExecuteScalar());
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