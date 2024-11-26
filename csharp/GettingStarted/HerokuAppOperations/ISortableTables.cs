/*
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
*/
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
