using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        int denom = denom1*denom2;
        int numer = (numer1*denom2) + (numer2*denom1);
        int temp = 1;

        for (int i = 1; i <= denom; i++)
        {
            if (denom % i == 0 && numer % i == 0)
            {
                temp = i;
            }
        }

        answer[0] = numer/temp;
        answer[1] = denom/temp;
        
        return answer;
    }
}