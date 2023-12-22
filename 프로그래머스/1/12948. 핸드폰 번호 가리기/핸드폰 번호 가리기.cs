public class Solution 
{
    public string solution(string phone_number) 
    {
        string answer = "";
        
        if(phone_number == null || phone_number.Length < 4)
        {
            return phone_number;
        }
        
        string a = new string('*', phone_number.Length - 4);
        
        answer = a + phone_number.Substring(phone_number.Length - 4);
        
        return answer;
    }
}