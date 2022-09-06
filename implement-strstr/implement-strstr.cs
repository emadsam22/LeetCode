public class Solution {
    public int StrStr(string haystack, string needle) 
    {
       int hayLength = haystack.Length;
        int needLength = needle.Length;
        int mainLength = hayLength - needLength+1;

        for (int i = 0; i < mainLength; i++)
        {
            string ans = haystack.Substring(i, needLength);
            if (ans == needle)
            {
                return i;
            }
        }

        return -1;

    }
}