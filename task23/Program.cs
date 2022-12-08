//программа, которая принимает на вход число N и выдает
// таблицу кубов числе от 1 до N
{
Console.WriteLine (" Введите число N");
double N;
link1:
link2:


if ((double.TryParse(Console.ReadLine(), out N))) 
    if (N <= 0)
    {
    Console.WriteLine ("Ошибка! Введите число больше 0 ");  
    goto link2; 
    }
    
    else

    for (int i=1; i<=N; i++)
        {
            Console.WriteLine($"{i*i*i} ");
        }
else
    {
        Console.WriteLine ("Ошибка! Введите число!");
        goto link1;
    }
}
