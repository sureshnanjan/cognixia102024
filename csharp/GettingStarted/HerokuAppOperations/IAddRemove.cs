using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    // This interface defines the contract for adding and removing elements.
    public interface IAddRemove
    {
        // Method to get the title of the element.
        public string getTitle();

        // Method to add an element.
        public void AddElement();

        // Method to delete an element.
        public void DeleteElement();

        // Method to get the count of elements.
        public int GetCountofElements();
    }
}