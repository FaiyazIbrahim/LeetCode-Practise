public class Solution268
{
    public void Test()
    {
        int[] arr = {3, 0 ,1};
        MissingNumber(arr);
    }
    public int MissingNumber(int[] nums) {
        int num = nums.Length + 1;
        int i = num * (num-1) / 2;
        int j = nums.Sum();
        return i - j;
    }
}