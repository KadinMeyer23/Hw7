//Kadin Meyer
//4/7/2025

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int j = 0;
        int i = 0;
        string final = "";

        while (i < word1.Length && j < word2.Length)
        {
            final += word1[i];
            final += word2[j];
            i++; j++;
        }

        while (j < word2.Length)
        {
            final += word2[j];
            j++;
        }
        while (i < word1.Length)
        {
            final += word1[i];
            i++;
        }

        return final;
    }
}