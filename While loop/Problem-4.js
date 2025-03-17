let money = 100;
let bets = 0;
let wins = 0;

while (money > 0 && money < 200) 
{
    bets++;
    if (Math.random() < 0.5)
    {
        money--; 
    } 
    else 
    {
        money++; 
        wins++;
    }
}

console.log("Number of Bets made:", bets);
console.log("Number of Wins:", wins);
if(money == 200)
{
    console.log("Reached the goal of Rs. 200!")
}
else
{
    console.log("Went broke!");
}

