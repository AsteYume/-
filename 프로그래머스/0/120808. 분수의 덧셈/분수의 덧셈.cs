using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int x = numer1*denom2+numer2*denom1;
        int y = denom1*denom2;
        int z = -1;
        if (x<y)
            z = gcd(y,x);
        else
            z = gcd(x,y);
        int[] answer = {x/z,y/z};
        return answer; 
    }
    
    public int gcd (int i, int j)
    {
        if (j == 0)
        {
            return i;
        }
        else
        {
            return gcd(j,i%j);
        }
    }
    
}