public class Solution7
{
        public int Reverse(int x) {
        int reverse = 0;
        while (x != 0)
        {
            int mod =  x % 10;
            x = x / 10;
            if (reverse > int.MaxValue/10 || (reverse == int.MaxValue / 10 && mod > 7)) return 0;
            if (reverse < int.MinValue/10 || (reverse == int.MinValue / 10 && mod > 7)) return 0;

            reverse = (reverse * 10) + mod;
        }
        
        return reverse;
    }
}