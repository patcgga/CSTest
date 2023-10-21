// 分辨出B開頭的字串。
//.StartsWith(char) 判斷此字串執行個體是否以指定的字元開頭(大小寫須注意)
string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith('B'))
    {
    Console.WriteLine(orderID);
    }
}
