
// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

// Notice that the solution set must not contain duplicate triplets.

 
// Example 1:

// Input: nums = [-1,0,1,2,-1,-4]
// Output: [[-1,-1,2],[-1,0,1]]
// Explanation: 
// nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
// nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
// nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
// The distinct triplets are [-1,0,1] and [-1,-1,2].
// Notice that the order of the output and the order of the triplets does not matter.
// Example 2:

// Input: nums = [0,1,1]
// Output: []
// Explanation: The only possible triplet does not sum up to 0.
// Example 3:

// Input: nums = [0,0,0]
// Output: [[0,0,0]]
// Explanation: The only possible triplet sums up to 0.

public class Solution12{
    public IList<IList<int>> ThreeSum(int[] nums) { // time: O(n^2) | space: O(n)
        
        var resultList = new List<IList<int>>();
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length; i++){
            if(i != 0 && nums[i] == nums[i-1])
                continue;
            
            var j = i + 1;
            var y = nums.Length - 1;
            
            while(j < y){
                
                var targetSum = nums[i] + nums[j] + nums[y];
                
                if(targetSum == 0){
                    resultList.Add(new List<int> {nums[i], nums[j], nums[y]});
                    y--;
                    j++;
                    while(j < y && nums[y + 1] == nums[y]) y--;
                    while(j < y && nums[j - 1] == nums[j]) j++;
                }
                else if(targetSum > 0){
                    y--;
                }
                else{
                    j++;
                }
            }
        }

        return resultList;
    }
}
