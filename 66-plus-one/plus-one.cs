public class Solution {
    public int[] PlusOne(int[] digits) {
        int last = digits.Length - 1;
        if (digits[last] != 9)
        {
            ++digits[last];
            return digits;
        }
        else 
        {
            bool flag = true;

            for (int i = last ; i >= 0 ; i--)
            {
                if (digits[i] == 9 && flag)
                {
                    digits[i] = 0;
                    flag = true;
                }
                else if(flag)
                {
                    digits[i] += 1;
                    flag = false;
                }
            }

            if (flag)
            {
                int[] newDigits = new int[last + 2];
                newDigits[0] = 1;
                return newDigits;
            }

            return digits;
        }
    }
}