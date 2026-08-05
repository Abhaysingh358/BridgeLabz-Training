namespace HealthClinicApp.Entity
{
        public class Patient
        {   
        public int PatientId{get;set;}
        public string FirstName {get ; set;}
        public string  LastName {get;set;}

        public string  MedicalDescription {get; set;}
        public string DateOfBirth {get;set;}
        public string Gender {get;set;}

        public Patient(string firstName , string lastName , string medicalDescription , string dob ,string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            MedicalDescription = medicalDescription;
            DateOfBirth = dob;
            Gender = gender;

        }

        // Constructor  Overloaded is gonna  used for UPDATE & SELECT (ID required)
        public Patient(int patientId, string firstName, string lastName, string medicalDescription, string dateOfBirth, string gender)
        {
            PatientId = patientId;
            FirstName = firstName;
            LastName = lastName;
            MedicalDescription = medicalDescription;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"First Name :- {FirstName} ,Last Name :- {LastName} , MedicalDescription :- {MedicalDescription} ,DateOfBirth :- {DateOfBirth} , Gender:- {Gender}";
        }
        }

}
