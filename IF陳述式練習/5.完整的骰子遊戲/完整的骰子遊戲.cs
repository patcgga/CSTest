using System;

class Program
{
    static void Main()
    {
        Random dice = new Random();
        int bonus = 10;

        bool gameRunning = true;

        while (gameRunning)
        {
            Console.WriteLine("Press 1 to roll the dice, or 2 to exit.");
            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.D1)
            {
                int roll1 = dice.Next(1, 7);
                int roll2 = dice.Next(1, 7);
                int roll3 = dice.Next(1, 7);

                int total = roll1 + roll2 + roll3;
                Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

                if (roll1 == roll2 && roll2 == roll3)
                {
                    bonus += 6;
                    Console.WriteLine("You rolled triples! +6 bonus");
                    Console.WriteLine("Bonus: " + bonus);
                }

                if (total >= 15)
                {
                    bonus += 1; // 修正為加1
                    Console.WriteLine("You win! +1 bonus");
                    Console.WriteLine("Bonus: " + bonus);
                }
                else
                {
                    bonus -= 1;
                    Console.WriteLine("You lose! -1 bonus");
                    Console.WriteLine("Bonus: " + bonus);
                }

                if (bonus == 0) //或if (bonus < 1) ，結果相同
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine("Press 2 to restart or any other key to exit.");
                    var restartKey = Console.ReadKey().Key;
                    if (restartKey == ConsoleKey.D2)
                    {
                        bonus = 10;
                        Console.WriteLine("\nGame restarted. Bonus: " + bonus);
                    }
                    else
                    {
                        gameRunning = false;
                    }
                }
            }
            else if (key == ConsoleKey.D2)
            {
                gameRunning = false;
            }
        }
    }
}
