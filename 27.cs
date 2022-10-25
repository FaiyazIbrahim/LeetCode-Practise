public class Solution27
{


    public void Test()
    {
        //int[] nums = {3,2,2,3};
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        Console.WriteLine(RemoveElement(nums, 2));
    }


    public int RemoveElement(int[] nums, int val)
    {
        int i = -1;

        for (int k = 0; k < nums.Length; k++)
        {
            if (nums[k] == val)
            {
                if (i == -1)
                {
                    i = k;
                }

            }
            else if (i != -1)
            {
                nums[i++] = nums[k];
            }

        }
        return i != -1 ? i : nums.Length;

    }
}