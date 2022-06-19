Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number<100)
{
    Console.WriteLine("третьей цифры нет");
}
// if(number>99 $$ number<1000 )
// {
//     Console.WriteLine(number%10);
// }
// else{
//     string number1=number.ToString();
//     Console.WriteLine(number1[2]);
// }
else
{
    while(number>999)
    {number=number/10;
    }
    Console.WriteLine(number%10);
}