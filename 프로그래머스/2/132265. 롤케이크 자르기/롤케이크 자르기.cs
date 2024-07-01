using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;

        Dictionary<int, int> cakeA = new Dictionary<int, int>();
        Dictionary<int, int> cakeB = new Dictionary<int, int>();

        foreach (int item in topping)
        {
            if(cakeA.ContainsKey(item))
            {
                cakeA[item]++;
            }
            else
            {
                cakeA.Add(item, 1);
            }
        }

        for (int i = 0; i < topping.Length; i++)
        {
            int key = topping[i];

            if (!cakeB.ContainsKey(key))
            {
                cakeB.Add(topping[i], 1);
            }

            cakeA[key]--;

            if (cakeA[key] == 0)
                cakeA.Remove(key);

            if (cakeA.Count == cakeB.Count)
            {
                answer++;
            }
            else if (cakeA.Count < cakeB.Count)
            {
                break;
            }
        }

        return answer;
    }
}