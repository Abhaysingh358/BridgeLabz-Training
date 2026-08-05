using System.Transactions;
using System.Data;
using HealthClinicApp.Entity;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Service
{
    public class PatientService
    {
        // Can not upload data connection string 
        private const string ConnectionString = "Server=;Database;Trusted_Connection;TrustServerCertificate;";
        public void AddPatient()
        {
            Console.WriteLine("Enter the First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the MedicalDescription");
            string medicalDescription = Console.ReadLine();
            Console.WriteLine("Enter the date of Birth(YYYY-MM-DD)");
            string dob = Console.ReadLine();
            Console.WriteLine("Enter the Gender(M/F/O)");
            string gender = Console.ReadLine();


            Patient patient= new Patient(firstName ,lastName ,medicalDescription ,dob ,gender);

            using(SqlConnection Connection = new SqlConnection(ConnectionString)){
            Connection.Open();

            using(SqlCommand cmd = new SqlCommand("SP_Patient_Insert" ,Connection)){

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
            cmd.Parameters.AddWithValue("@LastName", patient.LastName);
            cmd.Parameters.AddWithValue("@MedicalDescription", patient.MedicalDescription);
            cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", patient.Gender);

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine($"Affected Rows: {rowsAffected}");
            Console.WriteLine($"It will also show the affected audit table rows if you did not apply SET NOCOUNT");


            }
            }
        }

        public void UpdatePatient()
        {
            Console.WriteLine("Enter the PatientID");
            int patientId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the First Name");
            string newFirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            string newLastName = Console.ReadLine();
            Console.WriteLine("Enter the MedicalDescription");
            string newDescription = Console.ReadLine();
            Console.WriteLine("Enter the date of Birth(YYYY-MM-DD)");
            string newDob = Console.ReadLine();
            Console.WriteLine("Enter the Gender(M/F/O)");
            string newGender = Console.ReadLine();
            Patient patient = new Patient(patientId, newFirstName, newLastName, newDescription, newDob, newGender);
            using(SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();
                using(SqlCommand cmd = new SqlCommand("SP_Patient_Update", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientId", patient.PatientId);
                    cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                    cmd.Parameters.AddWithValue("@MedicalDescription", patient.MedicalDescription);
                    cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", patient.Gender);

                    int rowsAffected = cmd.ExecuteNonQuery();
                     if (rowsAffected > 0)
                        Console.WriteLine("Patient records updated successfully!");
                    else
                        Console.WriteLine(" No patient found with that ID.");
                }
            }
        }


            // Deleting Patient
            // Deleting a patient record using inline T-SQL
            public void DeletePatient()
            {
                int id = int.Parse(Console.ReadLine());

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();

                // 1. Direct inline delete targetting a specific row identifier
                string query = "DELETE FROM Patient WHERE PatientId = @id";

                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    // 2. The string "@id" here must perfectly match the token used in the query above
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Patient record deleted successfully!");
                            Console.WriteLine($"Affected Rows Total: {rowsAffected} (Including audit table rows)");
                        }
                        else
                        {
                            Console.WriteLine($"No patient was found with ID: {id}");
                        }
                    }
                    catch (SqlException ex)
                    {
                        // This catches foreign key blocks , if appointments exist for this patient
                        Console.WriteLine($"Cannot delete patient. Reason: {ex.Message}");
                    }
                }
            }
        }

        
    
    }
}