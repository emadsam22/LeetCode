public class Solution {
    public bool IsAnagram(string s, string t) {
         if (s.Length != t.Length) return false;
        Dictionary<char, int> check = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (check.ContainsKey(s[i]))
            {
                check[s[i]]++;
            }
            else
            {
                check.Add(s[i],1);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (check.ContainsKey(t[i]))
            {
                check[t[i]]--;
            }
        }

      
        foreach (var item in s)
        {
            if (check[item] != 0)
            {
                return false;
            }
        }
        return true;
    }
}