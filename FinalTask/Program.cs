/* Задача: Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.*/

string[] inputArray = new string[] { "546","hh", "hello", "console", "hi", "full", "abc" };

PrintArray(inputArray);
Console.Write("->");
PrintArray(NewArray(inputArray));

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == null) continue;
        if (i == 0) Console.Write(array[i]);
        else Console.Write(", " + array[i]);
    }
    Console.Write("]");
};

string[] NewArray(string[] array)
{
    string[] outputArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            outputArray[count] = array[i];
            count++;
        }
    }
    return outputArray;
};

