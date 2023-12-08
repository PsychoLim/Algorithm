public class Solution 
{
    public long solution(int a, int b) 
    {
        long answer = 0;
        
        if(a == b)
        {
            return (long)a;
        }
        
        if(b > a)
        {
            int tryint = b - a;
            for(int i = 0; i <=tryint; i++)
            {                
                answer += a;
                a++;
            }
        }
        else
        {
            int tryint = a - b;
            for(int i = 0; i <= tryint; i++)
            {                              
                answer += b;
                b++ ;
            }
        }
        
        return answer;
    }
}