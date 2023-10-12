// ex3 擲骰子，當3個骰子有2個同花色則total+2,此外總和>=15才算獲勝
Random A = new Random();
int roll1 = A.Next(1,7);
int roll2 = A.Next(1,7);
int roll3 = A.Next(1,7);

int total = roll1 + roll2 + roll3 ;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 ==roll2) || (roll2 == roll3) || (roll1 == roll3))
{
   Console.WriteLine("You rolled doubles! +2 bonus to total!");
   total += 2;
}
if (total >= 15)
{
    Console.WriteLine("You win!");
}
if (total < 15)
{
  Console.WriteLine("Sorry,you lose.");
}
