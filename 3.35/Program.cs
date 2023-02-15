int a, b, c, d, e, f;

do
{
    Console.WriteLine("Введите координаты белой ладьи (от 1 до 8)");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
} while (a <= 1 || a >= 8 || b <= 1 || b >= 8);

do
{
    Console.WriteLine("Введите координаты черного слона (от 1 до 8)");
    c = Convert.ToInt32(Console.ReadLine());
    d = Convert.ToInt32(Console.ReadLine());
} while (c <= 1 || c >= 8 || d <= 1 || d >= 8);

do
{
    Console.WriteLine("Введите координаты хода ладьи (от 1 до 8)");
    e = Convert.ToInt32(Console.ReadLine());
    f = Convert.ToInt32(Console.ReadLine());
} while (e <= 1 || e >= 8 || f <= 1 || f >= 8);


if (a == e || b == f)
{ //проверяю может ли ладья пойти на это поле одним ходом
    if (c - e == d - f || c - e == f - d)
    { //проверяю стоят ли ладья и слон на одной диагонали
        Console.WriteLine("Ладья может пойти на это поле, но попадет под удар слона");
    }
    else
    {
        Console.WriteLine("Ладья может пойти на это поле, и не попадет под удар слона");
    }
}
else
{
    Console.WriteLine("Ладья не может пойти на это поле");
}