﻿namespace GettingStarted
{
    // Participant class to represent individual participant details
    internal class Participant
    {
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize the participant with data
        public Participant(string employeeCode, string firstName, string lastName)
        {
            EmployeeCode = employeeCode;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}