public class Solution1323
{
    public void Test()
    {
        int arr = 9669;
        Console.WriteLine(Maximum69Number(arr));
    }

    public int Maximum69Number(int num)
    {
        string s = num.ToString();
        char[] c = s.ToCharArray();
        string result = "" ;
        for(int i = 0; i < c.Length; i++)
        {
            if(c[i] == '6')
            {
                c[i] = '9';
                result += c[i].ToString();
                return int.Parse(c);
            }
            else
            {
                result += c[i].ToString();
            }
        }
        return int.Parse(result);
    }
}