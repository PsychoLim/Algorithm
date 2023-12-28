using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        int maxNum = 45;
        int count = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            count += numbers[i];
        }
        int answer = maxNum - count;
        return answer;
    }
}