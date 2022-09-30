//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] StringArray()
{
    Console.Write("Enter the size of string massive: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] newArr = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter the {i + 1} element of massive: ");
        newArr[i] = Console.ReadLine();
    }
    return newArr;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


string[] SortStringArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;

        }
        else newArray[count] = string.Empty;
        
    }
    return newArray;
}
Console.Clear();
string[] myArray = StringArray();
Console.Write("Initial massive: ");
ShowArray(myArray);
Console.Write("New massive:");
string[] myArray2 = SortStringArray(myArray);
ShowArray(myArray2);