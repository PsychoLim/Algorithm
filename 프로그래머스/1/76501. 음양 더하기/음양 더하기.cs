using System;

public class Solution 
{
    public int solution(int[] absolutes, bool[] signs) 
    {
        int answer = 0;
        if(absolutes.Length != signs.Length)
        {
            return 0;
        }
        
        for(int i = 0; i < absolutes.Length; i++)
        {
            if(signs[i])
            {
                
            }
            else
            {
                absolutes[i] = -absolutes[i];
            }
            
            answer += absolutes[i];
        }
        
        return answer;
    }
}