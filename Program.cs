using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Program
    {
        static void Main(string[] args)
        {
            KthNumber quiz = new KthNumber();

            int[] param1 = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] param2 = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            int[] result = quiz.solution(param1, param2);

            Console.WriteLine(result);
        }
    }
}
