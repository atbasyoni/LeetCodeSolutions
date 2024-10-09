public class Solution {
    public int MinAddToMakeValid(string s) {
        if (s.Length == 1)
            return 1;
            
        int n = 0, m = 0;
        
        for (int i = 0; i < s.Length ; i++)
        {
            if (s[i] == '(')
                n++;
            else if (n > 0)
                n--;
            else
                m++;
        }
        
        return n + m;
    }
}