using System;

public class Solution {
    public int solution(int[] sides) {
        int sum = sides[0] + sides[1] + sides[2];
        foreach (int i in sides)
        {
            if ((sum-i)<=i)
                return 2;
        }
        return 1;
    }
    
    
}