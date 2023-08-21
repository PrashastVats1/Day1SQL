using System;
using System.Data.SqlClient;
using System.Data;

namespace Assignment7UsingDataSetsForCRUD
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataSet ds;
        static string conStr = "server=LAPTOP-H3OMMTNN\\SQLEXPRESS;database=LibraryDb;trusted_connection=true;";
        public static DataSet RetrieveBooks()
        {
            SqlConnection connection = new SqlConnection(conStr);
            string query = "select * from Books";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "Books");
            return dataSet;

        }
        public static void DisplayBookInventory(DataSet dataSet)
        {
            DataTable booksTable = dataSet.Tables["Books"];
            foreach (DataRow dr in booksTable.Rows)
            {
                Console.WriteLine($"Book ID: {dr["BookId"]}");
                Console.WriteLine($"Title: {dr["Title"]}");
                Console.WriteLine($"Author: {dr["Author"]}");
                Console.WriteLine($"Genre: {dr["Genre"]}");
                Console.WriteLine($"Quantity: {dr["Quantity"]}");
            }
        }
        public static void AddNewBook(DataSet dataSet)
        {
            con = new SqlConnection(conStr);
            cmd = new SqlCommand("select * from Books", con);
            adapter = new SqlDataAdapter(cmd);
            con.Open();
            ds = new DataSet();
            adapter.Fill(ds, "Books");
            DataTable dt = ds.Tables["Books"]; //use table name to access datatable
            DataRow dr = dt.NewRow();
            Console.WriteLine("Enter Book Id");
            dr["BookId"] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book Title");
            dr["Title"] = Console.ReadLine();
            Console.WriteLine("Enter Book Author");
            dr["Author"] = Console.ReadLine();
            Console.WriteLine("Enter Book Genre");
            dr["Genre"] = Console.ReadLine();
            Console.WriteLine("Enter Quantity");
            dr["Quantity"] = int.Parse(Console.ReadLine());
            dt.Rows.Add(dr);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Books"); 
            Console.WriteLine("Added");
        }
        public static void UpdateBookQuantity(DataSet dataSet)
        {
            con = new SqlConnection(conStr);
            cmd = new SqlCommand("select * from Books", con);
            adapter = new SqlDataAdapter(cmd);
            con.Open();
            ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0]; //use table name to access datatable
            Console.WriteLine("Enter Book Title to update the quantity");
            string title = Console.ReadLine();
            DataRow dr = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Title"].ToString() == title)
                {
                    dr = dt.Rows[i];
                    break;
                }
            }
            if (dr != null)
            {
                Console.WriteLine("Enter the new QUantity");
                dr["Quantity"] = int.Parse(Console.ReadLine());
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds);
                Console.WriteLine("Record Updated");
            }
            else
            {
                Console.WriteLine("No such record exists");
            }
        }
        public static void DeleteBook(DataSet dataSet)
        {
            con = new SqlConnection(conStr);
            cmd = new SqlCommand("select * from Books", con);
            adapter = new SqlDataAdapter(cmd);
            con.Open();
            ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0]; //use table name to access datatable
            Console.WriteLine("Enter Book Id to delete the record");
            int bid = int.Parse(Console.ReadLine());
            DataRow dr = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((int)dt.Rows[i]["BookId"] == bid)
                {
                    dr = dt.Rows[i];
                    break;
                }
            }
            if (dr != null)
            {
                dr.Delete();
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds);
                Console.WriteLine("Record Deleted");
            }
            else
            {
                Console.WriteLine("No such record exists");
            }
        }
        private static void ApplyChangesToDatabase(DataSet dataSet)
        {
            SqlConnection connection = new SqlConnection(conStr);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", connection);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dataSet, "Books");
        }

        static void Main(string[] args)
        {
            DataSet libraryDataSet = RetrieveBooks();
            while (true)
            {
                try
                {
                    Console.WriteLine("Library Management System");
                    Console.WriteLine("1. Display Book Inventory");
                    Console.WriteLine("2. Add New Book");
                    Console.WriteLine("3. Update Book Quantity");
                    Console.WriteLine("4. Delete Book Record");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            DisplayBookInventory(libraryDataSet);
                            break;
                        case 2:
                            AddNewBook(libraryDataSet);
                            break;
                        case 3:
                            UpdateBookQuantity(libraryDataSet);
                            break;
                        case 4:
                            DeleteBook(libraryDataSet);
                            break;
                        case 5:
                            ApplyChangesToDatabase(libraryDataSet);
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error!!" + ex.Message);
                }
            }
        }
    }
}
