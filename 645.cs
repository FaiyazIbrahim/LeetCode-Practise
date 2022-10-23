public class Problem645
{
    public void TestProgram()
    {
        int[] arr = { 1, 2, 2, 4};
        FindErrorNums(arr);
    }


    public int[] FindErrorNums(int[] nums) {
	var arr = new int[nums.Length+1];
	var d = -1;
	for(var i = 0; i < nums.Length; ++i){
		arr[nums[i]]++;
		// optimization
		if(arr[nums[i]]>1)
        {
            d = nums[i];
        }
	}
	for(var i = 1; i < arr.Length; ++i)
		//  missing
		if(arr[i] == 0)
        {
            Console.WriteLine(d + "  " + i);
            return new int[]{d, i};
        }
	return new int[2];
}
}