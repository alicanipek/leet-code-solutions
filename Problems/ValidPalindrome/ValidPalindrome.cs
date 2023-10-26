/*
125. Valid Palindrome
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.
*/

public static class ValidPalindrome {
    public static bool IsPalindrome(string s) {
        var cArr = s.ToCharArray();
        cArr = Array.FindAll<char>(cArr, x => Char.IsLetterOrDigit(x));
        cArr = cArr.Select(x => Char.ToLower(x)).ToArray();
        var str = new string(cArr);
        var revStr = new string(cArr.Reverse().ToArray());

        return str == revStr;
    }

}
