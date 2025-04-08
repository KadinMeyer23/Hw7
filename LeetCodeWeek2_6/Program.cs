//Kadin Meyer
//4/8/2025

public class Solution
{
    public int CountSegments(string s)
    {
        int count = 1;
        if (s.Length == 0) { return 0; }
        if (s[0] == ' ') { count = 0; }

        for (int i = 0; i < s.Length - 1; i++)
        {

            if (s[i] == ' ' && s[i + 1] != ' ')
            {
                count += 1;
            }
        }
        return count;

    }
}