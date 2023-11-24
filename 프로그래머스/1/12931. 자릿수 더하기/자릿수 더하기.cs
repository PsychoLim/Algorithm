using System;

public class Solution 
{
    public int solution(int n) 
    {
        string strInt = n.ToString();
        int sum = 0;
        int answer = 0;
        foreach (char chr in strInt)
        {
            sum += int.Parse(chr.ToString());
            answer = sum;

        }
        Console.WriteLine(answer);
        return answer;
    }
}