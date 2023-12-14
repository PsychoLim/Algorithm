public class Solution 
{
    public string solution(string[] seoul)
    {
        string kim = "Kim";
        string answer = "";
        
        for(int i = 0; i < seoul.Length; i++)
        {
            if(kim == seoul[i])
            {
                answer = $"김서방은 {i}에 있다";
            }
        }
        return answer;
    }
}