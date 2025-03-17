const readline = require("readline-sync");

// Function to check if a number is prime
function isPrime(num) {
    if (num < 2) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) 
    {
        if (num % i === 0) return false;
    }
    return true;
}

// Function to get the palindrome of a number
function getPalindrome(num) {
    let reversed = 0;
    let original = num;
    
    while (num > 0) 
    {
        let digit = num % 10;
        reversed = reversed * 10 + digit;
        num = Math.floor(num / 10);
    }
    
    return reversed;
}

// Function to check if a number is prime and its palindrome is also prime
function checkPrimeAndPalindrome(num) {
    if (isPrime(num)) 
    {
        console.log(`${num} is a prime number.`);
        let palindrome = getPalindrome(num);
        console.log(`Palindrome of ${num} is ${palindrome}.`);

        if (isPrime(palindrome)) 
        {
            console.log(`The palindrome ${palindrome} is also a prime number.`);
        } 
        else 
        {
            console.log(`The palindrome ${palindrome} is NOT a prime number.`);
        }
    } 
    else 
    {
        console.log(`${num} is NOT a prime number.`);
    }
}

// Take number as input from user
let num = parseInt(readline.question("Enter a number: "));

// Check and display result
checkPrimeAndPalindrome(num);
