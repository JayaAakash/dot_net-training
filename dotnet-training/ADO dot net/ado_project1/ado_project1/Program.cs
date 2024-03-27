
using System;
using System.Data;
using System.Data.SqlClient;

namespace ado_project1
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {

            SelectData();
            UpdateCustomer();
            //Deletecustomer();
            Console.Read();
        }
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=ICS-LT-841G3F3;initial catalog=test;" +
                "integrated security=true");
            con.Open();
            return con;
        }

        public static void SelectData()
        {
            con = getConnection();
            cmd = new SqlCommand("select * from customers");
            cmd.Connection = con;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("customer Name : " + dr["name"]);
                Console.WriteLine("customer age : " + dr["age"]);
                Console.WriteLine("customer Salary : " + dr["salary"]);

            }
        }
        //deleting data
        //public static void Deletecustomer()
        //{
        //    con = getConnection();
        //    Console.WriteLine("Enter Custid : "); 
        //    int custid = Convert.ToInt32(Console.ReadLine()); 

        //    cmd = new SqlCommand("select * from customer where custid=@cid");
        //    cmd.Parameters.AddWithValue("@cid", custid); 
        //    cmd.Connection = con;

        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        for (int i = 0; i < dr.FieldCount; i++)
        //        {
        //            Console.WriteLine(dr[i]);
        //        }
        //    }
        //    if (dr.HasRows)
        //    {
        //        Console.WriteLine("Are you sure to delete this customer ? Y/N");
        //        string answer = Console.ReadLine();
        //        if (answer == "y" || answer == "Y")
        //        {
        //            con.Close();
        //            SqlCommand cmd1 = new SqlCommand("delete from tblcustomer where custid=@cid", con); 
        //            cmd1.Parameters.AddWithValue("@eid", custid); 
        //            con.Open();
        //            int ctr = cmd1.ExecuteNonQuery();
        //            if (ctr > 0)
        //            {
        //                Console.WriteLine("Record Deleted Successfully..");
        //            }
        //            else
        //                Console.WriteLine("Could not delete..");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("customer with id {0} does not exist", custid);
        //    }
        //}
        // updating data
        public static void UpdateCustomer()
        {
            con = getConnection();
            Console.WriteLine("Enter Custid to update: ");
            int custid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter New Age: ");
            int newAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter New Salary: ");
            decimal newSalary = Convert.ToDecimal(Console.ReadLine());

            cmd = new SqlCommand("update customers set cname=@name, cage=@age, csalary=@salary where cid=@cid");
            cmd.Parameters.AddWithValue("@age", newAge);
            cmd.Parameters.AddWithValue("@salary", newSalary);
            cmd.Parameters.AddWithValue("@cid", custid);
            cmd.Connection = con;

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Customer details updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update customer details.");
            }
            con.Close(); 
        }
    }
}

