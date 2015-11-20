using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{

    [TestClass]
    public class EvaluateTest
    {
        [TestMethod]
        public void EvaluateEnsureEvaluateInstance()
        {
            Evaluate newSession = new Evaluate();
            Assert.IsNotNull(newSession);
        }

        [TestMethod]
        public void EvaluateInputAddition()
        {
            string input = "7+8";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(15, newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputConstantAddition()
        {
            string input = "a+5";
            Constant constant = new Constant();
            constant.AddConstant('a', 1);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(6, newSession.EvaluateInput(input, constant));
        }

        [TestMethod]
        public void EvaluateInputSubtract()
        {
            string input = "7-8";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(-1, newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputConstantSubtract()
        {
            string input = "a-8";
            Constant constant = new Constant();
            constant.AddConstant('a', 7);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(2, newSession.EvaluateInput(input, constant));
        }

        [TestMethod]
        public void EvaluateInputMultiply()
        {
            string input = "1*8";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(8, newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputConstantMultiply()
        {
            string input = "a*8";
            Constant constant = new Constant();
            constant.AddConstant('a', 1);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(5, newSession.EvaluateInput(input, constant));
        }

        [TestMethod]
        public void EvaluateInputDivision()
        {
            string input = "10/2";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(5, newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputConstantDivision()
        {
            string input = "a/5";
            Constant constant = new Constant();
            constant.AddConstant('a', 10);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(2, newSession.EvaluateInput(input, constant));
        }

        [TestMethod]
        public void EvaluateInputModulo()
        {
            string input = "1%5";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(1, newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputConstantModulo()
        {
            string input = "a%5";
            Constant constant = new Constant();
            constant.AddConstant('a', 11);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(1, newSession.EvaluateInput(input, constant));
        }
    }
}