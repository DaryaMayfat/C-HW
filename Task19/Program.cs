int a=0;
GetUserNumber(ref a);
Palindrom (a);

static void GetUserNumber (ref int a); 
{
    try
    {
        Console.WriteLine ( "Введите пятизначное число: ");
        a = int.Parse (Console.ReadLine()??"");
    }
    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
static void Palindrom (int a);

if (a%10 == a/10000 && a%10000-a%1000 == a%100-a%10)
{
Console.WriteLine ($"{a} -> да");
}
else 
{
    Console.WriteLine ($"{a} -> нет");
}
