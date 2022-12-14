Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

//while(number >= 1000)
//{
   // Console.WriteLine(number%10);
    //if( number < 100)
   // {
  //      Console.WriteLine(" нет цифры ");
   // }

   // if( number < 10000)
   // {
  //    Console.WriteLine(number%100);
  //  }
//}
//

if(number < 1000 )
{
    Console.WriteLine(number%10);
}
else
{
    Console.WriteLine("нет цифры ");
}