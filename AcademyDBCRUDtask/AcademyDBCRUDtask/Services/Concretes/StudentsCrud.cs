using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using AcademyDBCRUDtask.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AcademyDBCRUDtask.Services.Concretes
{
    public static class StudentsCrud
    {
        public static void InsertData(string command)
        {
           
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString.connectionString))
            {
                try {
                    sqlConnection.Open();
                    SqlCommand insertCommand = new SqlCommand(command, sqlConnection);


                    int result = insertCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("inserted");
                    }
                    else
                    {
                        Console.WriteLine("not inserted");
                    }
                    throw new Exception("Xeta bas verdi");
                }


                catch (SqlException ex) when (ex.Message.Contains("Invalid object name"))
                {
                    Console.WriteLine("Cədvəl adı yanlışdır: " + ex.Message);
                }

            }

        }
        public static void SelectData(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString.connectionString))
            {
                
                try {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                
                
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Console.WriteLine(item["Id"] + " " + item["FirstName"] + " " + item["LastName"] + " " + item["DataOfBirth"] + " " + item["Username"] + " " + item["Password"] + " " + item["EnrollmentDate"]);
                    }
                    
                }
                catch (SqlException ex) when (ex.Message.Contains("Invalid object name"))
                {
                    Console.WriteLine("Cədvəl adı yanlışdır: " + ex.Message);
                }


            }
        }
        public static void UpdateData(string command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString.connectionString))
            {
                
                try
                {
                    sqlConnection.Open();
                    SqlCommand updateCommand = new SqlCommand(command, sqlConnection);
                    int result = updateCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("updated");
                    }
                    else
                    {
                        Console.WriteLine("not updated");
                    }
                    throw new Exception("Xeta bas verdi");
                }
                catch (SqlException ex) when (ex.Message.Contains("Invalid object name"))
                {
                    Console.WriteLine("Cədvəl adı yanlışdır: " + ex.Message);
                }



            }
        }
        public static void DeleteData(string command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString.connectionString))
            {
                
                try
                {
                    sqlConnection.Open();
                    SqlCommand deleteCommand = new SqlCommand(command, sqlConnection);
                    int result = deleteCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("deleted");
                    }
                    else
                    {
                        Console.WriteLine("not delete");
                    }
                    throw new Exception("Xeta bas verdi");
                }
                catch (SqlException ex) when (ex.Message.Contains("Invalid object name"))
                {
                    Console.WriteLine("Cədvəl adı yanlışdır: " + ex.Message);
                }


            }
        }
       
    }
}

