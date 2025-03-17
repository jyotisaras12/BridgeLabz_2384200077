const readline = require("readline-sync");

let low = 1, high = 100;

console.log("Think of a number between 1 and 100.");

while (low < high) 
{
    let mid = Math.floor((low + high) / 2);
    let answer = readline.question(`Is your number greater than ${mid}? (yes/no): `);

    if (answer.toLowerCase() === "yes") 
    {
        low = mid + 1;
    } 
    else 
    {
        high = mid;
    }
}

console.log(`The Magic Number is: ${low}`);
