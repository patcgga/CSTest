//此程式為修正同時計算 +6 和 +2 ，用if + else 來限制重複獎勵。
//(1)最外層先判斷是否2個花色相同時進入(2)，在2時判斷若有3個相同就執行否則執行3
Random dice = new Random();

int roll1 = 6; //dice.Next(6,7);    //強制輸出roll1為6
int roll2 = 6; //dice.Next(6,7);    //強制輸出roll2為6
int roll3 = dice.Next(5,7);         //讓roll3隨機為 5或6 觀察2倍跟3倍獎勵

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))           //(1),任2個相同
{
    if((roll1 == roll2) && (roll2 == roll3)) //3個點數都相同
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");    //(2)
        total += 6;
    }
    else
    {
        Console.WriteLine("You rollled double +2 bonus to total!");     //(3)
        total += 2;
    }
}
if (total >=15)
{
    Console.WriteLine("You win");
}
else
{
    Console.WriteLine("Sorry,you lose.");
}
