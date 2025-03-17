const readline = require("readline-sync");

// Function to check if a number is a palindrome
function isPalindrome(num) {
    if (num < 0) return false;

    let originalNum = num;
    let reversedNum = 0;

    while (num > 0) {
        let digit = num % 10;
        reversedNum = reversedNum * 10 + digit; 
        num = Math.floor(num / 10);
    }

    return originalNum === reversedNum; 
}

// Function to check if two numbers are palindrome
function checkPalindromes(num1, num2) {
    let num1Palindrome = isPalindrome(num1);
    let num2Palindrome = isPalindrome(num2);

    if (num1Palindrome && num2Palindrome) 
    {
        console.log(`Both ${num1} and ${num2} are palindromes.`);
    } 
    else if (num1Palindrome) 
    {
        console.log(`${num1} is a palindrome, but ${num2} is not.`);
    } 
    else if (num2Palindrome) 
    {
        console.log(`${num2} is a palindrome, but ${num1} is not.`);
    } 
    else 
    {
        console.log(`Neither ${num1} nor ${num2} is a palindrome.`);
    }
}

// Take numbers as input from user
let num1 = parseInt(readline.question("Enter first number: "));
let num2 = parseInt(readline.question("Enter second number: "));

// Check and display result
checkPalindromes(num1, num2);
