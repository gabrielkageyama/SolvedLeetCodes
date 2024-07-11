// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 

// Example 1:

// Input: nums = [1,1,1,2,2,3], k = 2
// Output: [1,2]
// Example 2:

// Input: nums = [1], k = 1
// Output: [1]

public class Solution3{
    public int[] TopKFrequent(int[] nums, int k){ // time: O(n) | space: O(n)

        var listNumbers = new Dictionary<int, int>();

        foreach(int num in nums){
            if(listNumbers.ContainsKey(num))
                listNumbers[num]++;
            else
                listNumbers[num] = 1;
        }

        var bucket = new List<int>[nums.Length + 1];
        foreach(var pair in listNumbers){
            var frequency = pair.Value;
            if(bucket[frequency] == null)
                bucket[frequency] = new List<int>();
            bucket[frequency].Add(pair.Key);
        }

        var mostFreqList = new List<int>();
        for(int i = bucket.Length - 1; i >= 0 && mostFreqList.Count < k; i--){
            if(bucket[i] != null){
                mostFreqList.AddRange(bucket[i]);
            }
        }

        return mostFreqList.ToArray();

    }
}
