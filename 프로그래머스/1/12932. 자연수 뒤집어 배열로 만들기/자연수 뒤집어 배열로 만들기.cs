public class Solution
{
    public int[] solution(long n)
    {
        string index = n.ToString();
        int[] answer = new int[index.Length];
                
        for (int i = 0; i < index.Length; i++)
        {
            if (n != 0)
            {
                answer[i] = (int)(n % 10);
                n /= 10;
            }
        }             
        return answer;
     }

}