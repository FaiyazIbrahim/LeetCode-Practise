public class TwoPointer
{
    void TwoPointerSum()
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        int targerSum = 8;
        int pointerA = 0;
        int pointerB = array.Length - 1;
        
        
        while (pointerA < pointerB)
        {
            int sum = array[pointerA] + array[pointerB];
            if (targerSum > sum) pointerA++;
            if (targerSum < sum) pointerB--;
            if (targerSum == sum) break;
        }
    }
}