Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a >= 100)
{
    if (a < 1000)
    {
        a = a % 10;
       Console.WriteLine (a + " - третье число" );
    }
    else
    {
      while (a > 1000)
      {
        a = a / 10;
      }
     Console.WriteLine (a % 10 + " - третье число"); 
    }
}
else 
{
    Console.WriteLine ("Нет третьего числа");
}