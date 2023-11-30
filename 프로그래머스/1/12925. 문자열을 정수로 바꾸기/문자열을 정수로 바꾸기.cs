public class Solution
{
   public int solution(string s)
   {
       int answer;
       bool isNum = int.TryParse(s,out answer);
 
       if (isNum && s[0].ToString() == "-")
       {
           s.TrimStart('-');
           answer = int.Parse(s); 
       }
       else if (isNum && s[0].ToString() == "+")
       {
           s.TrimStart('+');
           answer = int.Parse(s);
       }
       return answer;
    }
}