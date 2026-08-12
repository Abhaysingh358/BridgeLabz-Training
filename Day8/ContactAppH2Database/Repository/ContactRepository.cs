using System;
using System.Collections.Generic;
using System.Data.H2;
using ContactAppH2Database.Models;

namespace ContactAppH2Database.Repository
{
    public class ContactRepository
    {
        private readonly string _connectionString = "jdbc:h2:mem:ContactDb";
        private readonly H2Connection _connection;

        public ContactRepository()
        {
            _connection = new H2Connection(_connectionString);
            _connection.Open();
        }

        public void InitializeDatabase()
        {
            using var command = _connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Contacts (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    Name VARCHAR(255) NOT NULL,
                    Email VARCHAR(255),
                    Phone VARCHAR(50)
                );";
            command.ExecuteNonQuery();
        }

        public void Add(Contact contact)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO Contacts (Name, Email, Phone) VALUES (?, ?, ?)";
            command.Parameters.Add(new H2Parameter("Name", contact.Name));
            command.Parameters.Add(new H2Parameter("Email", contact.Email));
            command.Parameters.Add(new H2Parameter("Phone", contact.Phone));
            command.ExecuteNonQuery();
        }

        public List<Contact> GetAll()
        {
            var contacts = new List<Contact>();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Name, Email, Phone FROM Contacts";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                contacts.Add(new Contact
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Email = reader["Email"].ToString(),
                    Phone = reader["Phone"].ToString()
                });
            }
            return contacts;
        }

        public Contact GetById(int id)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Name, Email, Phone FROM Contacts WHERE Id = ?";
            command.Parameters.Add(new H2Parameter("Id", id));
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Contact
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Email = reader["Email"].ToString(),
                    Phone = reader["Phone"].ToString()
                };
            }
            return null;
        }

        public void Update(Contact contact)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE Contacts SET Name = ?, Email = ?, Phone = ? WHERE Id = ?";
            command.Parameters.Add(new H2Parameter("Name", contact.Name));
            command.Parameters.Add(new H2Parameter("Email", contact.Email));
            command.Parameters.Add(new H2Parameter("Phone", contact.Phone));
            command.Parameters.Add(new H2Parameter("Id", contact.Id));
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM Contacts WHERE Id = ?";
            command.Parameters.Add(new H2Parameter("Id", id));
            command.ExecuteNonQuery();
        }
    }
}