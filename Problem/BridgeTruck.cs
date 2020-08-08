using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    /// <summary>
    /// 다리를 지나는 트럭
    /// </summary>
    class BridgeTruck
    {
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;

            // 최대값
            int max_time = truck_weights.Length * bridge_length + 1;

            int[] moved_trucks = new int[truck_weights.Length];

            List<Truck> trucks = new List<Truck>();

            int next_truck_idx = 0;

            for (int time = 0; time < max_time; time++)
            {
                answer++;

                Truck[] truck_array = new Truck[trucks.Count];

                trucks.CopyTo(truck_array);

                foreach (Truck item in truck_array)
                {
                    item.remain_distance--;

                    if (item.remain_distance == 0)
                    {
                        moved_trucks[item.idx] = item.weight;
                        trucks.Remove(item);
                    }
                }

                if (next_truck_idx < truck_weights.Length)
                {
                    if (weight >= trucks.Select(t => t.weight).Sum() + truck_weights[next_truck_idx])
                    {
                        trucks.Add(new Truck { idx = next_truck_idx, remain_distance = bridge_length, weight = truck_weights[next_truck_idx] });

                        next_truck_idx++;
                    }
                }

                if (moved_trucks[moved_trucks.Length - 1] > 0)
                    break;
            }

            return answer;
        }

        public int another_solution(int bridge_length, int weight, int[] truck_weights)
        {
            Queue<int> que = new Queue<int>();
            int time = 0, count = 0, bridge = 0;

            while (count < truck_weights.Length)
            {
                if (que.Count == bridge_length)
                {
                    bridge -= que.Dequeue();
                }

                if (bridge + truck_weights[count] <= weight)
                {
                    bridge += truck_weights[count];
                    que.Enqueue(truck_weights[count]);
                    count++;
                }
                else
                {
                    que.Enqueue(0);
                }

                time++;
            }
            time += bridge_length;

            return time;
        }
    }

    public class Truck
    {
        public int idx;
        public int remain_distance;
        public int weight;
    }
}
