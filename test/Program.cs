Console.WriteLine("Введите значения массива через пробел");
string[] str = Console.ReadLine().Split();
int originalArrLength = str.Length;
string[] result = new string[originalArrLength];

string[] FillResultArray(string[] array, string[] resArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        resArray[i] = array[i]; 
    }
    return result;
}

void PrintResult(string[] array)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


FillResultArray(str, result);
PrintResult(result);

