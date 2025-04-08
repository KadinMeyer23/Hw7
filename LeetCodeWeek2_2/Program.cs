//Kadin Meyer
//4/7/2025

namespace LeetCodeWeek2_2
{
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int[] Location = new int[2];
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'R') { Location[0] += 1; }
                else if (moves[i] == 'L') { Location[0] -= 1; }

                if (moves[i] == 'U') { Location[1] += 1; }
                else if (moves[i] == 'D') { Location[1] -= 1; }
            }

            if (Location[0] == 0 && Location[1] == 0) { return true; }
            else { return false; }
        }
    }
}
