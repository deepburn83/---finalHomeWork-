// 2-й вариант решения задачи без использования функций (методов).

Console.WriteLine("Введите значения через запятую: ");
string input = Console.ReadLine()!;
string[] inputArray = input.Split(",");

string[] outputArray = new string[inputArray.Length];
int outputIndex = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    string trimmed = inputArray[i].Trim();
    if (trimmed.Length <= 3)
    {
        outputArray[outputIndex] = trimmed;
        outputIndex++;
    }
}
if (outputIndex == 0)
{
    Console.WriteLine("Все введенные данные больше трех символов.");
}
else
{
    string[] finalOutput = new string[outputIndex];
    Array.Copy(outputArray, finalOutput, outputIndex);

    Console.Clear();
    Console.WriteLine($"[{string.Join(", ", inputArray)}] -> [{string.Join(", ", finalOutput)}]");
}