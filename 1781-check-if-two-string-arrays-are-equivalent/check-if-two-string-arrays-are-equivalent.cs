public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string word1Str = string.Concat(word1);
        string word2Str = string.Concat(word2);

        return word1Str.Equals(word2Str);
    }
}