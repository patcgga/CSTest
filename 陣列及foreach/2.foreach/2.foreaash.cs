//迭代,迴圈
/*string[] names = {"Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/

// 加總,疊加,迴圈
int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

