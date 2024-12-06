using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;

namespace HerokuAppWebdriverTests
{
    class SortableTableTest
    {
        SortableTables tables;
        [SetUp]
        public void SetUp()
        {
            tables = new SortableTables();
        }
        [Test]
        public void Test_GetRowData_ValidCell()
        {
            // Arrange
            int rowIndex = 3; // Second row (0-based index)
            int columnIndex = 3; // Third column (0-based index)

            // Act
            string cellData = tables.GetRowData(rowIndex, columnIndex);

            // Assert
            Assert.IsNotNull(cellData, "Cell data should not be null.");
            Assert.AreEqual("jdoe@hotmail.com", cellData, "The cell data does not match the expected value.");
        }

        [Test]
        public void Test_GetRowData_RowIndexOutOfRange()
        {
            // Arrange
            int invalidRowIndex = 10; // Exceeds the number of rows
            int columnIndex = 2;

            // Act & Assert
            var ex = Assert.Throws<NoSuchElementException>(() =>
            {
                tables.GetRowData(invalidRowIndex, columnIndex);
            });
            Assert.That(ex.Message, Does.Contain("Unable to locate element"));
        }

        [Test]
        //[Exception(typeof(ArgumentOutOfRangeException))]
        public void Test_GetRowData_ColumnIndexOutOfRange()
        {
            // Arrange
            int rowIndex = 1;
            int invalidColumnIndex = 10; // Exceeds the number of columns

            // Act & Assert
            var ex = Assert.Throws<NoSuchElementException>(() =>
            {
                tables.GetRowData(rowIndex, invalidColumnIndex);
            });
            Assert.That(ex.Message, Does.Contain("Unable to locate element"));
        }

        [Test]
        public void Test_GetRowCount()
        {
            // Act
            int rowCount = tables.GetRowCount();

            // Assert
            Assert.AreEqual(5, rowCount, "Row count should match the expected value (excluding header).");
        }

        [Test]
        public void Test_GetColumnCount()
        {
            // Act
            int columnCount = tables.GetColumnCount();

            // Assert
            Assert.AreEqual(6, columnCount, "Column count should match the expected number of columns.");
        }

        [Test]
        public void Test_SortByColumn()
        {
            // Arrange and Act
            // Sort by the first column
            String column = "Web Site";
            // Assert
            Assert.IsTrue(tables.SortByColumn(column), "false");
        }
        [TearDown]
        public void TearDown()
        {
            // Ensure the browser window is closed after each test
            tables.Quit();
        }
    }
    }