// string Metod4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Metod4(10, "are");
// Console.WriteLine(res);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1, };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i= 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}


PrintArray(arr);

