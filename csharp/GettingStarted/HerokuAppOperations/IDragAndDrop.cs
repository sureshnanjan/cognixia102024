using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface IDragandDrop
    {
        // Gets the current text or label of the first draggable square (A).
        string GetSquareAText();

        // Gets the current text or label of the second draggable square (B).
        string GetSquareBText();

        // Performs a drag-and-drop action from square A to square B.
        void DragAToB();

        // Performs a drag-and-drop action from square B to square A.
        void DragBToA();

        // Verifies if the drag-and-drop operation swapped the contents of square A and square B.
        bool IsSwapSuccessful();
    }
}
