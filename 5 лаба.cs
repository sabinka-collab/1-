Console.WriteLine("Введите число");
int Z=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int [] rem= new int[N];
for (int i = 0; i < N; i++) {
    Console.WriteLine("Введите элемент массива");
    rem [i] = Convert.ToInt32(Console.ReadLine());
}
int r = 0;
for (int i = 0; i < N; i++)
{
    if (rem[i] > Z)
    {
        rem[i] = Z;
        r++;
    }
}
Console.WriteLine(r);
