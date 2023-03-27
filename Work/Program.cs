//Вывод массива в консоль
void Print1DArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

string [] array ={"Vlad","Alex","Tom","Io"};
Print1DArray(array);