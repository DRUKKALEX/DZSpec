// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивам
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
    
string[] array = { "Hello", "2", "world", ":-)" };
int maxnum = 3;

string[] FillArray(string[] array)
{
    
    string[] result = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxnum)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    foreach (string el in array)
        Console.Write($"{el}  ");
    Console.WriteLine();
}

string[] NewArray = FillArray(array);
PrintArray(NewArray);