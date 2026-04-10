using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3_23var;

namespace Lab3_23var.Tests
{
    [TestClass]
    public class StackAlgorithmTests
    {
        // ── Тест 1: корректная последовательность из круглых скобок ──
        [TestMethod]
        public void Stack_CorrectRoundBrackets_ReturnsTrue()
        {
            bool result = BracketChecker.CheckWithStack("(()())", out _);
            Assert.IsTrue(result);
        }

        // ── Тест 2: корректная смешанная последовательность ──
        [TestMethod]
        public void Stack_CorrectMixedBrackets_ReturnsTrue()
        {
            bool result = BracketChecker.CheckWithStack("{[()]}", out _);
            Assert.IsTrue(result);
        }

        // ── Тест 3: некорректная — закрывающая без открывающей ──
        [TestMethod]
        public void Stack_ExtraClosing_ReturnsFalse()
        {
            bool result = BracketChecker.CheckWithStack("())", out _);
            Assert.IsFalse(result);
        }

        // ── Тест 4: некорректная — несовпадающие типы ──
        [TestMethod]
        public void Stack_MismatchedTypes_ReturnsFalse()
        {
            bool result = BracketChecker.CheckWithStack("([)]", out _);
            Assert.IsFalse(result);
        }

        // ── Тест 5: пустая строка — корректна ──
        [TestMethod]
        public void Stack_EmptyString_ReturnsTrue()
        {
            bool result = BracketChecker.CheckWithStack("", out _);
            Assert.IsTrue(result);
        }

        // ── Тест 6: только открывающие — некорректна ──
        [TestMethod]
        public void Stack_OnlyOpening_ReturnsFalse()
        {
            bool result = BracketChecker.CheckWithStack("(((", out _);
            Assert.IsFalse(result);
        }

        // ── Тест 7: строка без скобок — корректна ──
        [TestMethod]
        public void Stack_NoBrackets_ReturnsTrue()
        {
            bool result = BracketChecker.CheckWithStack("hello world 123", out _);
            Assert.IsTrue(result);
        }

        // ── Тест 8: большой объём данных — 5000 пар ──
        [TestMethod]
        public void Stack_LargeInput_ReturnsTrue()
        {
            string input = new string('(', 5000) + new string(')', 5000);
            bool result = BracketChecker.CheckWithStack(input, out _);
            Assert.IsTrue(result);
        }

        // ── Тест 9: счётчик операций > 0 для непустой строки ──
        [TestMethod]
        public void Stack_OpsCountPositive()
        {
            BracketChecker.CheckWithStack("()", out long ops);
            Assert.IsTrue(ops > 0);
        }

        // ── Тест 10: одиночная открывающая — некорректна ──
        [TestMethod]
        public void Stack_SingleOpen_ReturnsFalse()
        {
            bool result = BracketChecker.CheckWithStack("(", out _);
            Assert.IsFalse(result);
        }
    }

    [TestClass]
    public class CounterAlgorithmTests
    {
        // ── Тест 1: корректная последовательность ──
        [TestMethod]
        public void Counter_CorrectSequence_ReturnsTrue()
        {
            bool result = BracketChecker.CheckWithCounter("(()())", out _);
            Assert.IsTrue(result);
        }

        // ── Тест 2: некорректная — закрывающая без открывающей ──
        [TestMethod]
        public void Counter_ExtraClosing_ReturnsFalse()
        {
            bool result = BracketChecker.CheckWithCounter("())", out _);
            Assert.IsFalse(result);
        }

        // ── Тест 3: пустая строка — корректна ──
        [TestMethod]
        public void Counter_EmptyString_ReturnsTrue()
        {
            bool result = BracketChecker.CheckWithCounter("", out _);
            Assert.IsTrue(result);
        }

        // ── Тест 4: только открывающие — некорректна ──
        [TestMethod]
        public void Counter_OnlyOpening_ReturnsFalse()
        {
            bool result = BracketChecker.CheckWithCounter("(((", out _);
            Assert.IsFalse(result);
        }

        // ── Тест 5: строка без скобок — корректна ──
        [TestMethod]
        public void Counter_NoBrackets_ReturnsTrue()
        {
            bool result = BracketChecker.CheckWithCounter("abc123", out _);
            Assert.IsTrue(result);
        }

        // ── Тест 6: большой объём данных — 5000 пар ──
        [TestMethod]
        public void Counter_LargeInput_ReturnsTrue()
        {
            string input = new string('(', 5000) + new string(')', 5000);
            bool result = BracketChecker.CheckWithCounter(input, out _);
            Assert.IsTrue(result);
        }

        // ── Тест 7: счётчик операций > 0 для непустой строки ──
        [TestMethod]
        public void Counter_OpsCountPositive()
        {
            BracketChecker.CheckWithCounter("()", out long ops);
            Assert.IsTrue(ops > 0);
        }

        // ── Тест 8: одиночная закрывающая — некорректна ──
        [TestMethod]
        public void Counter_SingleClose_ReturnsFalse()
        {
            bool result = BracketChecker.CheckWithCounter(")", out _);
            Assert.IsFalse(result);
        }

        // ── Тест 9: вложенные скобки ──
        [TestMethod]
        public void Counter_NestedBrackets_ReturnsTrue()
        {
            bool result = BracketChecker.CheckWithCounter("((()))", out _);
            Assert.IsTrue(result);
        }

        // ── Тест 10: счётчик операций для пустой строки ──
        [TestMethod]
        public void Counter_EmptyString_OpsIsOne()
        {
            BracketChecker.CheckWithCounter("", out long ops);
            // Только финальная проверка — 1 операция
            Assert.AreEqual(1L, ops);
        }
    }
}
