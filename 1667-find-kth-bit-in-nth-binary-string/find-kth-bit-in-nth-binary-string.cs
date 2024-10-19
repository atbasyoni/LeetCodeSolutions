public class Solution {
    public char FindKthBit(int n, int k) {
        string s = "0";

        for (int i = 1 ; i <= n ; i++)
        {
            s += "1" +  Reverse(Invert(s));
        }

        return s[k-1];
    }

    public string Invert(string s)
    {
        return s.Replace('0', 'X').Replace('1', '0').Replace('X', '1');
    }

    public string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}