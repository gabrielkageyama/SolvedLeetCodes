// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

// You must write an algorithm that runs in O(n) time and without using the division operation.

 

// Example 1:

// Input: nums = [1,2,3,4]
// Output: [24,12,8,6]
// Example 2:

// Input: nums = [-1,1,0,-3,3]
// Output: [0,0,9,0,0]

public class Solution9{
    public int[] ProductExceptSelf(int[] nums) {
        int prefix = 1, postfix = 1;
        int[] res = new int[nums.Length];        
        
        for(int i = 0; i < nums.Length; i++){
            res[i] = prefix;
            prefix *= nums[i];             
        }
        
        for(int i = nums.Length-1; i>=0; i--){
            res[i] *= postfix;
            postfix *= nums[i];          
        }
        return res;
    }
}
