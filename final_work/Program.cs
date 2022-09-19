Console.Write("Enter the size of an array:");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrstring = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Enter {i+1} element of array pls:");
    arrstring[i] = Console.ReadLine();
}
void PrintArr(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
string[] ResizeArray(string[] array)
{
    int length = array.Length;
    string[] tempArray = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            tempArray[j] = array[i];
            j++;
        }
    }
    string[] resArray = new string[j];

    for (int i = 0; i < j; i++)
    {
        resArray[i] = tempArray[i];
    }
    return resArray;
}
Console.Write("Current array =>");
PrintArr(arrstring);
string[] res = ResizeArray(arrstring);
Console.WriteLine();
Console.Write("new array =>");
PrintArr(res);