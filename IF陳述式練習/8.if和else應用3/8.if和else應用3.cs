// (1)以前繼承7.應用2，加入(2)根據total的值分配不同獎品
//此時可以觀察total的值，假設點數為 2+3+3=8 由於2個花色相同，所以總total為10，獎品能拿到10的那一個。
Random dice = new Random();

int roll1 = 2; //dice.Next(1,7);    //強制輸出roll1為2
int roll2 = 3; //dice.Next(1,7);    //強制輸出roll2為3
int roll3 = 3; //dice.Next(1,7);    //強制輸出roll3為3

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled double! +2 bonus to total!");
        total +=2;
    }
}   //(1)

if (total >=16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You  win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}   //(2)
