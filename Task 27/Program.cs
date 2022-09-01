// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear ();
Console.Write ("Введите число ");
string? str = Console.ReadLine();
char[] arr = str.ToCharArray();
int result = 0;
for (int C = 0; C < arr.Length; C++)
{
result = result + (arr [C] + 52 - 100);
}
Console.WriteLine(result);