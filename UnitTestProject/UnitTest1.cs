using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programmers;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Network network = new Network();

            int n = 3;
            int[,] computers = { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } };

            int result = network.solution(n, computers);

            Console.WriteLine(result);
        }

        [TestMethod]
        public void CarpetTest()
        {
            Carpet carpet = new Carpet();

            int[] result = carpet.solution(10, 2);

            Console.WriteLine(string.Format("{0},{1}", result[0].ToString(), result[1].ToString()));
        }
    }
}
