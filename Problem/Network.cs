using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    public class Network
    {
        public int solution(int n, int[,] computers)
        {
            int answer = 0;

            for(int i=0; i < n; i++)
            {
                if (computers[i, i] == 1 && dfs(i, computers))
                    answer++;
            }

            return answer;
        }

        public bool dfs(int current_idx, int[,] computers)
        {
            if (computers[current_idx, current_idx] == 0)
                return false;
            else
                computers[current_idx, current_idx] = 0;

            for(int i=0; i < computers.GetLength(1); i++)
            {
                if (computers[current_idx, i] == 1)
                    dfs(i, computers);
            }

            return true;
        }
    }
}
