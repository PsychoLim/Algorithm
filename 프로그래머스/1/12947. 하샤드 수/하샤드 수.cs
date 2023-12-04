public class Solution 
{
    public bool solution(int x) 
    {
        string strInt = x.ToString();
        bool answer = true;
        int sum = 0;
        foreach(char chr in strInt)
        {
            sum += int.Parse(chr.ToString());
            
            if((x % sum) == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
        }                      
        return answer;
    }
}