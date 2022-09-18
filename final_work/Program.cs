Console.Write("Enter the size of array:");
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

PrintArr(arrstring);