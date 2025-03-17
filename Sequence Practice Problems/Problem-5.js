let inches = 42;
let feet = inches / 12;
console.log(`${inches} inches is equal to ${feet} feet.`);

let lengthInFeet = 60;
let widthInFeet = 40;
let lengthInMeters = lengthInFeet * 0.3048;
let widthInMeters = widthInFeet * 0.3048;

console.log(`${lengthInFeet} feet is equal to ${lengthInMeters} meters.`);
console.log(`${widthInFeet} feet is equal to ${widthInMeters} meters.`);

let totalAreaInFeet = (lengthInFeet * widthInFeet) * 25;
let totalAreaInAcres = totalAreaInFeet / 43560;
console.log(`Total area of 25 plots is ${totalAreaInAcres} acres.`);
