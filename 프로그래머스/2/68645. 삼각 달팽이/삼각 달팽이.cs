using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        int[,] triangle = new int[n, n];
        int step = 0;
        int counter = 1;

        int x = -1;
        int y = 0;

        for(int i = 0; i < n; i++)
        {
            for(int k = 0; k < (n - i); k++)
            {
                switch (step)
                {
                    case 0:         //GO DOWN
                        triangle[++x, y] = counter;
                        break;

                    case 1:         //GO RIGHT
                        triangle[x, ++y] = counter;
                        break;

                    case 2:         //GO DIAGONAL
                        triangle[--x, --y] = counter;
                        break;
                }
                counter++;
            }

            step++;
            if (step == 3)
                step = 0;
        }

        int[] temp_answer = triangle.Cast<int>().ToArray();
        answer = temp_answer.Where(w => w != 0).ToArray();
        return answer;
    }
}