using System;
using System.Collections.Generic;  // Needed for List<T>
namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with sortable tables.
    /// Provides methods to sort tables by columns and retrieve table rows.
    /// </summary>
    public interface ISortableTables
    {
        /// <summary>
        /// Sorts the table by a specific column.
        /// </summary>
        /// <param name="columnName">The name of the column to sort by.</param>
        /// <param name="ascending">If true, sorts in ascending order; otherwise, sorts in descending order.</param>
        void SortByColumn(string columnName, bool ascending = true);

        /// <summary>
        /// Retrieves the list of rows in the table.
        /// </summary>
        /// <returns>A list of table rows.</returns>
        List<ITableRow> GetRows();
    }

    /// <summary>
    /// Interface representing a table row with properties for table data.
    /// </summary>
    public interface ITableRow
    {
        /// <summary>
        /// Gets or sets the last name of the individual.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Gets or sets the first name of the individual.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the individual.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Gets or sets the due amount for the individual.
        /// </summary>
        decimal Due { get; set; }

        /// <summary>
        /// Gets or sets the website URL of the individual.
        /// </summary>
        string Website { get; set; }

        /// <summary>
        /// Gets or sets the actions associated with the table row.
        /// </summary>
        List<string> Actions { get; set; }
    }
}
