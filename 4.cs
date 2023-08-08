public class Solution4
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] mergedArray = new int[nums1.Length + nums2.Length];
        double result = 0;
        Array.Copy(nums1, mergedArray, nums1.Length);
        Array.Copy(nums2, 0, mergedArray, nums1.Length, nums2.Length);
        BubbleSort(mergedArray);
        static void BubbleSort(int[] arr) {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (arr[j] > arr[j + 1]) {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        int arrayMiddle = mergedArray.Length / 2;
        if (mergedArray.Length % 2 == 0)
        {
            double k = (mergedArray[arrayMiddle - 1] + mergedArray[arrayMiddle]);
            result = k/2;
        }
        else
        {
            result = mergedArray[arrayMiddle];
        }

        return result;

    }
}