public class Solution11
{
    public int MaxArea(int[] height) {
        
        int i = 0;
        int j = height.Length - 1;
        int tempMax = 0;
        int maxArea = 0;
        int heighti;
        int heightj;

        while (j > i)
        {
            heighti = height[i];
            heightj = height[j];

            if (heighti > heightj)
            {
                tempMax = heightj * (j - i);
                j--;
            }
            else
            {
                tempMax = heighti * (j - i);
                i++;
            }

            if (tempMax > maxArea)
            {
                maxArea = tempMax;
            }
            
        }

        return maxArea;
    }
}