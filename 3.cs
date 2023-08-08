
public class Solution3
{
    public void test()
    {

    }

    public int LengthOfLongestSubstring(string s)
    {
        int count = 0;
        HashSet<char> charSet = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {
            charSet.Clear();
            for (int j = i; j < s.Length; j++)
            {
                if (!charSet.Contains(s[j]))
                {
                    charSet.Add(s[j]);
                    continue;
                }
                
                break;
            }

            if (count < charSet.Count)
            {
                count = charSet.Count;
            }
        }

        return count;
    }


}


