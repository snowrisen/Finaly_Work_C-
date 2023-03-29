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

string[] array = { "Vlad", "Alex", "Tom", "Io", "Petkevich" };
Print1DArray(array);

string[] GenSearchArray(string[] array, int count)
{
    string[] res = new string[0];
    for (int i = 0; i <= array.Length; i++)
    {
        if (array[i].Length <= count)
        {
            res = res.Concat(new string[] { array[i] } ).ToArray();
        }
    }
    return res;
}
