internal class Employee
{
    // private data members
    private int EmployeeID;
    private string EmployeeName;
    private long EmployeePhone;
    private string EmailId;

    // getter and setter for employee id
    public int GetEmployeeID()
    {
        return EmployeeID;
    }

    public void SetEmployeeID(int employeeID)
    {
        EmployeeID = employeeID;
    }

    // getter and setter for employee name
    public string GetEmployeeName()
    {
        return EmployeeName;
    }

    public void SetEmployeeName(string employeeName)
    {
        EmployeeName = employeeName;
    }

    // getter and setter for phone number
    public long GetEmployeePhone()
    {
        return EmployeePhone;
    }

    public void SetEmployeePhone(long employeePhone)
    {
        EmployeePhone = employeePhone;
    }

    // getter and setter for email id
    public string GetEmailId()
    {
        return EmailId;
    }

    public void SetEmailId(string emailId)
    {
        EmailId = emailId;
    }

    // display employee details
    public override string ToString()
    {
        return $"EmployeeId : {EmployeeID}, Employee Name : {EmployeeName}" +
               $"\nPhone No. : {EmployeePhone}" +
               $"\nEmail Id : {EmailId}";
    }
}