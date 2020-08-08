using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    public class Top
    {
        public int[] solution(int[] heights)
        {
            int[] answer = new int[heights.Length];

            for (int i = heights.Length - 1; i > -1; i--)
            {
                int current = heights[i];

                for(int j = i - 1; j > -1; j--)
                {
                    if(heights[j] > current)
                    {
                        answer[i] = j+1;
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
