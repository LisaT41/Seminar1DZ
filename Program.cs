// 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9


System.Console.Write("Write first number");
string value;
value = Console.ReadLine();
int numberA = Convert.ToInt32(value);

System.Console.Write("Write second number");
value = Console.ReadLine();
int numberB = Convert.ToInt32(value);

if (numberA > numberB)
{
    System.Console.WriteLine($"{numberA} - max, {numberB} - min");
}
else if (numberA < numberB)
{
    System.Console.WriteLine($"{numberB} - max, {numberA} - min");
}
else if (numberA == numberB)
{
    System.Console.WriteLine("numbers is same");
}