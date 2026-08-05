using System.Data;
using HealthClinicApp.Entity;
using Microsoft.Data.SqlClient;
namespace HealthClinicApp.Service
{
    public class AppointmentService
    {
        
        // To use it , firs tyou should assign the value from your database to the connection string
        private const string ConnectionString = "Server=;Database;Trusted_Connection;TrustServerCertificate;";

        public void CreateAppointment()
        {
             Console.WriteLine("Enter Doctor ID:");
            int doctorId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Patient ID:");
            int patientId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Appointment Date (YYYY-MM-DD):");
            DateTime appDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Time Slot (Like :--> HH:MM:SS / 14:30:00):");
            TimeSpan timeSlot = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Enter Symptoms:");
            string symptoms = Console.ReadLine();

            Console.WriteLine("Enter Status (Scheduled/Completed/Cancelled):");
            string status = Console.ReadLine() ?? "Scheduled";


             Appointment app = new Appointment(doctorId, patientId, appDate, timeSlot, symptoms, status);

             // in this service we will learn disconnected architecture
             // setup for disconnected architecture

             using(SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                // to fetch the schema from the database
                string query = "SELECT * FROM Appointment WHERE 1=0";
                using(SqlDataAdapter adapter = new SqlDataAdapter(query ,Connection))
                {

                    // 2. Build your specialized Stored Procedure command
                    SqlCommand insertcmd = new SqlCommand("sp_InsertAppointment", Connection);
                    insertcmd.CommandType = CommandType.StoredProcedure;

                    // 3. Map Stored Procedure inputs to column mapping strings inside your DataTable schema
                    insertcmd.Parameters.Add("@DoctorId", SqlDbType.Int, 0, "DoctorID");
                    insertcmd.Parameters.Add("@PatientId", SqlDbType.Int, 0, "PatientId");
                    insertcmd.Parameters.Add("@AppointmentDate", SqlDbType.Date, 0, "AppointmentDate");
                    insertcmd.Parameters.Add("@TimeSlot", SqlDbType.Time, 0, "TimeSlot");
                    insertcmd.Parameters.Add("@Symptoms", SqlDbType.VarChar, 400, "Symptoms");
                    insertcmd.Parameters.Add("@Status", SqlDbType.VarChar, 50, "Status");

                     // 4. Attach this customized command to the adapter
                    adapter.InsertCommand = insertcmd;

                     // 5. Initialize the local memory block
                    DataTable appointmentTable = new DataTable();
                    adapter.Fill(appointmentTable); // Connection opens & closes here instantly

                     // 6. Build the new row locally in memory
                    DataRow newRow = appointmentTable.NewRow();
                    newRow["DoctorID"] = doctorId;
                    newRow["PatientId"] = patientId;
                    newRow["AppointmentDate"] = appDate;
                    newRow["TimeSlot"] = timeSlot;
                    newRow["Symptoms"] = symptoms;
                    newRow["Status"] = status;

                    appointmentTable.Rows.Add(newRow);

                    // 7. Reconnect for a split second to fire off the Stored Procedure
                    int rowsAffected = adapter.Update(appointmentTable); // Connection opens & closes here automatically

                    Console.WriteLine($"Success! Stored Procedure fired via Adapter. Rows affected: {rowsAffected}");

                    
                }
            }



        }
    }
}