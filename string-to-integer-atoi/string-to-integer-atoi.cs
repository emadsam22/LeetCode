public class Solution {
    public int MyAtoi(string s) {
      long res = 0;
        int x = 1;
        s = s.Trim();
        if (string.IsNullOrEmpty(s)) return 0;
        int index = 0;
        if (s[0] == '+' || s[0] == '-')
        {
            if (s[0] == '+')
            {
                x = 1;
            }
            else
            {
                x = -1;
            }
            index++;
        }
        while (index < s.Length)
        {
            if (char.IsNumber(s[index]))
            {
                res = res * 10 + s[index] - '0';
                if (res * x > int.MaxValue) return int.MaxValue;
                if (res * x < int.MinValue) return int.MinValue;
            }
            else
            {
                break;
            }

            index++;
        }
        return (int)res * x;
    }
}