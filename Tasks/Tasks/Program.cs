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


Console.WriteLine("Введи числа через пробел: ");
string userMessage = Console.ReadLine();
string[] arrayNumbers = userMessage.Split(' ');
foreach(var number in arrayNumbers)
{
    Console.WriteLine($"<{number}>");
}
*/


/* S2.1-S2.4 S2.10. S2.11.
    S2.1. Составить программу:
а) вычисления значения функции y=7x2+3x+6 при любом значении x;
б) вычисления значения функции x=12a2+7a+12 при любом значении а.
    S2.2.Дана сторона квадрата. Найти его периметр.
    S2.3. Дан радиус окружности. Найти ее диаметр
    S2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние 
    до линии горизонта от точки В с заданной высотой h=AB над Землей.
    S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).
    S2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.   


Console.WriteLine("Введите знаачение числа х:");
string? xString = Console.ReadLine();
int x = Convert.ToInt32(xString);
int y = 7 * x * 2 + 3 * x + 6;
Console.WriteLine(y);

Console.WriteLine("Введите значение стороны квадрата: ");
string? sideString = Console.ReadLine();
double side = Convert.ToDouble(sideString);
double perimetr = side * 4;
Console.WriteLine($"Вот периметр квадрата {perimetr}");

Console.WriteLine("Введите радиус окружности: ");
string? radString = Console.ReadLine();
double rad = Convert.ToDouble(radString);
double diametr = rad * 2;
Console.WriteLine($"Вот периметр квадрата {diametr}");

int r = 6350;
int og = r;
Console.WriteLine("Введите заданную высоту AB:");
string? abString = Console.ReadLine();
int ab = Convert.ToInt32(abString);
int ob = r + ab;
int bg = (ob * ob) - (og * og);
Console.WriteLine($"Вот расстояние до линии горизонта{bg}");

Console.WriteLine("Введите значения чисел a x b через пробел: ");
string? axbString = Console.ReadLine();
string[] axb = axbString.Split(' ');
string stringA = axb.ElementAt(0);
string stringX = axb.ElementAt(1);
string stringB = axb.ElementAt(2);
int numberA = Convert.ToInt32(stringA);
int numberX = Convert.ToInt32(stringX);
int numberB = Convert.ToInt32(stringB);
if (numberA != 0)
{
    int result = numberA * numberX + numberB;
    if (result != 0)
    {
        Console.WriteLine("Линейное выражение не может быть успешно выполнено!");
    }
    else
    {
        Console.WriteLine("Линейноее выражение успешно выполнено!");
    }
}
else
{
    Console.WriteLine("Значение a не может быть равно нулю!");

}

Console.WriteLine("Введите значение катетов прямоугольного треугольника через пробел: ");
string katetsSring = Console.ReadLine();
string[] katetsStringArray = katetsSring.Split(' ');
if (katetsStringArray.Length <= 2)
{
    int katetA = Convert.ToInt32(katetsStringArray[0]);
    int katetB = Convert.ToInt32(katetsStringArray[1]);
    int res = (katetA * katetA) + (katetB * katetB);
    Console.WriteLine($"Гипотенуза прямоугольного треугольника: <{res}>");
}
else
{
    Console.WriteLine("Недопустимое количество катетов!");
}

*/



/* A2.1.
    A2.1. Дано двузначное число. Найти:
    в) сумму его цифр;
    г) произведение его цифр.
*/

Console.WriteLine("Введите три числа через пробел");
string numbers = Console.ReadLine();
string[] numbersArray = numbers.Split(' ');
if (numbersArray.Length == 3)
{
    Console.WriteLine("Введите 1 если хотите суммировать все числа, 2 если хотите произвести их, и 3 если хотит посчитать сумму цифр чисел: ");
    string check = Console.ReadLine();
    if (check == "1")
    {
        int resultSumInt = 0;
        double resultSumDouble = 0;
        foreach (string i in numbersArray)
        {
            if (int.TryParse(i, out int numberInt))
            {
                resultSumInt += numberInt;
            }
            else if (double.TryParse(i, out double numberDouble))
            {
                resultSumDouble += numberDouble;
            }
        }
        double resultSum = resultSumInt + resultSumDouble;
        Console.WriteLine($"Результат суммы чисел: {resultSum}");
    }
    else if (check == "2")
    {
        int resultProInt = 1;
        double resultProDouble = 1;
        foreach (string i in numbersArray)
        {
            if (int.TryParse(i, out int numberInt))
            {
                resultProInt *= numberInt;
            }
            else if (double.TryParse(i, out double numberDouble))
            {
                resultProDouble *= numberDouble;
            }
        }
        double resultPro = resultProInt * resultProDouble;
        Console.WriteLine($"Результат произведение чисел: {resultPro}");
    }
    else if (check == "3")
    {
        int res = 0;
        foreach (string str in numbersArray)
        {
            foreach (char symbol in str)
            {
                if (char.IsDigit(symbol))
                {
                    res += int.Parse(symbol+"");
                }
            }
        }
        Console.WriteLine($"Сумма цифр в числах {res}");

    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}
else
{
    Console.WriteLine("Неверное кол-во чисел");
}
