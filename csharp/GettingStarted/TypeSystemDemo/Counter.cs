using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public delegate void ThresholdReachedEventHandler(object sender, ThresholdReachedEventArgs e);
    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
    public class Counter
    {
        public event ThresholdReachedEventHandler? ThresholdReached;

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            ThresholdReached?.Invoke(this, e);
        }

        public void FireEvent() {
            OnThresholdReached(new ThresholdReachedEventArgs { Threshold = 10, TimeReached = DateTime.Now });
        }

        // provide remaining implementation for the class
    }
}
