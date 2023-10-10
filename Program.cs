string[] arrayOne = new string[5] {"Кто", "сказал", "мяу", "?", "!"};
string[] arrayTwo = new string[arrayOne.Length];

void ArrayOfThreeElements(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= 3)
        {
        arrayTwo[count] = arrayOne[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ArrayOfThreeElements(arrayOne, arrayTwo);
PrintArray(arrayTwo);

