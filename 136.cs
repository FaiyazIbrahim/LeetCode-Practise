public class Solution136
{
    public void Test()
    {
        int[] arr = {4,1,2,1,2};
        Console.WriteLine(SingleNumber(arr));
    }

    public int SingleNumber(int[] nums)
    {
        int singleNum = nums[0];
        for (int i = 1; i < nums.Length; i++) singleNum ^= nums[i];
        return singleNum;
    }
}