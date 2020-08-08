using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    public class KthNumber
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];

            for(int i=0; i < commands.GetLength(0); i++)
            {
                int start_index = commands[i, 0] - 1;
                int length = commands[i, 1] - start_index;
                int kth = commands[i, 2] - 1;

                int[] temp = new int[length];
                
                for(int j=0; j < length; j++)
                {
                    temp[j] = array[start_index++];
                }

                temp = temp.OrderBy(t => t).ToArray();

                answer[i] = temp[kth];
            }

            return answer;
        }
    }
}
