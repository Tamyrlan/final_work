Console.Write("Enter the size of an array:");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrstring = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Enter {i + 1} element of array pls:");
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
string[] FillNewArr(string[] array, int min, int max)
{
    Random rnd = new Random();
    int newSize = rnd.Next(min, max+1);
    string[] newArr = new string[newSize];
    for (int i = 0; i < newSize; i++)
    {
        newArr[i] = array[i];
    }
    return newArr;
}

Console.Write("Current array =>");
PrintArr(arrstring);
string[] newArray = FillNewArr(arrstring, 1, 3);
Console.WriteLine();
Console.Write("new array =>");
PrintArr(newArray);