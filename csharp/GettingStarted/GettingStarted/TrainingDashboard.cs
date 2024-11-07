namespace GettingStarted
{
   /// <summary>
   /// This is a class to represent training reports 
   /// </summary>
    internal class TrainingDashboard
    {
        // Fields
        string _title = "Something";
        string _description = "Something";
        DateTime _current_date = DateTime.Now;
        string[] participants = { "12", "32", "43", "35", "67","79", "10" };
        Participant[] tr_participants;

        // Operation
        public void Publish() {
            Console.WriteLine("This is the Data for Dashboard");
        }

        public TrainingDashboard(string title, string desc, string participants)
        {
            this._title = title;
            this._description = desc;
            this.tr_participants = new Participant[participants.Split(',').Length]; ;
            foreach (var item in participants.Split(","))
            {
                //this.participants.Append(item);
            }
            

        }

        public void Populate(string title, string desc, string participants) 
        {
            this._title = title;
            this._description = desc;
            this.participants = participants.Split(',');
        }
        static void Main(string[] args)
        {
            string trainername = "Suresh Nanjan";
            Console.WriteLine("Hello!! "+trainername);
            TrainingDashboard automationTraining = new TrainingDashboard("","","");
            automationTraining.Populate("","","");
            automationTraining.Publish();
        }
    }
}