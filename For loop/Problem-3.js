let n = parseInt(process.argv[2]);
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

if(isPrime) console.log("Prime");
else console.log("Non-Prime");
