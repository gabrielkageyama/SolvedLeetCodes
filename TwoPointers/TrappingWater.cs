// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.



// Example 1:


// Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
// Output: 6
// Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
// Example 2:

// Input: height = [4,2,0,3,2,5]
// Output: 9

using System.ComponentModel.DataAnnotations;

public class Solution13{
    public int Trap(int[] height) { // timw: O(n) | space: O(1)
        
        int p1 = 0;
        int p1Max = height[p1];
        int p2 = height.Length - 1;
        int p2Max = height[p2];
        int trappedWater = 0;
        
        while(p1 < p2){
            if(p1Max > p2Max){
                p2--;
                p2Max = Math.Max(p2Max, height[p2]);
                trappedWater += p2Max - height[p2];
            }else{
                p1++;
                p1Max = Math.Max(p1Max, height[p1]);
                trappedWater += p1Max - height[p1];
            }
        }
        
        return trappedWater;
    }
}
