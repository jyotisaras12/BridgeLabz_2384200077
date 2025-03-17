let start = parseInt(process.argv[2]);
let end = parseInt(process.argv[3]);

for (let n = start; n <= end; n++) 
{
    let isPrime = true;
    if (n < 2) isPrime = false;
    else 
    {
        for (let i = 2; i < n; i++) 
        {
            if (n % i === 0) 
            {
                isPrime = false;
                break;
            }
        }
    }
    if (isPrime) console.log(n);
}
