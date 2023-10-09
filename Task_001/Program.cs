// Задание 1:
//Напишите программу, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число:");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int NumberB = Convert.ToInt32(Console.ReadLine());

if ( NumberA == NumberB) 
{
    Console.WriteLine($"Введенные числа равны {NumberA}");
}
if (NumberA > NumberB) 
{
    Console.WriteLine($" Первое число {NumberA}  больше чем второе число {NumberB}");
}
if (NumberA < NumberB) 
{
    Console.WriteLine($"Первое число {NumberA} меньше чем второе число {NumberB}");
}