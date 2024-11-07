namespace GettingStarted
{
    internal class Participant
    {
        //fields
        string employee_code;
        string fname;
        string lname;

        //constructor
        public Participant(string employeeCode, string firstName, string lastName)
        {
            EmployeeCode = employeeCode;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}