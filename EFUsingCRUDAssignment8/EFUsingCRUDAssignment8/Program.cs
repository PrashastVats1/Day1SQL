using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFUsingCRUDAssignment8
{
    internal class Program
    {
        static Assignment8DbEntities db;
        static Employee emps;
        static Product prds;
        static Order ords;
        static void Main(string[] args)
        {
            db = new Assignment8DbEntities();
            bool again = true;
            while (again)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Insert Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display Employee Details");
                Console.WriteLine("5. Insert Product");
                Console.WriteLine("6. Update Product");
                Console.WriteLine("7. Delete Product");
                Console.WriteLine("8. Display Product Details");
                Console.WriteLine("9. Insert Order");
                Console.WriteLine("10. Update Order");
                Console.WriteLine("11. Delete Order");
                Console.WriteLine("12. Display Order Details");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertEmployee(db);
                        break;
                    case 2:
                        UpdateEmployee(db);
                        break;
                    case 3:
                        DeleteEmployee(db);
                        break;
                    case 4:
                        DisplayEmployeeDetails(db);
                        break;
                    case 5:
                        InsertProduct(db);
                        break;
                    case 6:
                        UpdateProduct(db);
                        break;
                    case 7:
                        DeleteProduct(db);
                        break;
                    case 8:
                        DisplayProductDetails(db);
                        break;
                    case 9:
                        InsertOrder(db);
                        break;
                    case 10:
                        UpdateOrder(db);
                        break;
                    case 11:
                        DeleteOrder(db);
                        break;
                    case 12:
                        DisplayOrderDetails(db);
                        break;
                    case 0:
                        again = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
        static void InsertEmployee(Assignment8DbEntities db)
        {
            try
            {
                Employee emp = new Employee();
                Console.WriteLine("Enter Employee ID ");
                emp.EmployeeId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee First Name");
                emp.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Employee Last Name");
                emp.LastName = Console.ReadLine();
                Console.WriteLine("Enter Employee Date of Birth ");
                emp.BirthDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Salary");
                emp.Salary = decimal.Parse(Console.ReadLine());
                db.Employees.Add(emp);
                db.SaveChanges();
                Console.WriteLine("Employee Record Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void UpdateEmployee(Assignment8DbEntities db)
        {
            try
            {
                Console.WriteLine("Enter ID to update details");
                int id = int.Parse(Console.ReadLine());
                emps = db.Employees.SingleOrDefault(e => e.EmployeeId == id);
                if (emps == null)
                {
                    Console.WriteLine("No record with Id: " + id + " exists in the database");
                }
                else
                {
                    Console.WriteLine("Enter Employee First Name");
                    emps.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Last Name");
                    emps.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary ");
                    emps.Salary = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Employee Date of Birth ");
                    emps.BirthDate = DateTime.Parse(Console.ReadLine());
                    db.SaveChanges();
                    Console.WriteLine("Employee Record Updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void DeleteEmployee(Assignment8DbEntities db)
        {
            try
            {
                Console.WriteLine("Enter ID to delete the record");
                int id = int.Parse(Console.ReadLine());
                emps = db.Employees.SingleOrDefault(e => e.EmployeeId == id);
                if (emps == null)
                {
                    Console.WriteLine("No record with Id: " + id + " exists in the database");
                }
                else
                {
                    db.Employees.Remove(emps);
                    db.SaveChanges();
                    Console.WriteLine("Employee Record Deleted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void DisplayEmployeeDetails(Assignment8DbEntities db)
        {
            try
            {
                foreach (Employee e in db.Employees)
                {
                    Console.WriteLine("Employee ID: " + e.EmployeeId);
                    Console.WriteLine("Employee First Name: " + e.FirstName);
                    Console.WriteLine("Employee Last Name: " + e.LastName);
                    Console.WriteLine("Employee Birth Date: " + e.BirthDate);
                    Console.WriteLine("Employee Salary: " + e.Salary);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void InsertProduct(Assignment8DbEntities db)
        {
            try
            {
                Product prd = new Product();
                Console.WriteLine("Enter Product ID ");
                prd.ProductId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                prd.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Product Description");
                prd.Description = Console.ReadLine();
                Console.WriteLine("Enter Product Release Date ");
                prd.ReleaseDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Price");
                prd.Price = decimal.Parse(Console.ReadLine());
                db.Products.Add(prd);
                db.SaveChanges();
                Console.WriteLine("Product Record Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void UpdateProduct(Assignment8DbEntities db)
        {
            try
            {
                Console.WriteLine("Enter ID to update details");
                int id = int.Parse(Console.ReadLine());
                prds = db.Products.SingleOrDefault(p => p.ProductId == id);
                if (prds == null)
                {
                    Console.WriteLine("No record with Id: " + id + " exists in the database");
                }
                else
                {
                    Console.WriteLine("Enter Product Name");
                    prds.ProductName = Console.ReadLine();
                    Console.WriteLine("Enter Product Description");
                    prds.Description = Console.ReadLine();
                    Console.WriteLine("Enter Product Price ");
                    prds.Price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product Release Date ");
                    prds.ReleaseDate = DateTime.Parse(Console.ReadLine());
                    db.SaveChanges();
                    Console.WriteLine("Product Record Updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void DeleteProduct(Assignment8DbEntities db)
        {
            try
            {
                Console.WriteLine("Enter ID to delete the record");
                int id = int.Parse(Console.ReadLine());
                prds = db.Products.SingleOrDefault(p => p.ProductId == id);
                if (prds == null)
                {
                    Console.WriteLine("No record with Id: " + id + " exists in the database");
                }
                else
                {
                    db.Products.Remove(prds);
                    db.SaveChanges();
                    Console.WriteLine("Product Record Deleted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void DisplayProductDetails(Assignment8DbEntities db)
        {
            try
            {
                foreach (Product p in db.Products)
                {
                    Console.WriteLine("Product ID: " + p.ProductId);
                    Console.WriteLine("Product Name: " + p.ProductName);
                    Console.WriteLine("Product Description: " + p.Description);
                    Console.WriteLine("Product Release Date: " + p.ReleaseDate);
                    Console.WriteLine("Product Price: " + p.Price);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void InsertOrder(Assignment8DbEntities db)
        {
            try
            {
                Order ord = new Order();
                Console.WriteLine("Enter Order ID ");
                ord.OrderId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Date");
                ord.OrderDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Quantity");
                ord.Quantity = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Enter Oder Discount");
                ord.Discount = double.Parse(Console.ReadLine());
                Console.WriteLine("Has Order Been Shipped?");
                ord.IsShipped = Boolean.Parse(Console.ReadLine());
                db.Orders.Add(ord);
                db.SaveChanges();
                Console.WriteLine("Order Record Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void UpdateOrder(Assignment8DbEntities db)
        {
            try
            {
                Console.WriteLine("Enter ID to update details");
                int id = int.Parse(Console.ReadLine());
                ords = db.Orders.SingleOrDefault(o => o.OrderId == id);
                if (ords == null)
                {
                    Console.WriteLine("No record with Id: " + id + " exists in the database");
                }
                else
                {
                    Console.WriteLine("Enter Order Date");
                    ords.OrderDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order Quantity");
                    ords.Quantity = Int16.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Oder Discount");
                    ords.Discount = double.Parse(Console.ReadLine());
                    Console.WriteLine("Has Order Been Shipped?");
                    ords.IsShipped = Boolean.Parse(Console.ReadLine());
                    db.SaveChanges();
                    Console.WriteLine("Order Record Updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void DeleteOrder(Assignment8DbEntities db)
        {
            try
            {
                Console.WriteLine("Enter ID to delete the record");
                int id = int.Parse(Console.ReadLine());
                ords = db.Orders.SingleOrDefault(o => o.OrderId == id);
                if (ords == null)
                {
                    Console.WriteLine("No record with Id: " + id + " exists in the database");
                }
                else
                {
                    db.Orders.Remove(ords);
                    db.SaveChanges();
                    Console.WriteLine("Employee Record Deleted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
        static void DisplayOrderDetails(Assignment8DbEntities db)
        {
            try
            {
                foreach (Order o in db.Orders)
                {
                    Console.WriteLine("Order ID: " + o.OrderId);
                    Console.WriteLine("Order Date: " + o.OrderDate);
                    Console.WriteLine("Order Quantity: " + o.Quantity);
                    Console.WriteLine("Order Discount: " + o.Discount);
                    Console.WriteLine("Has the Order been shipped? " + o.IsShipped);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
        }
    }
}
