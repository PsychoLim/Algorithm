using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public void SortAscending(List<int> list)
    {
        for(int i = 0;i < list.Count; i++)
        {
            for(int j = i + 1; j < list.Count; j++)
            {
                if(list[i] > list[j])
                {
                    int indexTemp = list[i];
                    list[i] = list[j];
                    list[j] = indexTemp;
                }              
            }
        }
    }
    
    public int[] solution(int[] arr, int divisor)
    {
        List<int> ints = new List<int>();
        
        foreach(int num in arr)
        {
            if(num % divisor == 0)
            {
                ints.Add(num);
            }
        }
        
        if(ints.Count == 0)
        {
            return new int[] {-1};
        }
        
        SortAscending(ints);
        
        return ints.ToArray();
    }       
}

