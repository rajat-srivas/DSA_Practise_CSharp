namespace dsa;

public class Longest_Palindrome_Substring
{
      public  int LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        int longest = 1;
        for(int i = 1;i<s.Length;i++)
        {
            var lengthEven = CheckPalindrome(s,i-1,i+1);
            var lengthOdd = CheckPalindrome(s,i-1,i);

            longest = Math.Max(longest, Math.Max(lengthEven,lengthOdd));
        }
        return longest;
    }

    public  int CheckPalindrome(string s, int left, int right)
    {
     if(s.Length ==1)
     {
         return 1;
     }
        while (left >= 0 && right < s.Length)
        {
             if(s[left] != s[right])
             {
                 break;
             }
                left--;
                right++;
        }
        return right-left -1;
    }
}
