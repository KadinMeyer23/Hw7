//Kadin Meyer
//4/7/2025


namespace LeetCodeWeek2_1
{
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            int[] balloon_count = new int[5];

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'b' || text[i] == 'B')
                { balloon_count[0] += 1; }
                else if (text[i] == 'a' || text[i] == 'A')
                { balloon_count[1] += 1; }
                else if (text[i] == 'l' || text[i] == 'L')
                { balloon_count[2] += 1; }
                else if (text[i] == 'o' || text[i] == 'O')
                { balloon_count[3] += 1; }
                else if (text[i] == 'n' || text[i] == 'N')
                { balloon_count[4] += 1; }
            }

            balloon_count[2] = balloon_count[2] / 2;
            balloon_count[3] = balloon_count[3] / 2;

            Array.Sort(balloon_count);
            return balloon_count[0];
        }
    }
}
