string[] array1 = new string[3] { "cherry", "feather", "wonderland"};
string[] array2 = new string[array1.Length];

NewArrayString(array1, array2);
Console.Write("[");
PrintArray(array2);
Console.WriteLine("]");


void NewArrayString(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}








