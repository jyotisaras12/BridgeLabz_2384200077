let num1 = Math.floor(Math.random() * 900) + 100;
let num2 = Math.floor(Math.random() * 900) + 100;
let num3 = Math.floor(Math.random() * 900) + 100;
let num4 = Math.floor(Math.random() * 900) + 100;
let num5 = Math.floor(Math.random() * 900) + 100;

console.log(`5 random numbers are: ${num1}, ${num2}, ${num3}, ${num4} and ${num5}`);

// Find the maximum number
let max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
if (num4 > max) max = num4;
if (num5 > max) max = num5;

// Find the minimum number
let min = num1;
if (num2 < min) min = num2;
if (num3 < min) min = num3;
if (num4 < min) min = num4;
if (num5 < min) min = num5;

console.log(`The maximum number is: ${max}`);
console.log(`The minimum number is: ${min}`);
