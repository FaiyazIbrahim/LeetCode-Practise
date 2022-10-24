public class Solution27{


    public void Test()
    {
        int[] nums = {0,1,2,2,3,0,4,2};
        int val = 2;
        int result = 0;

        for(int k = 0; k < nums.Length; k++)
        {
            if(nums[k] == val)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }


    // public int RemoveElement(int[] nums, int val)
    // {

    // }
}