
//Kadin Meyer
//4/7/2025


public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        List<char> list2 = new List<char>(t);
        for (int i = 0; i < s.Length; i++)
            list2.Remove(s[i]);
        return list2[0];
    }
}