Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
{
  if (a == 6 || a == 7) 
  {
  Console.WriteLine("{0} выходной день", a);
  }
  else if (a < 1 || a > 7) 
  {
    Console.WriteLine("{0} не день недли", a);
  }
  else Console.WriteLine("{0} рабочий день", a);
}

