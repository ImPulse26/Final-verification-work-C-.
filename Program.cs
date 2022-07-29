string[] SearchStringsWithLimitedNumberSymbols(string[] array, int maxLength)
{
    int countString = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            countString++;
        }
    }
    string[] newArray = new string[countString];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            countString--;
            newArray[countString] = array[i];
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    System.Console.Write($"[ ");
    if (array.Length == 0)
    {
        System.Console.WriteLine("]");
    }
    else
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write($"{array[i]}, ");
        }
        System.Console.Write($"{array[array.Length - 1]} ]");
    }
}

string[] myArray = new string[] { "hello", "2", "world", ":-)", "1234", "156", "-2", "Rus", "Denmark", "Kazan" };
int maxLength = 3;
PrintArray(myArray);
System.Console.Write(" => ");
string[] secondMyArray = SearchStringsWithLimitedNumberSymbols(myArray, maxLength);
PrintArray(secondMyArray);

