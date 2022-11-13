string[] ar1 = new string[7] {"florida", "15874", "98531", "11", "non", "old", "result"};
string[] ar2 = new string[ar1.Length];
void Newarray(string[] ar1, string[] ar2)
{
    int count = 0;
    for (int i = 0; i < ar1.Length; i++)
    {
    if(ar1[i].Length <= 3)
        {
        ar2[count] = ar1[i];
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
Newarray(ar1, ar2);
PrintArray(ar2);