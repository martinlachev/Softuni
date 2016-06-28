/**
 * Created by MartinLachev on 6/20/2016.
 */
/*Write a JS function to sum two numbers given as array of strings*/

function sum(nums) {
    let num1 = Number(nums[0])
    let num2 = Number(nums[1])
    let sum = num1 + num2
    return sum
}


console.log(sum(['10', '20']))