public class Solution66
{

    public void Test()
    {
        int[] k = {7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6};
        Console.WriteLine(PlusOne(k));
    }

    public int[] PlusOne(int[] digits)
    {
        List<int> arr = new List<int>();
        string sum = "";
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
        }
        var k = System.Numerics.BigInteger.Parse(sum) + 1;

        foreach(var v in k.ToString())
        {
            arr.Add((int)Char.GetNumericValue(v));

        }
        return arr.ToArray();
    }
}