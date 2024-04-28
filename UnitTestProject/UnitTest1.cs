using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Windows.Forms;
using ListRecommendations.Migrations;
using ListRecommendations.Models;
using WindowsFormsApp6;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            FavouritesForm favouriteForm = new FavouritesForm();

            // Act
            favouriteForm.LoadDataFromDatabase();

            // Assert
            Assert.IsNotNull(favouriteForm.dataGridView1.DataSource);
            Assert.IsInstanceOfType(favouriteForm.dataGridView1.DataSource, typeof(DataTable));
        }
    }
}
