using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int countEven = 0;
        int countOdd = 0;
        int[] answer = new int[] {countEven, countOdd};

        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                 countEven++;
            }
            else if (num_list[i] % 2 == 1)
            {
                 countOdd++;
            }
        }
        
        answer[0] = countEven;
        answer[1] = countOdd;
        
        return answer;
    }
}