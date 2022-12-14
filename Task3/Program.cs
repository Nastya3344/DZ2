Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

 if(a % 7 == 0)
    {
        Console.WriteLine("Кратное 7");
    }
else
    {
        int result = a % 7 ;
        Console.WriteLine("Не кратное 7,остаток равен " + result);
    }
if(a % 23 == 0)
    {
        Console.WriteLine("Кратное 23");
    }
    else
    {
        int result = a % 23 ;
        Console.WriteLine("Не кратное 23,остаток равен " + result);
    }
