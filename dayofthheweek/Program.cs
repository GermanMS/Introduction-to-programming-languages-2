Console.WriteLine("ввести день недели числом от 1 до 7");

int number = Convert.ToInt32(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("сегодня рабочий понедельник");
}
if(number == 2)
{
    Console.WriteLine("сегодня рабочий вторник");
}

if(number == 3)
{
    Console.WriteLine("сегодня рабочая среда");
}
if(number == 4)
{
    Console.WriteLine("сегодня рабочий четверг");
}
if(number == 5)
{
    Console.WriteLine("сегодня рабочая пятница");
}
if(number == 6)
{
    Console.WriteLine("сегодня выходной суббота");
}
if(number == 7)
{
    Console.WriteLine("сегодня выходной воскресенье");
}
if(number >=8)
{
     Console.WriteLine("введено неверное число");
}
