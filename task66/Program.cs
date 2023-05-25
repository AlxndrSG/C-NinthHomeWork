// Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int firstNumber = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int secondNumber = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");

int result = SumNaturalNumbers(firstNumber, secondNumber);
Console.WriteLine($"M = {firstNumber}, N = {secondNumber} -> {result}");

int SumNaturalNumbers(int numM, int numN)
{
    if (numM == numN)
    {
        return numN;
    }
    else return numM + SumNaturalNumbers(numM + 1, numN);
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
