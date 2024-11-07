namespace GettingStarted
{
   /// <summary>
   /// This is a class to represent training reports 
   /// </summary>
    internal class TrainingDashboard
    {
        // Fields
       private string _title;
       private string _description;
       private DateTime _current_date;
       //private string[] participants;
       private List<Participant> _tr_participants;

        // Operation
        public void Publish() {
            Console.WriteLine("This is the Data for Dashboard");
        }

        public TrainingDashboard(string title, string desc, List<Participant> tr_participantsList)
        {
            this._title = title;
            this._description = desc;
            this._current_date = DateTime.Now;
            this._tr_participants = tr_participantsList;

            //foreach (var item in _tr_participants.Split(","))
            //{
            //    this._tr_participants.Append(item);

            //}

            foreach (var participant in _tr_participants)  
            {
                Console.WriteLine(participant);  
            }

        }

       // public void Populate(string title, string desc, string participants) { }
        static void Main(string[] args)
        {
           // string trainername = "Suresh Nanjan";
            Console.WriteLine("Hello, World!");
            var participants = new List<Participant>
            {
                new Participant("", "","")
            };
            TrainingDashboard automationTraining = new TrainingDashboard("","",participants);
           // automationTraining.Populate();
            automationTraining.Publish();
        }
    }
}
