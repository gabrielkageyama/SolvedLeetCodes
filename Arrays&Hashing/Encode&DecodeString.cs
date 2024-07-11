// String Encode and Decode
// Solved 
// Design an algorithm to encode a list of strings to a single string. The encoded string is then decoded back to the original list of strings.

// Please implement encode and decode

// Example 1:

// Input: ["neet","code","love","you"]

// Output:["neet","code","love","you"]
// Example 2:

// Input: ["we","say",":","yes"]

// Output: ["we","say",":","yes"]

public class Solution6{

    public string Encode(IList<string> strs) {
        return  string.Concat(strs.SelectMany(x => $"{x.Length}#{x}")); // junto todas as strings adicionando o tamanho da palavra 
                                                                        // e um # para que seja possível identificar o inicio da palavra
    }
    public List<string> Decode(string s) {
        var separatedWords = new List<string>();
        int i = 0;

        while(i < s.Length){
            var j = i;

            while(j != s.Length && s[j] != '#'){
                ++j;
            }

            int.TryParse(s.Substring(i, j-i), out var lenWord);
            
            j++;

            separatedWords.Add(s.Substring(j, lenWord));
            
            i = j + lenWord;
        }

        return separatedWords;
   }
}
