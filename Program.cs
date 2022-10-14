// See https://aka.ms/new-console-template for more information
Console.Write("Введете по порядку 3 числа, сначала первое: ");
string? sNum1 = Console.ReadLine();

Console.Write("Теперь второе: ");
string? sNum2 = Console.ReadLine();

Console.Write("Теперь третье: ");
string? sNum3 = Console.ReadLine();

int num1 = Convert.ToInt32(sNum1);
int num2 = Convert.ToInt32(sNum2);
int num3 = Convert.ToInt32(sNum3);

int max = num1;
if (num2 > max)
    max = num2;
if (num3 > max)
    max = num3;

Console.WriteLine($"Наибольшее число {max}");
