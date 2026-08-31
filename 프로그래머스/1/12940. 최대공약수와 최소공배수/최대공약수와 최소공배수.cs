public class Solution {
    public int[] solution(int n, int m)
    {
        int a = n;
        int b = m;
        if (n < m)
        {
            a = m;
            b = n;
        }
        int c = -1;
        while (c != 0)
        {
            c = a % b;
            a = b;
            b = c;
        }
        int[] answer = { a, (n * m) / a };
        return answer;
    }
}