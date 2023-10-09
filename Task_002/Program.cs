// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine ("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число:");
int C = Convert.ToInt32(Console.ReadLine());

int result = A;

if (B > result)
{
result = B;
}
if (C > result)
{
result = C;
}
    Console.WriteLine($"Максимальное число `{result}`");
