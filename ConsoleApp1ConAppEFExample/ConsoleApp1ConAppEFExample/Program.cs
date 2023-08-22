//Performing CRUD Operations

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1ConAppEFExample
//{
//    internal class Program
//    {
//        static Day8DbEntities db;
//        static void Main(string[] args)
//        {
//            try
//            {
//                db = new Day8DbEntities();
//                foreach(Emp e in db.Emps)
//                {
//                    Console.WriteLine("ID: " + e.Id);
//                    Console.WriteLine("First Name: " + e.Fname);
//                    Console.WriteLine("Last Name: " + e.Lname);
//                    Console.WriteLine("Designation: " + e.Designation);
//                    Console.WriteLine("Salary: " + e.Salary);
//                    Console.WriteLine("Date of Joining: " + e.DOJ);
//                    Console.WriteLine();
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                Console.ReadKey();
//            }
//        }
//    }
//}

//example of inserting a record
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1ConAppEFExample
//{
//    internal class Program
//    {
//        static Day8DbEntities db;
//        static void Main(string[] args)
//        {
//            try
//            {
//                db = new Day8DbEntities();
//                Emp emp = new Emp();
//                Console.WriteLine("Enter ID ");
//                emp.Id = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter First Name");
//                emp.Fname = Console.ReadLine();
//                Console.WriteLine("Enter Last Name");
//                emp.Lname = Console.ReadLine();
//                Console.WriteLine("Enter Designation");
//                emp.Designation = Console.ReadLine();
//                Console.WriteLine("Enter Salary ");
//                emp.Salary = double.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Date of Joining ");
//                emp.DOJ = DateTime.Parse(Console.ReadLine());
//                db.Emps.Add(emp);
//                db.SaveChanges();
//                Console.WriteLine("Employee Record Inserted");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                Console.ReadKey();
//            }
//        }
//    }
//}

////example of searching and updating a record
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1ConAppEFExample
//{
//    internal class Program
//    {
//        static Day8DbEntities db;
//        static Emp emp;
//        static void Main(string[] args)
//        {
//            try
//            {
//                db = new Day8DbEntities();
//                Console.WriteLine("Enter ID to update details");
//                int id = int.Parse(Console.ReadLine());
//                emp = db.Emps.SingleOrDefault(e=>e.Id == id);
//                if (emp == null)
//                {
//                    Console.WriteLine("No record with Id: " + id + " exists in the database");
//                }
//                else
//                {
//                    Console.WriteLine("Enter First Name");
//                    emp.Fname = Console.ReadLine();
//                    Console.WriteLine("Enter Last Name");
//                    emp.Lname = Console.ReadLine();
//                    Console.WriteLine("Enter Designation");
//                    emp.Designation = Console.ReadLine();
//                    Console.WriteLine("Enter Salary ");
//                    emp.Salary = double.Parse(Console.ReadLine());
//                    Console.WriteLine("Enter Date of Joining ");
//                    emp.DOJ = DateTime.Parse(Console.ReadLine());
//                    db.SaveChanges();
//                    Console.WriteLine("Employee Record Updated");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally
//            {
//                Console.ReadKey();
//            }
//        }
//    }
//}

//example of deleting a record
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ConAppEFExample
{
    internal class Program
    {
        static Day8DbEntities db;
        static Emp emp;
        static void Main(string[] args)
        {
            try
            {
                db = new Day8DbEntities();
                Console.WriteLine("Enter ID to delete the record");
                int id = int.Parse(Console.ReadLine());
                emp = db.Emps.SingleOrDefault(e => e.Id == id);
                if (emp == null)
                {
                    Console.WriteLine("No record with Id: " + id + " exists in the database");
                }
                else
                {
                    db.Emps.Remove(emp);
                    db.SaveChanges();
                    Console.WriteLine("Employee Record Deleted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

