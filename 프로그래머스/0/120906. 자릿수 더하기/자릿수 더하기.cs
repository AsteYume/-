using System;

public class Solution {
    public int solution(int n) {
        string a = $"{n}";
        int answer = 0;
        foreach (int i in a)
            answer += i-48;
        return answer;
    }
}