let num1 = Math.floor(Math.random()*90);
let num2 = Math.floor(Math.random()*90);
let num3 = Math.floor(Math.random()*90);
let num4 = Math.floor(Math.random()*90);
let num5 = Math.floor(Math.random()*90);

let numSum = num1 + num2 + num3 + num4 + num5;

let numAvg = numSum/5;

console.log(`5 random numbers are: ${num1}, ${num2}, ${num3}, ${num4} and ${num5}.`);
console.log(`Sum of 5 random 2 digit numbers is: ${numSum}\nAverage of 5 random 2 digit numbers is: ${numAvg}`);
