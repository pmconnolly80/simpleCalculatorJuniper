using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ParseTests
    {
        [TestMethod]
        public void ParseEnsureCreateInstanceOfParse()
        {
            //Act
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.IsNotNull(parse);
        }

        [TestMethod]
        public void ParseEnsureGetFirstWorksWithSpaceBetween()
        {
            //Act
            string input = "7 + 7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("7", parse.GetFirst(input));
        }
        [TestMethod]
        public void ParseEnsureGetFirstWorksWithoutSpace()
        {
            //Act
            string input = "7+7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("7", parse.GetFirst(input));
        }
        [TestMethod]
        public void ParseEnsureGetFirstWorksWithNegativeIntegersAndSpaces()
        {
            //Act
            string input = "-7 + 7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("-7", parse.GetFirst(input));
        }
        [TestMethod]
        public void ParseEnsureGetFirstWorksWithNegativeIntegersNoSpaces()
        {
            //Act
            string input = "-7+7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("-7", parse.GetFirst(input));
        }
        [TestMethod]
        public void ParseEnsureGetFirstWorksWithConstantsNoSpaces()
        {
            //Act
            string input = "a+7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("a", parse.GetFirst(input));
        }

        [TestMethod]
        public void ParseEnsureGetFirstWorksWithConstantsSpaces()
        {
            //Act
            string input = "a + 7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("a", parse.GetFirst(input));
        }

        [TestMethod]
        public void ParseEnsureGetOperatorWorksWithSpaces()
        {
            //Act
            string input = "7 + 7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual('+', parse.GetOperator(input));
        }

        [TestMethod]
        public void ParseEnsureGetOperatorWorksWithoutSpaces()
        {
            //Act
            string input = "7+7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual('+', parse.GetOperator(input));
        }

        [TestMethod]
        public void ParseEnsureGetOperatorWorksWithNegativeIntegersSpaces()
        {
            //Act
            string input = "-7 + 7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual('+', parse.GetOperator(input));
        }

        [TestMethod]
        public void ParseEnsureGetOperatorWorksWithNegativeIntegersNoSpaces()
        {
            //Act
            string input = "-7+7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual('+', parse.GetOperator(input));
        }

        [TestMethod]
        public void ParseEnsureGetOperatorWorksWithConstantsNoSpaces()
        {
            //Act
            string input = "a+7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual('+', parse.GetOperator(input));
        }

        [TestMethod]
        public void ParseEnsureGetOperatorWorksWithConstantsSpaces()
        {
            //Act
            string input = "a + 7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual('+', parse.GetOperator(input));
        }

        [TestMethod]
        public void ParseEnsureGetSecondWorksWithSpaces()
        {
            //Act
            string input = "7 + 7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("7", parse.GetSecond(input));
        }

        [TestMethod]
        public void ParseEnsureGetSecondWorksWithoutSpaces()
        {
            //Act
            string input = "7+7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("7", parse.GetSecond(input));
        }

        [TestMethod]
        public void ParseEnsureGetSecondWorksWithNegativeIntegersSpaces()
        {
            //Act
            string input = "7 + -7";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("-7", parse.GetSecond(input));
        }

        [TestMethod]
        public void ParseEnsureGetSecondWorksWithNegativeIntegersNoSpaces()
        {
            //Act
            string input = "7+ -3";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("-3", parse.GetSecond(input));
        }

        [TestMethod]
        public void ParseEnsureGetSecondWorksWithConstantsNoSpaces()
        {
            //Act
            string input = "7+a";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("a", parse.GetSecond(input));
        }

        [TestMethod]
        public void ParseEnsureGetSecondWorksWithConstantsSpaces()
        {
            //Act
            string input = "7 + a";
            //Arrange
            Parse parse = new Parse();
            //Assert
            Assert.AreEqual("a", parse.GetSecond(input));
        }
    }
}
