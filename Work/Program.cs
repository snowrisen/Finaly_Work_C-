//Вывод массива в консоль
Console.Clear();
void Print1DArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}


string[] GenSearchArray(string[] array, int count)
{
    string[] res = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= count)
        {
            res = res.Concat(new string[] { array[i] } ).ToArray();
        }
    }
    return res;
}
string[] array = { "Vlad", "Alex", "Tom", "Io", "Petkevich" };
System.Console.WriteLine("Исходный массив:");
System.Console.WriteLine("      ↓↓↓     ");
Print1DArray(array);
System.Console.WriteLine();
string[] arraysearch = GenSearchArray(array,3);
Print1DArray(arraysearch);
System.Console.WriteLine("   🠕🠕🠕");
System.Console.WriteLine("Отсортированный массив:");