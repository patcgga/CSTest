//以下有2種方式，其結果相同。
Console.WriteLine("---------------------第1種---------------------");
//第一種陣列，分別宣告。(如下) 
string[] fraudulentorderIDs1 = new string[3];

fraudulentorderIDs1[0] = "A123";
fraudulentorderIDs1[1] = "B456";
fraudulentorderIDs1[2] = "C789";

Console.WriteLine($"First: {fraudulentorderIDs1[0]}");
Console.WriteLine($"Second: {fraudulentorderIDs1[1]}");
Console.WriteLine($"Third: {fraudulentorderIDs1[2]}");

fraudulentorderIDs1[0] = "F000"; //重新指派變數

Console.WriteLine($"Ressign First: {fraudulentorderIDs1[0]}");

Console.WriteLine($"There are {fraudulentorderIDs1.Length} fraudulent orders to process.");


Console.WriteLine("---------------------第2種---------------------");


//第二種陣列，以{A,B,C}依次宣告。在以 [0][1][2] 分別引用
string[] fraudulentorderIDs2 = {"A123","B456","C789"};

Console.WriteLine($"First: {fraudulentorderIDs2[0]}");
Console.WriteLine($"Second: {fraudulentorderIDs2[1]}");
Console.WriteLine($"Third: {fraudulentorderIDs2[2]}");

fraudulentorderIDs2[0] = "F000"; //重新指派變數

Console.WriteLine($"Ressign First: {fraudulentorderIDs2[0]}");

Console.WriteLine($"There are {fraudulentorderIDs2.Length} fraudulent orders to process.");
//.Length 用以獲取組數或數量,這裡是獲取可變數fraudulentorderIDs的組數，即是3組
