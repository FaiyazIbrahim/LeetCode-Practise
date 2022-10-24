public class Solution14
{
    public void RunTest()
    {
        string[] s = { "flight", "flow", "flower" };
        Console.WriteLine(LongestCommonPrefix(s));
    }
    
    public string LongestCommonPrefix(string[] strs)
    {
        string result = "";
        string shortest = strs.OrderBy(s => s.Length).First();

        if (strs.Length == 0) return result;

        for (int i = 0; i < shortest.Length; i++)
        {

            char c = shortest[i];
            foreach (var k in strs)
            {
                if (c != k[i])
                {
                    return result;
                }
            }

            result += c;
        }
        return result;
    }


}