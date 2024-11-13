namespace TypeSystemDemo
{
    public class Participants
    {
        string name;
        int employee_id;
        public Participants(string n, int emp)
        {
            this.name = n;
            this.employee_id = emp;
        }

        public override string? ToString()
        {
            return $"{this.employee_id}-{this.name}";
        }
    }
}