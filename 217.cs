public class Solution217
{
    public void Test()
    {
        int[] arr = {1, 2, 3};
        Console.WriteLine(ContainsDuplicate(arr));
    }

    public bool ContainsDuplicate(int[] nums)
    {
        int number = 0;
        bool b = false;
        for(int i = 0 ; i < nums.Length; i++)
        {
            number = nums[i];
            for(int k = i + 1; k < nums.Length; k++)
            {
                if(number == nums[k])
                {
                    b = true;
                    return b;
                }
                else
                {
                    b = false;
                }
            }
        }
        return b;
    }
}