public class Solution121
{
    public void Test()
    {
        int[] arr = {7,1,5,3,6,4};
        MaxProfit(arr);
    }
    public int MaxProfit(int[] prices)
    {
        int j = 0, k = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < k)
            {
                 k = prices[i];
            }
            else if (j < prices[i] - k)
            {
                j = prices[i] - k;
            }
        }
        return j;

    }
}