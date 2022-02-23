// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
Console.Clear();
Console.Write("Пожалуйста, введите числа для анализа через пробел: ");
string[] s = Console.ReadLine().Split(" ");
int count = 0;
Console.WriteLine(s);
for (int i = 0; i < s.Length; i++)
{
    int a = Convert.ToInt32(s[i]);
    if (a > 0) count = count + 1;
}
Console.WriteLine("Кол-во чисел больше НОЛЯ, введенных пользователем: " + count);
