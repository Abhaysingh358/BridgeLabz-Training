using System.Security.Cryptography.X509Certificates;
using HealthClinicAPP.Entity;
using Microsoft.Data.SqlClient;
namespace HealthClinicApp.Service
{
    public class DoctorService
    {
        // To use it , firs tyou should assign the value from your database to the connection string 
        private const string ConnectionString = "Server=;Database=;Trusted_Connection=;TrustServerCertificate=;";
        public void AddDoctor()
        {
            Console.WriteLine("ENter the First NAme");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the Specialization");
            string specialization = Console.ReadLine();

            Doctor doctor= new Doctor(firstName ,lastName ,specialization);

            using(SqlConnection Connection = new SqlConnection(ConnectionString)){
            Connection.Open();
            string query = "INSERT INTO Doctor (FirstName ,LastName , Specialization) VALUES (@FirstName ,@LastName , @Specialization)";

            SqlCommand cmd = new SqlCommand(query ,Connection);
            cmd.Parameters.AddWithValue("@FirstName" , doctor.FirstName);
            cmd.Parameters.AddWithValue("@LastName" ,doctor.LastName);
            cmd.Parameters.AddWithValue("@Specialization" ,doctor.Specialization);

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine($"[Affected Rows] : {rowsAffected}");
            Console.WriteLine($"It will also show the affected audit table rows if you did not apply SET NOCOUNT");


            }
        }

        // Updatng a doctor data
        public void UpdateDoctor()
        {
            Console.WriteLine("Enter the DoctorId");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the New FirstName");
            string newFirstName = Console.ReadLine();

            Console.WriteLine("Enter the New Last Name");
            string newLastName = Console.ReadLine();

            Console.WriteLine("Enter the new Specialization");
            string newSpecialization = Console.ReadLine();

            Doctor doctor  = new Doctor(newFirstName , newLastName , newSpecialization);

            using(SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();

                string query = "UPDATE Doctor SET FirstName = @newFirstName , LastName = @newLastName ,Specialization = @newSpecialization WHERE DoctorId = @id";
                using(SqlCommand cmd = new SqlCommand(query , Connection))
                {
                    // Map the ID Parameter to lookup the exact doctor record
                    cmd.Parameters.AddWithValue("@id" , id);

                    // rest will be assign doctor constructor object
                    cmd.Parameters.AddWithValue("@newFirstName" ,doctor.FirstName);
                    cmd.Parameters.AddWithValue("@newLastName" ,doctor.LastName);
                    cmd.Parameters.AddWithValue("@newSpecialization" ,doctor.Specialization);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if(rowsAffected > 0)
                    {
                        Console.WriteLine("Doctor's Details Modified Successfully");
                    }
                    else
                    {
                        Console.WriteLine("DoctorId Not Found");
                    }

                }
            }

        }


        // Deleting a Doctor
        // Doctor is Connected to Appointment table and if doctor has left some appointment session
        // then we should reject the appointment query for that try catch block is perfect
        public void DeleteDoctor()
        {
            Console.WriteLine("Enter the DoctorId");
            int id = int.Parse(Console.ReadLine());

            using(SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();
                string query = "DELETE FROM Doctor WHERE DoctorId = @id";
                using(SqlCommand cmd = new SqlCommand(query , Connection))
                {
                    cmd.Parameters.AddWithValue("@id" ,id);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                         if (rowsAffected > 0)
                        {
                            Console.WriteLine("Doctor record deleted successfully!");
                            Console.WriteLine($"Affected Rows : {rowsAffected} (Including  audit table)");
                         }
                        else
                        {
                            Console.WriteLine($"No doctor was found with ID: {id}");
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Doctor has some Booked Appointment");
                    }
                }
            }
        }


    }
}