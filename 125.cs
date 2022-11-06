using System.Text;
public class Solution125
{

    public void Test()
    {
        string s = "A man, a plan, a canal: Panama";
        Console.WriteLine(IsPalindrome(s));
    }

    public bool IsPalindrome(string s)
    {
        List<string> k = new List<string>();
        //string rightString = "";
        StringBuilder rightString = new StringBuilder();
        foreach(var c in s)
        {
            
            if(char.IsLetter(c) || char.IsNumber(c))
            {
                k.Add(c.ToString());
                rightString.Append(c.ToString().ToLower());
            }
        }
        if(rightString.Length == 0) return true;
        //string reversedString = "";
        StringBuilder reversedString = new StringBuilder();
        for (int i = k.Count - 1; i > -1; i--)
        {
            reversedString.Append(k[i].ToLower());
        }
        Console.WriteLine("right " + rightString + " reverse " + reversedString + s.Length);
        return reversedString.ToString() == rightString.ToString() ? true : false;
    }
}