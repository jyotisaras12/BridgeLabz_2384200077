let n = parseInt(process.argv[2]);
let i = 0;
let power = 1;

while (i <= n && power <= 256) {
    console.log(`2^${i} = ${power}`);
    power *= 2;
    i++;
}
