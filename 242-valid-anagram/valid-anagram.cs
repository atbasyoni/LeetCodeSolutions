public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArr = s.ToArray();
        char[] tArr = t.ToArray();

        Array.Sort(sArr);
        Array.Sort(tArr);

        string newS = new string(sArr);
        string newT = new string(tArr);

        return newS.Equals(newT);
    }
}