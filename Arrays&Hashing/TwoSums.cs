// Given an array of integers nums and an integer target, return the indices i and j such that nums[i] + nums[j] == target and i != j.

// You may assume that every input has exactly one pair of indices i and j that satisfy the condition.

// Return the answer with the smaller index first.

// Example 1:

// Input: 
// nums = [3,4,5,6], target = 7

// Output: [0,1]
// Explanation: nums[0] + nums[1] == 7, so we return [0, 1].

// Example 2:

// Input: nums = [4,5,6], target = 10

// Output: [0,2]
// Example 3:

// Input: nums = [5,5], target = 10

// Output: [0,1]

public class Solution4{
    public int[] TwoSum(int[] nums, int target){

        var indexMap = new Dictionary<int, int>(); // time: O(n) | space: O(n)
        var indexResult = new int[2];
        for(int i = 0; i < nums.Length; i++){
            
            var numToFind = target - nums[i];
            
            if(indexMap.ContainsKey(numToFind)){
                indexResult = [indexMap[numToFind], i];
                break;
            }

            indexMap[nums[i]] = i;
        }

        return indexResult;

    }
}
