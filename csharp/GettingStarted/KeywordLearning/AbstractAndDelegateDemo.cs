using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public abstract class AbstractAndDelegateDemo
    {
        public const int MaxValue = 100;

        public abstract void ShowMessage();

        public delegate void ShowMessageDelegate(string message);

        public event ShowMessageDelegate? MessageReceived;

        public void TriggerEvent(string message)
        {
            MessageReceived?.Invoke(message);
        }

    }
}
