/* S.1.1
    S.1.1 Вывести на экран число  с точностью до сотых.
    float number = 12.103F;
    Console.WriteLine(number);

    Console.WriteLine("ЭЭЭЭЙ!!!Введите число, которое хотите укоротить до сотых:");
    string? userNumber = Console.ReadLine();

    if (string.IsNullOrEmpty(userNumber))
    {
        Console.WriteLine("Ошибка, ты какашка! В следующий раз введи что-то ёмаё!");
    }
    else
    {
        try
        {
                float trueNumber = Convert.ToSingle(userNumber);
                Console.WriteLine($" Ну ладно, держи: {Math.Round(trueNumber, 3)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("А по жопе? Что за фомат?");
        }
    }
*/


/* S.1.2
    S.1.2 Вывести на экран число e (основание натурального логарифма) с точностью до десятых.

    Console.WriteLine("ЭЭЭЭЙ!!! Введи число:");
    string? numberE = Console.ReadLine();

    if (string.IsNullOrEmpty(numberE))
    {
        Console.WriteLine("Ошибка, ты какашка! В следующий раз введи что-то ёмаё!");
    }
    else
    {
        try
        {
            float trueNumber = Convert.ToSingle(numberE);
            Console.WriteLine($" Ну ладно, держи: {Math.Log(trueNumber, 2)}");
     }
        catch (FormatException)
        {
          Console.WriteLine("А по жопе? Что за фомат?");
        }
    }
*/


/*S.1.3
    S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры.
    Выводимому числу должно предшествовать сообщение «Вы ввели число»
*/
Console.WriteLine("Ептыыдь!! Введи число любое:");
string? userText = Console.ReadLine();
if (string.IsNullOrEmpty(userText))
{
    Console.WriteLine("Почему пустооооооо??!?!?!?!?!");
}
else
{
    try
    {
        int userNumber = Convert.ToInt32(userText);
        Console.WriteLine($"Обраточка летит! Держи назад: {userText}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Ты чего?! Забыл как выглядят циферки, АААА?!?!?!");
    }
}