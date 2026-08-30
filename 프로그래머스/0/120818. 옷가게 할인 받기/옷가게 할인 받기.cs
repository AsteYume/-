using System;

public class Solution {
    public int solution(int price) {
        if (price >= 500000)
            return (price * 8) / 10;
        if (price >= 300000)
            return (price * 9) / 10;
        if (price >= 100000)
        {
            float price10 = price*19;
            int price20 = (int)(price10/20);
            return price20;
        }
        else
            return price;
    }
}