//Высокий уровень (2-ое задание)
double C = Math.Pow(10, -6);
double L = 0.04;
int U = 100;

double I = U * Math.Sqrt(C / L);
Console.WriteLine($"I = {I}A");
Console.WriteLine("Далее найдем W - энергию");

double W = (L * (I * I)) / 2;
Console.WriteLine($"И так, W в данной задаче равно {W:F2}J");