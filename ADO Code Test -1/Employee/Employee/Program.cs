using System;
using System.Data;
using System.Data.SqlClient;


namespace Employee
{
    class Program
    {
        //sql database connection
        private static string connectionString = "Server=ICS-LT-841G3F3;Database=Employeemanagement;Integrated Security=True;";

        static void Main(string[] args)
        {
            InsertEmployeeDetails("Banu Rekha", 45000, 'P');
            DisplayEmployeeDetails();

            Console.ReadLine();
        }

        //creating store proc
        static void CreateStoredProcedure()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddEmployee]') AND type in (N'P', N'PC'))
                    BEGIN
                        EXEC ('CREATE PROCEDURE AddEmployee
                            @EmpName VARCHAR(50),
                            @Empsal NUMERIC(10,2),
                            @Emptype CHAR(1)
                        AS
                        BEGIN
                            DECLARE @Empno INT;
 
                            -- Generate Empno
                            SELECT @Empno = ISNULL(MAX(Empno), 0) + 1 FROM Employee_Details;
 
                            -- Insert into Employee_Details table
                            INSERT INTO Employee_Details (Empno, EmpName, Empsal, Emptype)
                            VALUES (@Empno, @EmpName, @Empsal, @Emptype);
                        END;')
                    END";
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating stored procedure: " + ex.Message);
            }
        }

        static void InsertEmployeeDetails(string empName, decimal empsal, char emptype)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("AddEmployeeDetails", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmpName", empName);
                command.Parameters.AddWithValue("@Empsal", empsal);
                command.Parameters.AddWithValue("@Emptype", emptype);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        //displaying employees
        static void DisplayEmployeeDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Employee_Details", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Empno: {reader["Empno"]}, EmpName: {reader["EmpName"]}, Empsal: {reader["Empsal"]}, Emptype: {reader["Emptype"]}");
                }
               
            }
        }
    }
}