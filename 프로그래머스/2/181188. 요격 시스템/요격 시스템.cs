using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] targets) {
        List<int[]> list = Enumerable.Range(0, targets.GetLength(0))
                                     .Select(i => new[] { targets[i, 0], targets[i, 1] })
                                     .OrderBy(x => x[0]).ToList();

        int interceptCount = 0;
        int shotPos = 0;

        for(int i = 0; i < list.Count; i++)
        {
            int[] curValue = list[i];
            int curStartPos = curValue[0];
            int curEndPos = curValue[1];

            if (curStartPos >= shotPos)
            {
                interceptCount++;
                shotPos = curEndPos;
            }
            else
            {
                shotPos = Math.Min(shotPos, curEndPos);
            }
        }
        return interceptCount;
    }
}