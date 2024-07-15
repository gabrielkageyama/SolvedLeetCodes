// Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

// Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

// The tests are generated such that there is exactly one solution. You may not use the same element twice.

// Your solution must use only constant extra space.

 

// Example 1:

// Input: numbers = [2,7,11,15], target = 9
// Output: [1,2]
// Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].
// Example 2:

// Input: numbers = [2,3,4], target = 6
// Output: [1,3]
// Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].
// Example 3:

// Input: numbers = [-1,0], target = -1
// Output: [1,2]
// Explanation: The sum of -1 and 0 is -1. Therefore index1 = 1, index2 = 2. We return [1, 2].

public class Solution {
    public int[] TwoSum(int[] numbers, int target) { // time: O(n^2) | space: O(1)
        var result = new int[2];
        for(int i = 0; i < numbers.Length; i++){
            var numberToFind = target - numbers[i];
            for(int j = i; j < numbers.Length; j++){
                if(numbers[j] == numberToFind){
                    result = new int[] {i + 1, j + 1};
                    return result;
                }
            }
        }
        return result;
    }
}

// Descobri que é possível que seja mais eficiente (time: O(n)) utilizando apenas um WhileLoop, iterando sobre o array,
// considerando que a ordem é sempre crescente, podemos somar o primeiro valor da direita com o ultimo da esquerda,
// e ir aproximando ao centro até achar nosso encontrar nosso valor target. Entretando minha solução cumpre o solicitado
// utilzando um espaço constante (O(1))

