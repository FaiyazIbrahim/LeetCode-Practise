public class Solution66
{

    public void Test()
    {
        int[] k = {9};
        PlusOne(k);
    }

    public int[] PlusOne(int[] digits)
    {
        List<int> arr = new List<int>();
        for(int i = 0; i < digits.Length - 1; i++)
        {
            arr.Add(digits[i]);
        }
        int k = digits[^1] + 1;
        if(k < 9)
        {
            arr.Add(k);
        }
        else
        {
            int a = k;
            int b = a / 10;
            int c = a % 10;
            arr.Add(b);
            arr.Add(c);
        }
        return arr.ToArray();
    }
}