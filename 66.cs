public class Solution66
{

    public void Test()
    {
        int[] k = {1,2,3};
        PlusOne(k);
    }

    public int[] PlusOne(int[] digits)
    {
        int[] arr = new int[]{};
        int k = digits[^1] + 1;
   
        int a = 100;
        int b = a / 10;
        int c = a % 10;
        Console.WriteLine(b + " " + c);
        return arr;
    }
}