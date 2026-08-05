namespace HealthClinicAPP.Entity
{
        public class Doctor
    {   
        // 
        // public int DoctorId {get;set;}
        public string FirstName {get ; set;}
        public string  LastName {get;set;}

        public string  Specialization {get; set;}

        // We can use blank constructor also even that is the better approach in which paramets are maaped dynamically but in para
        //metrized constructor you have to pass exact parametrs.
        public Doctor(string firstName , string lastName , string specialization)
        {
            FirstName = firstName;
            LastName = lastName;
            Specialization = specialization;
        }

        public override string ToString()
        {
            return $"First Name :- {FirstName} ,Last Name :- {LastName} , Specialization :- {Specialization}";
        }
       

    }
}