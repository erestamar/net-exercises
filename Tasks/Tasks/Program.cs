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
            Console.WriteLine($"Обраточка летит! Держи назад: {userNumber}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ты чего?! Забыл как выглядят циферки, АААА?!?!?!");
        }
    }
*/


/* S.1.4
    S.1.4 Составить программу вывода на экран числа, вводимого с клавиатуры. 
    После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

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
            Console.WriteLine($"{userNumber} хехе, я так и думал то ты введёшь именно его");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ты чего?! Забыл как выглядят циферки, АААА?!?!?!");
        }
    }
*/


/* S1.5.- S1.7.
    S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.

    S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.

    S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя
    пробелами между ними.
 */

Console.WriteLine("Держи числа хахахаха: 1 13 49");
int firstNumber = 7;
int secondNumber = 15;
int thirdNumber = 100;
Console.WriteLine($"А вот ещё на! хахаха: {firstNumber}  {secondNumber}  {thirdNumber}");
Console.WriteLine("А ну ка, запроси теперь у меня три любых числа, начни с первого:");
string? userTextFirst = Console.ReadLine();
Console.WriteLine("Теперь второе число:");
string? userTextSecond = Console.ReadLine();
Console.WriteLine("Теперь третье число:");
string? userTextThird = Console.ReadLine();
Console.WriteLine($"Хм... а вот и они:{userTextFirst}  {userTextSecond}  {userTextThird}");


