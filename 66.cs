public class Solution66
{

    public void Test()
    {
        int[] k = {9,8,7,6,5,4,3,2,1,0};
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
        int k = int.Parse(sum) + 1;
        foreach(var v in k.ToString())
        {
            arr.Add((int)Char.GetNumericValue(v));
            Console.WriteLine(v);
            
        }
        return arr.ToArray();
    }
}