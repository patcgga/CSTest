//當3個花色相同時3倍獎勵，但此程式只會把達成條件的都顯示出來，變成2倍獎勵和3倍獎勵都拿到。
//由於Console.WriteLine()中的total放在if前，因此if內的total +2和+6 雖然有加但顯示時會沒有。
Random dice = new Random();

int roll1 = 6; //dice.Next(1, 7);    //強制輸出roll1為6 方便觀察
int roll2 = 6; //dice.Next(1, 7);    //強制輸出roll2為6 方便觀察
int roll3 = 6; //dice.Next(1, 7);    //強制輸出roll3為6 方便觀察

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) //roll1~roll3 任2個值相同
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2; //total +2
    }

if ((roll1 == roll2) && (roll2 == roll3)) // roll1 = roll2 = roll3
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6; //total +6
}

if (total >= 15) 
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
// Console.WriteLine(total); 加上此行可以清楚看到total值的確有變化，放的位置會影響顯示。