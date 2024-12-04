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

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface representing operations that can be performed on sortable table pages.
    /// </summary>
    public interface ISortableTables
    {
        /// <summary>
        /// Gets the data from a specific cell in the table.
        /// </summary>
        /// <param name="rowIndex">The zero-based index of the row.</param>
        /// <param name="columnIndex">The zero-based index of the column.</param>
        /// <returns>A string representing the data at the specified row and column.</returns>
        string GetRowData(int rowIndex, int columnIndex);

        /// <summary>
        /// Gets the total number of rows in the table.
        /// </summary>
        /// <returns>The number of rows in the table.</returns>
        int GetRowCount();

        /// <summary>
        /// Gets the total number of columns in the table.
        /// </summary>
        /// <returns>The number of columns in the table.</returns>
        int GetColumnCount();

        /// <summary>
        /// Sorts the table by a specific column.
        /// </summary>
        /// <param name="columnIndex">The zero-based index of the column to sort by.</param>
        void SortByColumn(int columnIndex);
    }
}
