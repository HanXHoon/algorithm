using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int start = commands[i,0] - 1;
            int end = commands[i, 1];
            int n = commands[i, 2];

            int length = end - start;

            int[] sliceArray = new int[length];
            Array.Copy(array, start, sliceArray, 0, length);
            int[] sortArray = sliceArray.OrderBy(x => x).ToArray();
            answer[i] = sortArray[n-1];
        }
        return answer;
    }
}