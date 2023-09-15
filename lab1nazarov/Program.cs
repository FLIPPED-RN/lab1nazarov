//Высокий уровень
Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());

double K = (Math.Sqrt(x + b - a) + Math.Log(y)) / (Math.Atan(b + a));
Console.WriteLine($"K = {K:F2}");