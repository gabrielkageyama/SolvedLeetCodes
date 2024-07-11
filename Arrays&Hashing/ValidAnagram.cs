// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

// Example 1:

// Input: s = "anagram", t = "nagaram"
// Output: true
// Example 2:

// Input: s = "rat", t = "car"
// Output: false

public class Solution5{
    public bool isAnagram(string s, string t){

        //LINQ Solution - time: O(nlogn) | space: O(n)
        //=> s.OrderBy(x=>x).SequenceEqual(t.OrderBy(x=>x));

        if(s.Length != t.Length) // time: O(n) | space: O(1)
            return false;
        
        var alphabetCount = new int[26];

        for(int i = 0; i < s.Length; i++){
            alphabetCount[s[i] - 'a']++;
            alphabetCount[t[i] - 'a']--;
        }

        foreach(int num in alphabetCount){
            if(num != 0)
                return false;
        }
        return true;
    }
}
