

var numbers = [20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5]
numbers.reduce

const countOccurrences = (arr, val) => arr.reduce((a, v) => (v === val ? a + 1 : a), 0);

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

findOdd(numbers)