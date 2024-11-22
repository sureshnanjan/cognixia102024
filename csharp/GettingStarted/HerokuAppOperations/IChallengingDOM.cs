using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IChallengingDOM
    {
        public string GetPageTitle();

        // Method to get the count of rows in the table
        public int GetTableRowCount();

        // Method to click on an edit button for a specific row
        public void ClickEditButton(int rowIndex);

        // Method to click on a delete button for a specific row
        public void ClickDeleteButton(int rowIndex);
    }
}
