//S.1.1 Вывести на экран число  с точностью до сотых.
//float number = 12.103F;
//Console.WriteLine(number);

using System.Linq.Expressions;

Console.WriteLine("ЭЭЭЭЙ!!!Введите число, которое хотите укоротить до сотых:");
string? usernumber = Console.ReadLine();
string empty = "";
if (usernumber == empty)
{
    Console.WriteLine("Ошибка, ты какашка! В следующий раз введи что-то ёмаё!");
}
else
{
    try
    {
        float truenumber = Convert.ToSingle(usernumber);
        Console.WriteLine($" Ну ладно, держи: {Math.Round(truenumber, 3)}");
    }
    catch (System.FormatException)
    {
        Console.WriteLine("А по жопе? Что за фомат?");
    }
    
    
}





//S.1.2 Вывести на экран число e (основание натурального логарифма) с точностью до десятых.


