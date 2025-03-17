let n = parseInt(process.argv[2]);
let harmonicNum = 0;

for (let i = 1; i <= n; i++) 
    harmonicNum += 1 / i;

console.log("nth Harmonic Number is:", harmonicNum);
