using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] picks, string[] minerals) {
        int fatigueResult = 0;
        int[] pickaxeUsage = { 0, 0, 0 };
        string[] pickaxeMaterial = { "diamond", "iron", "stone" };

        //광물 및 곡괭이 재질 점수 딕셔너리
        Dictionary<string, int> materialScores = new Dictionary<string, int>
        {
            {"diamond", 25},
            {"iron", 5},
            {"stone", 1}
        };

        //광물 5개씩 그룹핑
        int lengthLimit = Math.Min(picks.Sum() * 5, minerals.Length);
        string[][] mineralGroups = minerals.Take(lengthLimit)
                                            .Select((value, index) => new { value, index })
                                            .GroupBy(x => x.index / 5).Select(g => g.Select(x => x.value).ToArray())
                                            .ToArray();

        //한 그룹의 가중치 점수 및 랭킹 매기기
        int[] mineralScore = mineralGroups.Select(s => s.Sum(mineral => materialScores[mineral])).ToArray();
        int[] mineralRanking = mineralScore.Select(score => mineralScore.Count(w => w > score) + 1).ToArray();

        //광물 그룹 탐색
        //가장 마지막 그룹의 멤버가 5개가 아니고, 우선순위가 1순위 일 수도 있기 때문에 역순으로 탐색
        for(int i = mineralGroups.Length - 1; i >= 0; i--)
        {
            string miningMineral = "";
            int picksAmount = 0;
            string currentPickaxe = "";

            //사용할 곡괭이 구하기
            //picks는 [diamond, iron, stone] 순서기 때문에, picksAmount가 높아질수록 더 안좋은 곡괭이를 사용
            //곡괭이 갯수와 현재 사용한 갯수를 따져 알맞은 곡괭이를 꺼냅니다.
            for (int k = 0; k < 3; k++)
            {
                picksAmount += picks[k];
                if ((mineralRanking[i] <= picksAmount) && ((picks[k] - pickaxeUsage[k]) != 0))
                {
                    currentPickaxe = pickaxeMaterial[k];
                    pickaxeUsage[k]++;
                    break;
                }
            }

            //곡괭이로 광물 캐기
            //광물이름을 Key로 사용하도록 딕셔너리를 이용합니다.
            for (int m = 0; m < mineralGroups[i].Length; m++)
            {
                if (currentPickaxe == "")
                    break;

                miningMineral = mineralGroups[i][m];

                double tempFatigue = (double)materialScores[miningMineral] / materialScores[currentPickaxe];
                fatigueResult += (int)Math.Ceiling(tempFatigue);
            }
        }
        return fatigueResult;
    }
}