public class Solution58
{
    public void Test()
    {
        string msg = "   fly me   to   the moon  ";
        Console.WriteLine(LengthOfLastWord(msg));
    }

    public int LengthOfLastWord(string s)
    {
        List<string> list = new List<string>();
        string p = "";
        foreach(var c in s)
        {
            if (Char.IsWhiteSpace(c))
            {
                if (p.Length > 0)
                {
                    //ignoring
                    p = "";
                }
            }
            else
            {
                //adding
                p += c;
                list.Add(p);
            }
            
        }
        return list[^1].Length;
    }
}