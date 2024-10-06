public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string str1 = "";
        string str2 = "";
        
        for(int i = 0 ; i < word1.Length ; i++)
        {
            str1 += word1[i];
        }
        
        for(int i = 0 ; i < word2.Length ; i++)
        {
            str2 += word2[i];
        }

        if (str1 != str2) return false;
        return true;
    }
}