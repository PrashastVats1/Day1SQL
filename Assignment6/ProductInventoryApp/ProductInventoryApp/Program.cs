using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductInventoryApp
{
    internal class Program
    {
        static SqlDataReader reader;
        static SqlCommand cmd;
        static SqlConnection con;
        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=ProductInventoryDb;trusted_connection=true;";
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                bool ch = false;
                while (!ch)
                {
                    Console.WriteLine("Product Inventory System");
                    Console.WriteLine("1. View Product Inventory");
                    Console.WriteLine("2. Add New Product");
                    Console.WriteLine("3. Update Product Quantity");
                    Console.WriteLine("4. Remove Product");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ViewProductInventory(con);
                            break;
                        case 2:
                            AddNewProduct(con);
                            break;
                        case 3:
                            UpdateProductQuantity(con);
                            break;
                        case 4:
                            RemoveProduct(con);
                            break;
                        case 5:
                            ch = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
        }
        static void ViewProductInventory(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from Products", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("ProductId\tProductName\tPrice\tQuantity\tMfDate\t\tExpDate");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["ProductId"]}\t\t{reader["ProductName"]}\t{reader["Price"]}\t" +
                    $"{reader["Quantity"]}\t\t{reader["MfDate"]}\t{reader["ExpDate"]}");
            }
            reader.Close();
        }
        static void AddNewProduct(SqlConnection con)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("insert into Products (ProductId, ProductName, Price, Quantity, MfDate, ExpDate) " +
                "values (@id, @name, @price, @quantity, @mfdate, @expdate)", con);
            Console.Write("Enter Product ID: ");
            cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
            Console.Write("Enter Product Name: ");
            cmd.Parameters.AddWithValue("@name", Console.ReadLine());
            Console.Write("Enter Price: ");
            cmd.Parameters.AddWithValue("@price", float.Parse(Console.ReadLine()));
            Console.Write("Enter Quantity: ");
            cmd.Parameters.AddWithValue("@quantity", int.Parse(Console.ReadLine()));
            Console.Write("Enter Manufacturing Date (mm/dd/yyyy): ");
            cmd.Parameters.AddWithValue("@mfdate", DateTime.Parse(Console.ReadLine()));
            Console.Write("Enter Expiry Date (mm/dd/yyyy): ");
            cmd.Parameters.AddWithValue("@expdate", DateTime.Parse(Console.ReadLine()));
            con.Open();
            int nor = cmd.ExecuteNonQuery();
            if (nor > 0)
            {
                Console.WriteLine("Product Inserted!!");
            }
        }
        static void UpdateProductQuantity(SqlConnection con)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("update Products set Quantity = @quantity where ProductId = @id", con);
            Console.Write("Enter Product ID: ");
            int id = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@id", id);
            Console.Write("Enter New Quantity: ");
            int newQuantity = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@quantity", newQuantity);
            con.Open();
            int nor = cmd.ExecuteNonQuery();
            if (nor > 0)
            {
                Console.WriteLine("Product Quantity Updated Successfully!!");
            }
            else
            {
                Console.WriteLine($"ID {id} is not present within the inventory");
            }
        }

        static void RemoveProduct(SqlConnection con)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("delete from Products where ProductId = @id", con);
            Console.Write("Enter Product ID: ");
            int id = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int nor = cmd.ExecuteNonQuery();
            if (nor > 0)
            {
                Console.WriteLine("Product removed from inventory!!");
            } 
        }
    }
}
