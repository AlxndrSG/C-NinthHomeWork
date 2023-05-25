// Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1.

Console.Clear();

int number = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");

string result = DescendingNaturalNumbers(number, 1);
Console.WriteLine($"N = {number} -> {result}");

string DescendingNaturalNumbers(int num, int end)
{
    if (num == end)
    {
        return num.ToString();
    }
    else return DescendingNaturalNumbers(num, end + 1) + $" {end}";
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


/*
Console.Clear();

var number = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
var res = GetSumDigits(number);
Console.WriteLine(res);


int GetSumDigits(int num)
{

    if (num == 0) return 0;
    return num % 10 + GetSumDigits(num / 10);

}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
*/
/*
Console.Clear();

int numberA = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
int numberN = GetNumberFromUser("Введите число: ", "Ошибка ввода!");

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    if (n == 1) return a;
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(numberA, numberN));

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
*/