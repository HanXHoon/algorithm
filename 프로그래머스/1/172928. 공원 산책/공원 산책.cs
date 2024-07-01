using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        Dictionary<string, int[]> direction = new Dictionary<string, int[]>()
        {
            {"N", new int[] {-1,0}},
            {"S", new int[] {1,0}},
            {"E", new int[] {0,1}},
            {"W", new int[] {0,-1}},
        };

        int height = park.Length;
        int width = park[0].Length;

        int currentRow = Array.FindIndex(park, w => w.Contains("S"));
        int currentCol = park[currentRow].IndexOf("S");

        foreach (string route in routes)
        {
            string direction_str = route.Split(' ')[0];
            int move_amount = Convert.ToInt32(route.Split(' ')[1]);

            int AddRow = direction[direction_str][0];
            int AddCol = direction[direction_str][1];

            int i = 0;
            int nextRow = currentRow;
            int nextCol = currentCol;

            for (i = 0; i < move_amount; i++)
            {
                nextRow += AddRow;
                nextCol += AddCol;

                if (nextRow < 0 || nextRow >= height)
                    break;

                if (nextCol < 0 || nextCol >= width)
                    break;

                if (park[nextRow].Substring(nextCol, 1) == "X")
                    break;
            }

            if(i == move_amount)
            {
                currentRow = nextRow;
                currentCol = nextCol;
            }
        }
        return new int[] {currentRow, currentCol };
    }
}