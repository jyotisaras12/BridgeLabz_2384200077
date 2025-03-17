let headsCount = 0;
let tailsCount = 0;

while (headsCount < 11 && tailsCount < 11) {
    let coinFlip = Math.random();

    if (coinFlip < 0.5) 
    {
        tailsCount++;
        console.log(`Tails (${tailsCount})`);
    } 
    else 
    {
        headsCount++;
        console.log(`Heads (${headsCount})`);
    }
}

if (headsCount === 11) 
{
    console.log("Heads wins 11 times!");
} 
else 
{
    console.log("Tails wins 11 times!");
}
