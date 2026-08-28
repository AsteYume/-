using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int currunt = 0;
        for (int i = left; i<=right; i++)
        {
            currunt = 0;
            for (int j = 1; j<=i; j++)
            {
                if (i%j==0)
                {
                    currunt++;
                }
            }
            if (currunt%2==0)
            {
                answer += i;
            }
            else
            {
                answer -= i;
            }
        }
        
        
        return answer;
    }
}