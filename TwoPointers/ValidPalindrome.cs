// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

// Given a string s, return true if it is a palindrome, or false otherwise.

 

// Example 1:

// Input: s = "A man, a plan, a canal: Panama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.
// Example 2:

// Input: s = "race a car"
// Output: false
// Explanation: "raceacar" is not a palindrome.
// Example 3:

// Input: s = " "
// Output: true
// Explanation: s is an empty string "" after removing non-alphanumeric characters.
// Since an empty string reads the same forward and backward, it is a palindrome.

using System.Text;
public class Solution9{
    public bool IsPalindrome(string s) {
        
        s = s.ToLower();
        StringBuilder sortedString1 = new StringBuilder();
        StringBuilder sortedString2 = new StringBuilder();
        for(int i = 0; i < s.Length; i++){
            if(s[i] - 'a' <= 25 && s[i] - 'a' >= 0 || s[i] - '0' >= 0 && s[i] - '0' <= 9){
                sortedString1.Append(s[i]);
            }
        }

        for(int i = s.Length - 1; i >= 0; i--){
            if(s[i] - 'a' <= 25 && s[i] - 'a' >= 0 || s[i] - '0' >= 0 && s[i] - '0' <= 9){
                sortedString2.Append(s[i]); 
            }
        }

        return sortedString1.ToString() == sortedString2.ToString();
        
    }
}
