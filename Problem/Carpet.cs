using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    public class Carpet
    {
        public int[] solution(int brown, int yellow)
        {
            int[] answer = new int[2];

            int width = 0;
            int height = 0;

            for (int i = 1; i <= yellow/2 + 1; i++)
            {
                width = i;
                height = (yellow % i == 0) ? yellow / i : yellow / i + 1;

                if (width * 2 + height * 2 + 4 == brown)
                    break;
            }

            if (width >= height)
            {
                answer[0] = width + 2;
                answer[1] = height + 2;
            }
            else
            {
                answer[0] = height + 2;
                answer[1] = width + 2;
            }

            return answer;
        }
    }
}
