using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BridgeLabz.dbms_csharp_practice.scenario_based.AddressBookSystem
{
    // UC18 Database implementation using ADO.NET
    public class DatabaseDataSource : IDataSource
    {
        private string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public async Task WriteAsync(List<Contact> contacts, string addressBookName)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                await conn.OpenAsync();

                foreach (var contact in contacts)
                {
                    string query = @"INSERT INTO Contacts
                                    (FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email, BookName)
                                    VALUES
                                    (@FirstName,@LastName,@Address,@City,@State,@Zip,@Phone,@Email,@BookName)";

                    using SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                    cmd.Parameters.AddWithValue("@Address", contact.Address);
                    cmd.Parameters.AddWithValue("@City", contact.City);
                    cmd.Parameters.AddWithValue("@State", contact.State);
                    cmd.Parameters.AddWithValue("@Zip", contact.Zip);
                    cmd.Parameters.AddWithValue("@Phone", contact.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", contact.Email);
                    cmd.Parameters.AddWithValue("@BookName", addressBookName);

                    await cmd.ExecuteNonQueryAsync();
                }

                Console.WriteLine("Contacts Saved To Database Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task ReadAsync(string addressBookName)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                await conn.OpenAsync();

                string query = "SELECT * FROM Contacts WHERE BookName=@BookName";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookName", addressBookName);

                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Console.WriteLine(
                        $"{reader["FirstName"]}, {reader["LastName"]}, {reader["City"]}, {reader["PhoneNumber"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
