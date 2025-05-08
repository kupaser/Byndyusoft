using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;

namespace Solution.Test
{
    [TestClass]
    public sealed class Tests
    {
        [TestMethod]
        public void Methods_Function_ReturnsMinus10InNormalCase()
        {
            int[] temp = [4, 0, 3, 19, 492, -10, 1];
            var result = Function(temp);
            Console.WriteLine(result);
        }
    }
}
