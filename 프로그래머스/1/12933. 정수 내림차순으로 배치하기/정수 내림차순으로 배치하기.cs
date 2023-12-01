public class Solution
{
    public void Swap(ref int value1,ref int value2)
    {
        int temp = value1;
        value1 = value2;
        value2 = temp;
    }

    public long solution(long n)
    {
        string strN = n.ToString();
        int[] longsArr = new int[strN.Length];
        long answer = 0;

        for (int i = 0; i < strN.Length; i++)
        {
            longsArr[i] = int.Parse(strN[i].ToString());
        }

        for (int i = 0; i < longsArr.Length; i++)
        {
            int tmp = i;
            for (int j = i + 1; j < longsArr.Length; j++)
            {
                if (longsArr[tmp] <= longsArr[j])
                {
                    tmp = j;
                }
            }
            Swap(ref longsArr[i], ref longsArr[tmp]);

        }
        string combineArr = string.Join("", longsArr);
        answer = long.Parse(combineArr);                    
        return answer;
    }
}