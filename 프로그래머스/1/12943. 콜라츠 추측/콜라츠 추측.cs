public class Solution 
{
    public int solution(int num) 
    {
        int answer = 0;
        int tryCount = 0;
        long inputNum = num;
        if(num == 1) return 0;
        if(num == 0) return -1;
        
        while(inputNum != 1)
        {                   
            if(inputNum % 2 == 0)
            {
               inputNum /= 2;
            }
            else
            {
                inputNum = inputNum * 3 + 1;
            } 
            tryCount++;
        }        
        answer = (tryCount > 500) ? -1 : tryCount;
        return answer;
    }
}