// Given an array of strings strs, group the anagrams together. You can return the answer in any order.

// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

// Example 1:

// Input: strs = ["eat","tea","tan","ate","nat","bat"]
// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
// Example 2:

// Input: strs = [""]
// Output: [[""]]
// Example 3:

// Input: strs = ["a"]
// Output: [["a"]]

public class Solution2{
    public IList<IList<string>> GroupAnagrams(string[] strs){

        var listWords = new Dictionary<string, IList<string>>(); // time: O(n*m) | space: O(n*m)

        foreach(string word in strs){
            var alphabeticCount = new int[26];

            for(int i = 0; i < word.Length; i++){
                alphabeticCount[word[i] - 'a']++;
            }

            var key = string.Join(",", alphabeticCount);

            if(!listWords.ContainsKey(key))
                listWords[key] = new List<string>();
            
            listWords[key].Add(word);
        }

        return new List<IList<string>>(listWords.Values);
    }
}
