// Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

// You must write an algorithm that runs in O(n) time.

 

// Example 1:

// Input: nums = [100,4,200,1,3,2]
// Output: 4
// Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
// Example 2:

// Input: nums = [0,3,7,2,5,8,4,6,0,1]
// Output: 9

public class Solution8{
    public int LongestConsecutive(int[] nums) {

        var sequenceSet = new HashSet<int>();
        int longest = 0;

        foreach(int num in nums){
            sequenceSet.Add(num);
        }
        foreach(int num in nums){
            if(!sequenceSet.Contains(num - 1)){
                int length = 0;
                while(sequenceSet.Contains(num + length)){
                    length++;
                }
                if(length > longest)
                    longest = length;
            }
        }
        return longest;
    }
}
