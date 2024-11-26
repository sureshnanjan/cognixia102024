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
using System.Collections.Generic;
using System.Linq;
using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{
    public class TableData : ISortableTables
    {
        public List<ITableRow> Rows { get; set; }

        // Constructor to initialize rows
        public TableData()
        {
            Rows = new List<ITableRow>
            {
                new TableRow { LastName = "Smith", FirstName = "John", Email = "jsmith@gmail.com", Due = 50.00m, Website = "http://www.jsmith.com", Actions = new List<string> { "edit", "delete" }},
                new TableRow { LastName = "Bach", FirstName = "Frank", Email = "fbach@yahoo.com", Due = 51.00m, Website = "http://www.frank.com", Actions = new List<string> { "edit", "delete" }},
                new TableRow { LastName = "Doe", FirstName = "Jason", Email = "jdoe@hotmail.com", Due = 100.00m, Website = "http://www.jdoe.com", Actions = new List<string> { "edit", "delete" }},
                new TableRow { LastName = "Conway", FirstName = "Tim", Email = "tconway@earthlink.net", Due = 50.00m, Website = "http://www.timconway.com", Actions = new List<string> { "edit", "delete" }}
            };
        }

        // Sort rows by a specific column
        public void SortByColumn(string columnName, bool ascending = true)
        {
            switch (columnName.ToLower())
            {
                case "lastname":
                    Rows = ascending ? Rows.OrderBy(row => row.LastName).ToList() : Rows.OrderByDescending(row => row.LastName).ToList();
                    break;
                case "firstname":
                    Rows = ascending ? Rows.OrderBy(row => row.FirstName).ToList() : Rows.OrderByDescending(row => row.FirstName).ToList();
                    break;
                case "email":
                    Rows = ascending ? Rows.OrderBy(row => row.Email).ToList() : Rows.OrderByDescending(row => row.Email).ToList();
                    break;
                case "due":
                    Rows = ascending ? Rows.OrderBy(row => row.Due).ToList() : Rows.OrderByDescending(row => row.Due).ToList();
                    break;
                case "website":
                    Rows = ascending ? Rows.OrderBy(row => row.Website).ToList() : Rows.OrderByDescending(row => row.Website).ToList();
                    break;
                default:
                    Console.WriteLine("Column not found!");
                    break;
            }
        }

        // Get the list of rows
        public List<ITableRow> GetRows()
        {
            return Rows;
        }
    }

    // Row properties for table row (explicitly implementing ITableRow)
    public class TableRow : ITableRow
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public decimal Due { get; set; }
        public string Website { get; set; }
        public List<string> Actions { get; set; }
    }
}
