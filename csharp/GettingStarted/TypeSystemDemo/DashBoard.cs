using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public class DashBoard: IEnumerable<Participants>
    {
        string title;
        DateOnly start_date;
        DateOnly end_date;
        Participants[] participants;

        public DashBoard()
        {
            this.title = "QA Training";
            this.start_date = new DateOnly();
            this.end_date = new DateOnly();
            participants = new Participants[]{
                    new Participants("User1", 1),
                    new Participants("User2", 2),
                    new Participants("User3", 3),
                    new Participants("User4", 4)
                    };
        }

        public Participants this[int index] {
            get { return participants[index]; }
        }
        public IEnumerator GetEnumerator()
        {
            return participants.GetEnumerator();
        }

        IEnumerator<Participants> IEnumerable<Participants>.GetEnumerator()
        {
            return ((IEnumerable<Participants>)participants).GetEnumerator();
        }
    }
}
