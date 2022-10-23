public class Solution9
{

    public void TestProgram()
    {
        Console.WriteLine(IsPalindrome(123));
    }

    public static bool IsPalindrome(int x)
    {
        int backW = 0;
        for (int i = x; i > 0; i /= 10)
        {
            backW = (backW * 10) + i % 10;
        }
        return x == backW;
    }
}