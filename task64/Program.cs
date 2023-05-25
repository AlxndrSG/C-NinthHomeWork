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
