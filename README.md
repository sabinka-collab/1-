Console.WriteLine("Введите время");
double t = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите скорость");
double v = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ускорение");
double a = Convert.ToDouble(Console.ReadLine());
double s = v * t + (a * Math.Pow(t, 2) / 2); //Формула расстояния при равносильном ускорении
Console.WriteLine($"Расстояние равно = {s}");
