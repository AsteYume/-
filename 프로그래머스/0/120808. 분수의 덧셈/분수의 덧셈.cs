using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int x = numer1*denom2+numer2*denom1;
        int y = denom1*denom2;
        
        int a = x;
        int b = y;
        if (x<y)
        {
            a = y;
            b = x;
        }
        int c = -1;
        while (true)
        {
            c = a % b;
            if (c == 0)
            {
                break;
            }
            a = b;
            b = c;
        }
        int[] answer = {x/b,y/b};
        return answer; 
    }
}