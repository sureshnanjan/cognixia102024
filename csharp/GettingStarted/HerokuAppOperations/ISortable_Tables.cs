using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HerokuAppOperations
{
    public  interface ISortable_Tables
    {
        //void SortByColumn(string columnName, bool ascending = true);
        //List<ITableRow> GetRows();
        void SortByColumn(string columnName, bool ascending = true);

        // Get the list of rows
        List<ITableRow> GetRows();

        // Row properties for table row (LastName, FirstName, Email, Due, Website, Actions)
        string LastName { get; set; }
        string FirstName { get; set; }
        string Email { get; set; }
        decimal Due { get; set; }
        string Website { get; set; }
        List<string> Actions { get; set; }
    }

    public interface ITableRow
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        string Email { get; set; }
        decimal Due { get; set; }
        string Website { get; set; }
        List<string> Actions { get; set; }
    }
}



