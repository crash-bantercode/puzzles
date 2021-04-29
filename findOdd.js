// find the number that appears an odd number fo times in the array
// https://www.codewars.com/kata/54da5a58ea159efa38000836/train/javascript


var numbers = [20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5]


const countOccurrences = (arr, val) => arr.reduce((a, v) => (v === val ? a + 1 : a), 0);

// My soolution
function findOdd(nums) {
    for (i in nums) {
        console.log(nums[i])
        var timesFound = countOccurrences(nums, nums[i])
        if (timesFound % 2 == 1) {
            console.log("The odd number was: ", nums[i])
            break
        }
    }
}

// best solution I found
const anotherFindOdd = (xs) => xs.reduce((a, b) => a ^ b);

// findOdd(numbers)
console.log(anotherFindOdd(numbers))