using System.Collections.Generic;
public class Solution26{


    public void Test()
    {
        //int[] arr1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int[] arr1 = {1, 1, 2};
        Console.WriteLine(RemoveDuplicates(arr1));

    }

    public int RemoveDuplicates(int[] nums)
    {

        int number = nums.Length;
        if (number < 2) return number;
        int i = 0;

        for (int j = 1; j < number; j++)
        {
            if (nums[i] != nums[j])
            {
                i++;
                nums[i] = nums[j];
            }

        }
        return i + 1;
    }



}