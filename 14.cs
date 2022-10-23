public class Solution14 {
    // public string LongestCommonPrefix(string[] strs) {
        
    // }

    public void Test()
    {
        string s = "Love";
        string p = string.Empty;

        foreach(char c in s)
        {
            p += c;
        }

        Console.WriteLine(p);
    }
}