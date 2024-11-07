namespace GettingStarted
{
    internal class Participant
    {
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Participant(string employeeCode, string firstName, string lastName)
        {
            EmployeeCode = employeeCode ?? throw new ArgumentNullException(nameof(employeeCode));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} (Employee Code: {EmployeeCode})";
        }

    }
}