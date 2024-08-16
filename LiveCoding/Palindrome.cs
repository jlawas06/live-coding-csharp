namespace LiveCoding;
internal static class Palindrome
{
    public static bool IsPalindrome(string str)
    {
        var reversedString = new string(str.Reverse().ToArray());

        return str.Equals(reversedString);
    }
}
