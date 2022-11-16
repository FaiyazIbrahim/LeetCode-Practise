using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution206
{
    public void Test()
    {
        List<int> list = new List<int>(new int[] {
            4 , 5 , 6, 7
        });

        
        for (int i = list.Count; i > 0; i--)
        {
            Console.WriteLine(list[i]);
        }
        //ReverseList(list);
    }

    // public ListNode ReverseList(ListNode head)
    // {
    
    // }

    public void ReverseList(List<int> list)
    {
        for(int i = list.Count; i > 0; i--)
        {
            Console.WriteLine(list[i]);
        }
    }

    
}

public class ListNode
{
    public int i;
}