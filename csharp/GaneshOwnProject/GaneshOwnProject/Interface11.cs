using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaneshOwnProject
{
    // Custom Interface for Car
    public interface ICar
    {
        void StartEngine();
        void StopEngine();
    }

    // Custom Interface for Bike
    public interface IBike
    {
        void Pedal();
        void Brake();
    }

}
