Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int s = 0;
    int[] Value= new int[x];
for (int p = 0; p < x; p++) {
    p = Convert.ToInt32(Console.ReadLine());
}
//int i = 0;
for (int k = 0; k < x; k++)
{
    if (Value[k] > s)
    {
        Value[k] = s;
        s++;
    }
}
Console.WriteLine(Value);
Console.WriteLine(s);
