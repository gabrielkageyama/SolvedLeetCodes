// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

 

// Example 1:

// Input: nums = [1,2,3,1]
// Output: true
// Example 2:

// Input: nums = [1,2,3,4]
// Output: false
// Example 3:

// Input: nums = [1,1,1,3,3,4,3,2,4,2]
// Output: true

public class Solution1{
    public bool ContainsDuplicate(int[] nums){

        //LINQ solution - time: O(n) | space: O(n)
        // bool output = nums.SequenceEqual(nums.Distinct());
        // return !output;
    
        var numberSet = new HashSet<int>(); // time: O(n) | space: O(n)
        foreach(int num in nums){
            if(numberSet.Contains(num))
                return true;
            
            numberSet.Add(num);
        }

        return false;
    }
}

