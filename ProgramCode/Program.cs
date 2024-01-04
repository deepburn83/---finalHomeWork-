int maxLength = 3;

string input = InputMessage("Введите любые значения (слова, числа, символы) через запятую: ");
string[] newArray = input.Split(',');

int sizeResult = SizeNewArray(newArray, maxLength);

if (sizeResult == 0)
{
    Console.Clear();
    Console.WriteLine($"[{string.Join(", ", newArray)}] - Все введённые строки содержат более 3 (трёх) символов.");
}
else
{
    string[] result = ResultArray(newArray, maxLength, sizeResult);
    Console.Clear();
    Console.WriteLine($"[{string.Join(", ", newArray)}] -> [{string.Join(", ", result)}]");
}

string InputMessage(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine()!;
}

int SizeNewArray(string[] array, int length)
{
    int sizeNewArray = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Trim().Length <= length)
        {
            sizeNewArray++;
        }
    }

    return sizeNewArray;
}

string[] ResultArray(string[] array, int length, int size)
{
    string[] outputArray = new string[size];
    int outputIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        string trimmed = array[i].Trim();
        if (trimmed.Length <= length)
        {
            outputArray[outputIndex] = trimmed;
            outputIndex++;
        }
    }

    return outputArray;
}