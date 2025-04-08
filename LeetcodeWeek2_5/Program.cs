//Kadin Meyer
//4/8/2025

public class Solution
{
    public int FirstUniqChar(string s)
    {
        int answer = -1;
        int index = 0;

        for (int i = 0; i < s.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < s.Length; j++)
            {
                if (i != j && s[i] == s[j])
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
            {
                answer = i;
                return answer;
            }
        }

        return -1;
    }

}