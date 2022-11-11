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

//Console.WriteLine("Введите три числа через пробел");
//string numbers = Console.ReadLine();
//string[] numbersArray = numbers.Split(' ');
//if (numbersArray.Length == 3)
//{
//    Console.WriteLine("Введите 1 если хотите суммировать все числа, 2 если хотите произвести их, и 3 если хотит посчитать сумму цифр чисел: ");
//    string check = Console.ReadLine();
//if (check == "1")
//{
//    int resultSumInt = 0;
//    double resultSumDouble = 0;
//    foreach (string i in numbersArray)
//    {
//        if (int.TryParse(i, out int numberInt))
//        {
//            resultSumInt += numberInt;
//        }
//        else if (double.TryParse(i, out double numberDouble))
//        {
//            resultSumDouble += numberDouble;
//        }
//    }
//    double resultSum = resultSumInt + resultSumDouble;
//    Console.WriteLine($"Результат суммы чисел: {resultSum}");
//}
//else if (check == "2")
//{
//    int resultProInt = 1;
//    double resultProDouble = 1;
//    foreach (string i in numbersArray)
//    {
//        if (int.TryParse(i, out int numberInt))
//        {
//            resultProInt *= numberInt;
//        }
//        else if (double.TryParse(i, out double numberDouble))
//        {
//            resultProDouble *= numberDouble;
//        }
//    }
//    double resultPro = resultProInt * resultProDouble;
//    Console.WriteLine($"Результат произведение чисел: {resultPro}");
//}

//    if (check == "1" || check == "2")
//    {
//        //1 ЭТАП РЕФАКТОРИНГА
//        //CalculateOp(check, numbersArray);
//    }
//    else if (check == "3")
//    {
//        int res = 0;
//        foreach (string str in numbersArray)
//        {
//            foreach (char symbol in str)
//            {
//                if (char.IsDigit(symbol))
//                {
//                    res += int.Parse(symbol+"");
//                }
//            }
//        }
//        Console.WriteLine($"Сумма цифр в числах {res}");

//    }
//    else
//    {
//        Console.WriteLine("Ошибка");
//    }
//}
//else
//{
//    Console.WriteLine("Неверное кол-во чисел");
//}


/* 1 ЭТАП РЕФАКТОРИНГА
static void CalculateOp(string code, string[] numbersArray)
{
    int resultSumInt = 0;
    double resultSumDouble = 0;

    if (code == "2")
    {
        resultSumInt = 1;
        resultSumDouble = 1;
    }

    foreach (string i in numbersArray)
    {
        if (int.TryParse(i, out int numberInt))
        {
            if (code == "1")
                resultSumInt += numberInt;
            else if (code == "2")
                resultSumInt *= numberInt;
        }
        else if (double.TryParse(i, out double numberDouble))
        {
            if (code == "1")
                resultSumDouble += numberDouble;
            else if (code == "2")
                resultSumInt *= numberInt;
        }
    }

    double resultSum = 0;

    if (code == "1")
        resultSum = resultSumInt + resultSumDouble;
    else if (code == "2")
        resultSum = resultSumInt * resultSumDouble;

    Console.WriteLine($"Результат суммы чисел: {resultSum}");
}
*/


// //2 ЭТАП РЕФАКТОРИНГА
//static void CalculateOp(bool isSum, string[] numbersArray)
//{
//    int resultSumInt = isSum ? 0 : 1;
//    double resultSumDouble = isSum ? 0 : 1;

//    foreach (string i in numbersArray)
//    {
//        if (int.TryParse(i, out int numberInt))
//        {
//            if (code == "1")
//                resultSumInt += numberInt;
//            else if (code == "2")
//                resultSumInt *= numberInt;
//        }
//        else if (double.TryParse(i, out double numberDouble))
//        {
//            if (code == "1")
//                resultSumDouble += numberDouble;
//            else if (code == "2")
//                resultSumInt *= numberInt;
//        }
//    }

//    double resultSum = 0;

//    if (code == "1")
//        resultSum = resultSumInt + resultSumDouble;
//    else if (code == "2")
//        resultSum = resultSumInt * resultSumDouble;

//    Console.WriteLine($"Результат суммы чисел: {resultSum}");
//}

/*I3.1.  
 *  I3.1.  Проверить, принадлежит ли число, введенное с клавиатуры, интервалу (–5, 3).
 *  



Console.WriteLine("Введите число: ");
string? userInput = Console.ReadLine();
int[] numberArray = { -5, -4, -3, -2, -1, 0, 1, 2, 3 };
bool ask = false;
int numberInput = Convert.ToInt32(userInput);
foreach(int i in numberArray)
{
    if (i == numberInput)
    {
        ask = true;
    }
}
if (ask == true)
{
    Console.WriteLine($"Это число {numberInput} принадлежит интервалу!");
}
else
{
    Console.WriteLine($"Это число {numberInput} не принадлежит интервалу!");

}
*/
//Console.WriteLine("Введите число: ");
//string? userIn = Console.ReadLine();
//int numInput = Convert.ToInt32(userIn);
//if (numInput > -5 && numInput < 3)
//{
//    Console.WriteLine($"Это число {numInput} принадлежит интервалу!");
//}
//else
//{
//    Console.WriteLine($"Это число {numInput} не принадлежит интервалу!");

//}
//Console.WriteLine(numInput <= -5 && numInput >= 3 ? $"Это число {numInput} не принадлежит интервалу!" : $"Это число {numInput} принадлежит интервалу!");

//Console.WriteLine($"Это число {numInput} {(numInput <= -5 && numInput >= 3 ? "не" : "")} принадлежит интервалу!");

/* I3.2.  
I3.2.  Даны три вещественных числа a, b, c. Проверить:
а) выполняется ли неравенство a < b < c;
б) выполняется ли неравенство b > a > c
*/

//Console.WriteLine("Введите три числа через пробел: ");
//string? userInput = Console.ReadLine();
//string[] numArray = userInput.Split(' ');
//if (Convert.ToInt32(numArray[0]) < Convert.ToInt32(numArray[1]) && Convert.ToInt32(numArray[1]) < Convert.ToInt32(numArray[2]))
//{
//    Console.WriteLine("выполняется неравенство a < b < c;");
//}
//else if (Convert.ToInt32(numArray[0]) > Convert.ToInt32(numArray[1]) && Convert.ToInt32(numArray[1]) > Convert.ToInt32(numArray[2]))
//{
//    Console.WriteLine("выполняется неравенство b > a > c");
//}
//else
//{
//    Console.WriteLine("error");
//}
//List<int> ints = new List<int>();
//foreach (string str in numArray)
//{
//    ints.Add(Convert.ToInt32(str));
//}
//Console.WriteLine($"Выполняется неравенство {(ints[0] < ints[1] && ints[1] < ints[2] ? "a < b < c" : "b > a > c")}");

/* I3.24.
 * I3.24. Определить, является ли заданное шестизначное число счастливым. 
 * (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме 
 * его последних трех цифр).
 */

//Console.WriteLine("Введите число чтобы определить, является ли заданное шестизначное число счастливым: ");
//string? userIn = Console.ReadLine();
//List<int> intArray = new List<int>();
//foreach (char str in userIn)
//{
//    intArray.Add(Convert.ToInt32(str));
//}
//Console.WriteLine($"Данное число {(intArray[0] + intArray[1] + intArray[2] == intArray[3] + intArray[4] + intArray[5] ? "является" : "не является")} счастливым!");

//(int sumFirst, int sumSecond) SumOfElements(List<int> arr, int n)
//{
//    int sumFirst = 0;
//    int sumSecond = 0;
//    for (int i = 0; i < n; i++)
//    {
//        //i < n / 2 ? sumFirst += arr[i] : sumSecond += arr[i]; -????? не робит!!!!   ヽ(╬ Ò﹏Ó)ノ
//        if (i < n / 2)
//            sumFirst += arr[i];

//        else
//            sumSecond += arr[i];
//    }
//    return (sumFirst, sumSecond);
//}
//Console.WriteLine("Ввдите число: ");
//string input = Console.ReadLine();
//List<int> arr = new List<int>();
//foreach (char i in input)
//{
//    arr.Add(Convert.ToInt32(i + ""));
//}

//(int sumFirst, int sumSecond) sums = SumOfElements(arr, arr.Count);
//Console.WriteLine($"Это число {(sums.sumFirst == sums.sumSecond ? "является" : "не является")} счастливым!");


/* С5.13. Дано натуральное число.
 * Найти сумму его последних n цифр. Величины для хранения всех n последних цифр числа не использовать.
 


//Console.WriteLine("Ввеедите натуральное число  (-_-)  : ");
//string input = Console.ReadLine();

//List<int> numbersString = new List<int>();    
//foreach (char s in input)
//{
//    numbersString.Add(Convert.ToInt32(s + "")); 
//}
//Console.WriteLine("Введите кол-во последних цифр числа, которое хотите суммировать  ＼(0_0)／ : ");
//int naturalNumberToSum = Convert.ToInt32((Console.ReadLine())); 
//int helper = naturalNumberToSum * -1; 
//List<int> listOfLastNumbers = new List<int>();
//for (int i = helper; i < 0; i++)
//{
//    listOfLastNumbers.Add(numbersString[^(-i)]);  
//}
//Console.WriteLine(listOfLastNumbers.Sum());
*/

/*W5 .4.
W5 .4.Дано натуральное число.Определить:
а) сумму его цифр;
б) количество цифр в нем;
в) произведение его цифр;
г) среднее арифметическое его цифр;
д) сумму квадратов его цифр;
е) сумму кубов его цифр;
ж) его первую цифру;
з) сумму его первой и последней цифр.



Console.WriteLine("Засранец, введи натуральное(не гейское) число гнидаа! Я для кого стараюсь епта!!!!");
string input = Console.ReadLine();
int numberInput = Convert.ToInt32(input);
Console.WriteLine("Введи букву желаемой задачи ёптыдь  ＼(0_0)／ !");
Console.WriteLine(" а) сумму его цифр; \r\n б) количество цифр в нем; \r\n в) произведение его цифр; \r\n г) среднее арифметическое его цифр; \r\n д) сумму квадратов его цифр; \r\n е) сумму кубов его цифр;\r\n ж) его первую цифру; \r\n з) сумму его первой и последней цифр.");
string inputOption = Console.ReadLine(); // а б в ...
List<int> listOfNumbers = new List<int>();
int result = 1;
int resultOne = 0;
int resultTwo = 0;
int helper = 0;
List<int> listOfNumbersOne = new List<int>();

if (inputOption == "а")
{
    foreach (char s in input)
    {
        listOfNumbers.Add(Convert.ToInt32(s + ""));  // 12314 
    }
    Console.WriteLine($"Сумма той херни что ты ввёл  ＼(х_0)／  : {listOfNumbers.Sum()}");
}
else if (inputOption == "б")
{
    foreach (char s in input)
    {
        listOfNumbers.Add(Convert.ToInt32(s + ""));  // 12314 
    }
    Console.WriteLine($"Кол-во той херни что ты ввёл ＼(х_0)／ : {listOfNumbers.Count()}");
}
else if (inputOption == "в")
{
    foreach (char s in input)
    {
        result *= Convert.ToInt32(s + "");
    }
    Console.WriteLine($"Произведение той херни что ты ввёл ＼(х_0)／ : {result}");
}
else if (inputOption == "г")
{
    foreach (char s in input)
    {
        listOfNumbers.Add(Convert.ToInt32(s + ""));  // 12314 
    }
    resultOne = listOfNumbers.Sum();
    foreach (char s in input)
    {
        listOfNumbersOne.Add(Convert.ToInt32(s + ""));  // 12314 
    }
    resultTwo = listOfNumbersOne.Count();
    Console.WriteLine($"Среднее арифметическое твоих цифр, гыы  ＼(+_+)／  :  {result = resultOne / resultTwo}");
}
else if (inputOption == "д") //123456 34 34
{
    foreach (char s in input)
    {
        helper = Convert.ToInt32(s + "");
        resultOne = resultOne + (helper * helper); 
    }
    Console.WriteLine($"Вот тебе сумма квадратов твоих цифр числа, НАААААА  ＼(+_+)／  :  {resultOne}");
}
else if (inputOption == "е") //123456 34 34
{
    foreach (char s in input)
    {
        helper = Convert.ToInt32(s + "");
        resultOne = resultOne + (helper * helper * helper);
    }
    Console.WriteLine($"Вот тебе сумма кубиков твоих цифр числа, НАААААА  ＼(+_+)／  :  {resultOne}");
}
else if (inputOption == "ж")
{
    foreach (char s in input)
    {
        listOfNumbers.Add(Convert.ToInt32(s + ""));  // 12314 
    }
    Console.WriteLine($" Держи первую цифру, ухухухуху ＼(х_х)／ :  {listOfNumbers[0]}");
}
else if (inputOption == "з")
{
    foreach (char s in input)
    {
        listOfNumbers.Add(Convert.ToInt32(s + ""));  // 12314 
    }
    Console.WriteLine($" Держи сумму первого и последнего числа цифры, ухухухуху ＼(х_х)／ :  {listOfNumbers[0] + listOfNumbers[^1]}");
}
else
{
    Console.WriteLine("EEEEEEEEEERRRRROOOOOOOOOOOOOOOOR 404 404 404 404404 404 404 404 404vv v404 404404ndsfhnldshb,sbhgkj!!!!!!");
}

*/

/* W5 .5. 
W5 .5.Известны оценки по информатике каждого из 7 учеников класса. В начале списка перечислены все пятерки, 
затем все остальные оценки. Сколько учеников имеют по информатике оценку «5»? Условный оператор не использовать. 
Рассмотреть два случая:
1) известно, что пятерки имеют не все ученики класса;
2) допускается, что пятерки могут иметь все ученики класса.


int[] arr = new int[20]; // 20 оценок 3 5 5 5 3 2 4...
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(2, 6);
}
Array.Sort(arr);
Array.Reverse(arr); //5 5 5 5 5 4...
foreach (int a in arr)
{
    Console.WriteLine("оценка - " + a);
}

for (int b = 0; b < arr.Length; b++)
{
    while (arr[b] == 5)
    {
        sum++;
        break;
    }
}
int j = 0;
int b = 0;
while (j < 20 && arr[b] == 5)
{
    b++;
    sum++;
    j++;
}

for (int b = 0; b < arr.Length && arr[b] == 5; b++, sum++) ;
Console.WriteLine($"Воть кол-во ботанов(задротов): {sum}");


Console.WriteLine($"Кто имеет 5: {arr.Count(it => it == 5)}");
*/


/* Z4 .8.
 * Z4 .8.Известны стоимости каждого из восьми предметов в двух наборах.
 * Какой из наборов предметов более дешевый?


List<int> listOfNumbers = new List<int>(8);
List<int> secondListOfNumbers = new List<int>(8);
Random rnd = new Random();
int j = 0;
int k = 0;
}
if (listOfNumbers.Sum() > secondListOfNumbers.Sum())
{
    Console.WriteLine("Второй набор носков более дешёвый, бери его!");
}
else if (listOfNumbers.Sum() < secondListOfNumbers.Sum())
{
    Console.WriteLine("Первый набор носков более дешёвый, бери его!");
}
else if (listOfNumbers.Sum() == secondListOfNumbers.Sum())
{
    Console.WriteLine("Тут что-то не так, они почему-то равны! Решай сам хехе: (`-|_|-) ");
}
else
{
    Console.WriteLine("ERROOOOOOOOR!");
}
*/


/* Y2.2. Раньше в соревнованиях по фигурному катанию спортсмены выступали в трёх видах многоборья 
 * (обязательная, короткая и произвольная программы). Известны результаты (в баллах) каждого из 15 участников соревнований.
 * Организовать ввод информации по этой таблице и определить:
 * а) среднее кол-во баллов, полученных каждым спортсменом;
 * б) среднее кол-во баллов, полученных по каждому виду программы;
 */


//Random rnd = new Random();
//int j = 1;
//int[] numArray = new int[15];
//string[] arrayBox = new string[4] { "Спортсмен", "Обязательная", "Короткая", "Произвольная" };

//for (int i = 0; i < 15; i++)
//{
//    numArray[i] = j;
//    j++;
//}
//foreach (string b in arrayBox)
//{
//    Console.Write($"{b} \t");
//}
//Console.WriteLine("\n");
//List<string> list = new List<string>();
//foreach (int c in numArray)
//{
//    Console.Write($"\n {c} \t \t ");
//    list.Add(Console.Read() + "");
//    Console.Write(" \t ");
//    list.Add(Console.Read() + "");
//    Console.Write(" \t ");
//    list.Add(Console.Read() + "");
//}

// 2 + 4 * (1 / 3) + 2 * (10 + 5)


// 2 + 4 * A + 2 * B
// 2 + C + D

// + 2 C D

// + 2 (* 4 A) (* 2 B)
// + 2 (* 4 ( / 1 3)) (* 2 (+ 10 5))

// + ( * ( / ) ) ( * ( + ) )
// 2 4 1 3 2 10 5

// + ( * ) ( * ( + ) )
// 2 4 0.2 2 10 5


using Tasks;
using Tasks.generics.Model;
using Tasks.generics.Repo;

//var person = new Person(23);
//person.Method();

//var person2 = new Person(50);

//var iPhone = new Phone(Color.Blue, 10, "China");
//string info = iPhone.GetInfo();
//Console.WriteLine(info);


//var iPhone = new Phone
//{
//    Color = Color.Pink,
//    Price = 10000,
//    Manufacturer = "China",
//};

//string info = iPhone.GetInfo();
//Console.WriteLine(info);
//Console.WriteLine(iPhone.IsKytay);


var repo = new GenericRepo<User>();

User foundById = repo.GetById("1");
Console.WriteLine(foundById?.Name);

repo.Insert(new User { Id = "1", Name = "Vasya" });
repo.Insert(new User { Id = "2", Name = "Tolya" });

User foundById2 = repo.GetById("1");
Console.WriteLine(foundById2.Name);

repo.Delete("1");

User foundById3 = repo.GetById("1");
Console.WriteLine(foundById3.Name);