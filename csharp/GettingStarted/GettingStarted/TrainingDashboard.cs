namespace GettingStarted
{
   /// <summary>
   /// This is a class to represent training reports 
   /// </summary>
    internal class TrainingDashboard
    {
        // Fields
        string _title;
        string _description;
        DateTime _current_date;
        //string[] participants;
        Participant[] tr_participants;

        // Operation
        public void Publish() {
            Console.WriteLine("This is the Data for Dashboard");
        }

        public TrainingDashboard(string title, string desc, string participants)
        {
            this._title = title;
            this._description = desc;
            foreach (var item in participants.Split(","))
            {
                //this.participants.Append(item);
            }
            

        }

        public void Populate(string title, string desc, string participants) {
            _title = title;
            _description = desc;
            _
        }
        static void Main(string[] args)
        {
            string trainername = "Suresh Nanjan";
            Console.WriteLine("Hello, World!");
            TrainingDashboard automationTraining = new TrainingDashboard("","","");
            automationTraining.Populate();
            automationTraining.Publish();
        } 
    }
}
