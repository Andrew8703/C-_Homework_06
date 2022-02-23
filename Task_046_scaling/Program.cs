// Написать программу масштабирования фигуры
Console.Clear();
Console.WriteLine("Введите координаты вершин: ");
Console.Write("Ax = "); double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Ay = "); double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Bx = "); double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("By = "); double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Cx = "); double Cx = Convert.ToDouble(Console.ReadLine());
Console.Write("Cy = "); double Cy = Convert.ToDouble(Console.ReadLine());
Console.Write("Dx = "); double Dx = Convert.ToDouble(Console.ReadLine());
Console.Write("Dy = "); double Dy = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты вершин фигуры: A({Ax}.{Ay}) B({Bx}.{By}) C({Cx}.{Cy}) D({Dx}.{Dy})");
Console.Write("Введите масштаб: ");
double k = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты вершин фигуры в масштабе '{k}': A({Ax*k},{Ay*k}) B({Bx*k},{By*k}) C({Cx*k},{Cy*k}) D({Dx*k},{Dy*k})");
