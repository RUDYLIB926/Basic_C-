using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrages(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrages(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "rudy";
            name = name.ToUpper();

            Assert.AreEqual("RUDY", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            {
                DateTime date = new DateTime(2015, 1, 1);
            
                date = date.AddDays(1);

                Assert.AreEqual(2, date.Day);
            }
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrememntNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrememntNumber(int number)
        {
            number += 1;
            number = 0;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            book1.NameChanged += OnNameChanged;
            book2.NameChanged += OnNameChanged;

            GiveBookAName(book2);
            Assert.AreNotEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.NameChanged += OnNameChanged;
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            g1.NameChanged += OnNameChanged;
            g1.Name = "Scott's grade book";
            GradeBook g2 = g1;
            g2.NameChanged += OnNameChanged;

            Assert.AreEqual(g1.Name, g2.Name);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
        }
    }
}
