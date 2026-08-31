using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        for (int a = 0; a<number.Length; a++)
        {
            for(int b=a+1; b<number.Length; b++)
            {
                for(int c=b+1; c<number.Length; c++)
                {
                    if (number[a]+number[b]+number[c] == 0)
                        answer++;
                }
            }
        }
        return answer;
        
        
        
        
        return answer;
    }
}