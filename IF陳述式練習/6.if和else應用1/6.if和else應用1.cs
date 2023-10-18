//此程式碼跟4.3個花色都相同結果是相同的，搭配if + else， >=15 win 否則就是 lose 
//else 會跟離自己最接近的上一個if作搭配。
Random dice = new Random();

int roll1 = 6; //dice.Next(1,7);    //強制輸出roll1為6
int roll2 = 4; //dice.Next(1,7);    //強制輸出roll2為4
int roll3 = dice.Next(1,7);         //讓roll3隨機1~6 方便觀察

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolld doubles! +2 bonus to total!");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples!  +6 bonus to total!");
    total += 6;
}
if (total >=15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}