using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using WindowsFormsApp6;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var specificationsForm = new SpecificationsForm();

            DataGridView dataGriadView = specificationsForm.dataGridView1;

            Assert.IsNotNull(dataGriadView);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var favouriteForm = new FavouritesForm();

            DataGridView dataGridView = favouriteForm.dataGridView1;

            Assert.IsNotNull(dataGridView);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var compilatoinsForms = new CompilationsForm();

            DataGridView dataGridView = compilatoinsForms.dataGridView1;

            Assert.IsNotNull(dataGridView);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var compilatoinsForms = new CompilationsForm();

            DataGridView dataGridView = compilatoinsForms.dataGridView1;

            Assert.IsFalse(dataGridView.Columns.Contains("Название"));
            Assert.IsFalse(dataGridView.Columns.Contains("Описание"));

        }

        [TestMethod]

        public void TestMethod5()
        {

            var compilatoinsForms = new CompilationsForm();

            DataGridView dataGridView = compilatoinsForms.dataGridView1;

            Assert.AreEqual(0, dataGridView.Columns.Count);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var specificationsForm = new SpecificationsForm();

            DataGridView dataGridView = specificationsForm.dataGridView1;

            Assert.AreEqual(5, dataGridView.Columns.Count);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var favouriteForm = new FavouritesForm();

            DataGridView dataGridView = favouriteForm.dataGridView1;

            Assert.AreEqual(0, dataGridView.Columns.Count);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var specificationsForm = new SpecificationsForm();

            DataGridView dataGridView = specificationsForm.dataGridView1;

            Assert.IsTrue(dataGridView.Columns.Contains("Название"));
            Assert.IsTrue(dataGridView.Columns.Contains("Описание"));
            Assert.IsTrue(dataGridView.Columns.Contains("Продолжительность"));
            Assert.IsTrue(dataGridView.Columns.Contains("Бюджет"));
            Assert.IsTrue(dataGridView.Columns.Contains("Сезонность"));
        }

        [TestMethod]
        public void TestMethod9()
        {
            var favouriteForm = new FavouritesForm();

            DataGridView dataGridView = favouriteForm.dataGridView1;

            Assert.IsFalse(dataGridView.Columns.Contains("Название"));
            Assert.IsFalse(dataGridView.Columns.Contains("Описание"));
            Assert.IsFalse(dataGridView.Columns.Contains("Продолжительность"));
        }

        [TestMethod]
        public void TestMethod10()
        {
            var specificationsForm = new SpecificationsForm();

            DataGridView dataGridView = specificationsForm.dataGridView1;

            Assert.AreEqual("Название", dataGridView.Columns[0].HeaderText);
            Assert.AreEqual("Описание", dataGridView.Columns[1].HeaderText);
            Assert.AreEqual("Продолжительность", dataGridView.Columns[2].HeaderText);
            Assert.AreEqual("Бюджет", dataGridView.Columns[3].HeaderText);
            Assert.AreEqual("Сезонность", dataGridView.Columns[4].HeaderText);
        }
    }
}
