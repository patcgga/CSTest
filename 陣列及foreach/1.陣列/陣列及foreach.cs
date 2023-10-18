//第一種陣列，分別宣告。
 
string[] fraudulentorderIDs = new string[3];

fraudulentorderIDs[0] = "A123";
fraudulentorderIDs[1] = "B456";
fraudulentorderIDs[2] = "C789";



//第二種陣列，以{A,B,C}依次宣告。在以 [0][1][2] 分別引用
string[] fraudulentorderIDs = {"A123","B456","C789"};

Console.WriteLine($"First: {fraudulentorderIDs[0]}");
Console.WriteLine($"Second: {fraudulentorderIDs[1]}");
Console.WriteLine($"Third: {fraudulentorderIDs[2]}");

fraudulentorderIDs[0] = "F000"; //重新指派變數

Console.WriteLine($"Ressign First: {fraudulentorderIDs[0]}");

Console.WriteLine($"There are {fraudulentorderIDs.Length} fraudulent orders to process.");
//.Length 用以獲取組數或數量,這裡是獲取可變數fraudulentorderIDs的組數，即是3組