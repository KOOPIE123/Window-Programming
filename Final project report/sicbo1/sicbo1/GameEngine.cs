using System;
using System.Collections.Generic;
using System.Linq;

namespace sicbo1
{
    public static class GameEngine
    {
        private static Random rand = new Random();

        public static int[] RollDice()
        {
            return new int[]
            {
                rand.Next(1, 7),
                rand.Next(1, 7),
                rand.Next(1, 7)
            };
        }

        // 下注規則對應表
        public static readonly Dictionary<string, Func<int[], int>> BetRules = new()
        {
            ["大 (Big) 賠率1:1"] = dice => {
                int sum = dice.Sum();
                return (sum >= 11 && sum <= 17 && !IsTriple(dice)) ? 2 : 0;
            },
            ["小 (Small) 賠率1:1"] = dice => {
                int sum = dice.Sum();
                return (sum >= 4 && sum <= 10 && !IsTriple(dice)) ? 2 : 0;
            },
            ["雙骰 1-1 賠率1:11"] = dice => dice.Count(d => d == 1) >= 2 ? 12 : 0,
            ["任意豹子 賠率1:30"] = dice => IsTriple(dice) ? 31 : 0,
            ["指定豹子 1-1-1 賠率1:180"] = dice => dice.All(d => d == 1) ? 181 : 0,
            ["總點 10 賠率1:6"] = dice => dice.Sum() == 10 ? 7 : 0,
            ["兩骰組合 2 和 3 賠率1:5"] = dice => (dice.Contains(2) && dice.Contains(3)) ? 6 : 0
        };

        public static int CalculatePayout(string betType, int[] dice)
        {
            if (BetRules.TryGetValue(betType, out var rule))
            {
                return rule(dice);
            }

            if (betType.StartsWith("單一點數 "))
            {
                string numberStr = betType.Split(' ')[2];
                if (int.TryParse(numberStr, out int number))
                {
                    int count = dice.Count(d => d == number);
                    return count + (count > 0 ? 1 : 0);  // 2~4 倍
                }
            }

            return 0;
        }

        private static bool IsTriple(int[] dice)
        {
            return dice[0] == dice[1] && dice[1] == dice[2];
        }
    }
}
