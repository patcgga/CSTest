//ex2判斷 字元裡面是否有包含設定的字

string message ="The quick borwn for jumps over the lazy fox dog,";
bool result = message.Contains("dog"); //  字元有dog則輸出True 沒有則False
Console.WriteLine(result);

if (message.Contains("fox"))    //若字元內含fox 則輸出What does the fox say?
{
    Console.WriteLine("What does the fox say?");
}