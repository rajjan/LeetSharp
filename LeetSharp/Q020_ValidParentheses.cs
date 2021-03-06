using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.

namespace LeetSharp
{
    [TestClass]
    public class Q020_ValidParentheses
    {
        public bool IsValid(string s)
        {
            return false;
        }

        public string SolveQuestion(string input)
        {
            return IsValid(input.Deserialize()).ToString().ToLower();
        }

        [TestMethod]
        public void Q020_Small()
        {
            TestHelper.Run(s => SolveQuestion(s));
        }
        [TestMethod]
        public void Q020_Large()
        {
            TestHelper.Run(s => SolveQuestion(s));
        }
    }
}
