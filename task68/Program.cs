// Напишите программу вычисления функции Аккермана с 
//помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int firstNumber = GetNumberFromUser("Введите число m: ", "Ошибка ввода!");
int secondNumber = GetNumberFromUser("Введите число n: ", "Ошибка ввода!");

int result = FunctionAkkerman(firstNumber, secondNumber);
Console.WriteLine($"m = {firstNumber}, n = {secondNumber} -> A(m,n) = {result}");

int FunctionAkkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0)
    {
        return FunctionAkkerman(numM - 1, 1);
    }
    else return FunctionAkkerman(numM - 1, FunctionAkkerman(numM, numN - 1));
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