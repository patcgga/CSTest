//訂閱剩餘天數執行各種提醒。
//當訂閱天數 <= 10天時，則提醒用戶"Your subscription will expire soon. Renew now!"(你的訂閱將到期.現在續約! )

//當訂閱天數 <=  5天時，則提醒用戶"Your subscription expires in 剩餘天數 days.(你的訂閱剩__天過期)
//並且告知當前訂閱將給予10%的折扣優惠

//當訂閱天數 ==  1天時，則提醒用戶"Your subscription expires within a day!"(你的訂閱將在1天內過期)
//並且告知當前訂閱將給予20%的折扣優惠

//當訂閱天數 ==  0天時，則提醒用戶"Your subscription has expired."(訂閱過期)
Random random = new Random();
int daysUntilExpiration = random.Next(12); //宣告可變數 到期天數隨機0~11
int discountPercentage = 0; //宣告可變數 優惠初始為0

Console.WriteLine(daysUntilExpiration);


if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if (discountPercentage > 0) //依照上述條件(==1 、 <=5)scountPercentage會給予20和10的變數值來表示%數，或者在2句都直接用Console.WriteLine();
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
//條件越小的要放到越前面，程式從上到下逐一掃瞄，當有條件達成時，後面的就不再執行。
//if 後面接else if，當if 條件未符合，會依序掃描else if 的條件。
//if 後面若先接了else ，即表示非A即B的意思，if的條件不成立就執行else。  
//當else 後面若還有 else if 則程式會有問題，else後面的都不再掃描。