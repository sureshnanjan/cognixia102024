namespace GettingStarted
{
    internal class Participant
    {
        string employee_code = "123FDASC015";
        string fname = "Linesh";
        string lname = "Mishra";

        public Participant(string employeeCode, string firstName, string lastName)
        {
            employee_code = employeeCode;
            fname = firstName;
            lname = lastName;
        }

        // Optionally, add a method to display the information
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee Code: {employee_code}, Name: {fname} {lname}");
        }
    }
}