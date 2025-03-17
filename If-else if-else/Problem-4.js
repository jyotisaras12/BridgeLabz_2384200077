let a = parseInt(process.argv[2]);
let b = parseInt(process.argv[3]);
let c = parseInt(process.argv[4]);

let operation1 = a + b * c;
let operation2 = a % b + c;
let operation3 = c + a / b;
let operation4 = a * b + c;

console.log("Values of Operations are:");
console.log("1. a + b * c  =", operation1);
console.log("2. a % b + c  =", operation2);
console.log("3. c + a / b  =", operation3);
console.log("4. a * b + c  =", operation4);

// Finding the Maximum among the operations
let max = operation1;
if (operation2 > max) max = operation2;
if (operation3 > max) max = operation3;
if (operation4 > max) max = operation4;

// Finding the Minimum among the operations
let min = operation1;
if (operation2 < min) min = operation2;
if (operation3 < min) min = operation3;
if (operation4 < min) min = operation4;

console.log("The Maximum among all operations is:", max);
console.log("The Minimum among all operations is:", min);
