public class Solution {
    public int LengthOfLastWord(string s) {
        if (s.Length == 0)
            return 0;
        var words = s.Trim().Split(" ");
        return words[words.Length - 1].Length;
    }
}