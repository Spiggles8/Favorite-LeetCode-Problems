//13. Roman to Integer C# Solution on (02/23/2023)
public class CSharp_Solution {
    char[] symbols = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};
    int[] values = {1, 5, 10, 50, 100, 500, 1000};

    public int RomanToInt(string s) {
        int result = 0;
        int i = 0;
        while (i < s.Length) {
            int currentVal = values[Array.IndexOf(symbols, s[i])];
            if (i < s.Length - 1) {
                int nextVal = values[Array.IndexOf(symbols, s[i+1])];
                if (nextVal > currentVal) {
                    // If the next value is greater, subtract the current value from the result
                    result += nextVal - currentVal;
                    i += 2; // Skip the next character
                    continue; // Move to the next iteration of the loop
                }
            }
            // If the next value is not greater or there is no next value, add the current value to the result
            result += currentVal;
            i++;
        }
        return result;
    }
}
