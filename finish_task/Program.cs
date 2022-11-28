int ArrayNewSize(string[] array, int symbol)
{
    int count = 0;                              
    for(int i = 0; i<array.Length; i++)
        if (array[i].Length<=symbol)
            count++;
    return count; // подсчет длины нового массива
}
void ArrayLimitation(string[] array,string[] NewArray,int symbol)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
        if (array[i].Length<=symbol)
            {
            NewArray[count] = array[i];
            count++;
            }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for(int i = 0; i<array.Length; i++) 
    {
        Console.Write($"\"{array[i]}\"");
            if(i<array.Length-1)
                Console.Write(", ");
    }
    Console.Write("]");
}

Console.Clear();

const int symbol = 3;       //Условние задачи:  массив из строк, длина которых меньше либо равна 3 символа.
string []array = {"hello", "2", "world", ":-)",
"1234", "1567", "-2", "computer science","Russia", "Denmark", "Kazan"}; // Первоначальный массив можнозадать на старте выполнения алгоритма.

string []NewArray = new string[ArrayNewSize(array,symbol)];
ArrayLimitation(array,NewArray,symbol);

Console.WriteLine("Массив изначальный: ");
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Массив из строк длина которых меньше либо равна трём символам: ");
PrintArray(NewArray);

Console.WriteLine();
Console.WriteLine($"Размер первого массива: {array.Length}");
Console.WriteLine($"Размер второго массива: {NewArray.Length}");

Console.ReadKey();

