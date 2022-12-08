// программа, которая принимает на вход пятизначное число и 
//проверяет, явлеется ли оно палиндромом

  {
    Console.WriteLine ("Введите пятизначное число:");

                    //проверка на ввод букв
    string number = Convert.ToString(Console.ReadLine());
    bool result = int.TryParse (number, out int B);
    if (result == false)
    { 
        Console.WriteLine ("введите цифры");
        Environment.Exit(0);
    }

    int len = number.Length;
     
     if (len == 5)
      {
       if (number[0] == number[4] && number[1] == number[3])
          Console.WriteLine($"{number} -палиндром");
    else
        Console.WriteLine ("не палиндром");
       }
    if (len > 5 || len < 4) 
       {
    Console.WriteLine($"{number} -ошибка -введите пятизначное число");
       }
  }