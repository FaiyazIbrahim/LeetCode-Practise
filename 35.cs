public class Solution35
{

    public void Test()
    {
        int[] arr1 = {1, 3, 5, 6};
        Console.WriteLine(SearchInsert(arr1,5));
    }


    public int SearchInsert(int[] nums, int target)
    {
        int i = 0, j = nums.Length - 1, k;
        while (i <= j)
        {
            k = (j + i) / 2;
            if (nums[k] < target) i = k + 1;
            else if (nums[k] > target) j = k - 1;
            else return k;
        }
        return i;
    }
}