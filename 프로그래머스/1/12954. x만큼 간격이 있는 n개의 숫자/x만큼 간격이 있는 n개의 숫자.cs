public class Solution 
{
    public long[] solution(int x, int n) 
    {        
        long[] answer = new long[n];
        int sum = x;
        
        for(int i = 0; i < answer.Length; i ++)
        {
            answer[i] = (long)x * (i + 1);
                
                
        }
        return answer;                        
    }
}