public class Problem9  
{  

    public void TestProgram()
    {
        ReverseNumber();
    }

    private int ReverseNumber()
    {
       int  n, reverse=0, rem;           
       n = 54321;
       while(n!=0)      
       {      
        rem=n%10;        
        reverse=reverse*10+rem;      
        n/=10;      
       }      
       Console.Write("Reversed Number: "+reverse);
       return reverse;
    }
  }  