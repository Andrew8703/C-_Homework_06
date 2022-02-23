// Задача 44: Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
Console.Clear();
int b1 = new Random().Next(-10, 10); Console.Write("b1 = " + b1 + " ");
int k1 = new Random().Next(-10, 10); Console.Write("k1 = " + k1 + " \n");
int b2 = new Random().Next(-10, 10); Console.Write("b2 = " + b2 + " ");
int k2 = new Random().Next(-10, 10); Console.Write("k2 = " + k2 + " \n");
double y;
/* x находим из системы уравнений k1 * x + b1 = k2 * x + b2 */
double x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;
y = k2 * x + b2;
Console.WriteLine($"Точка пересечения двух прямых x = {x} , y = {y}");

