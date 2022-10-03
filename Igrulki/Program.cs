while (true)
{
    Console.WriteLine("Выберете игру: ");
    Console.WriteLine("1) Угадай число");
    Console.WriteLine("2) Таблица умножения");
    Console.WriteLine("3) Вывод делителей числа");
    Console.WriteLine("4) Выход");
    int operation_bravo_six = Convert.ToInt32(Console.ReadLine());
    switch (operation_bravo_six)
    {
        case 1:
            Random random = new Random();
            int b = random.Next(0, 100);
            string input;
            Console.WriteLine("Угадай число от 1 до 100");
            do
            {
                input = Console.ReadLine();
                if (int.Parse(input) > b)
                    Console.WriteLine("Ваше число больше");
                if (int.Parse(input) < b)
                    Console.WriteLine("Ваше число меньше");
                
            }
            while (int.Parse(input) != b);
            Console.WriteLine("Вы победили");
            break;

        case 2:
            int[,] r = new int[9, 9]
            {
            {1,2,3,4,5,6,7,8,9},
            
            {2,4,6,8,10,12,14,16,18},

            {3,6,9,12,15,18,21,24,27},

            {4,8,12,16,20,24,28,32,36},

            {5,10,15,20,25,30,35,40,45},

            {6,12,18,24,30,36,42,48,54},

            {7,14,21,28,35,42,49,56,63},

            {8,16,24,32,40,48,56,64,72},

            {9,18,27,36,45,54,64,72,81}

            };
            for (int d = 0; d < r.GetLength(0); d++)
            {
                for (int n = 0; n < r.GetLength(1); n++)
                {
                    if (r[d, n] < 10)
                    {
                        Console.Write(r[d, n] + " _ ");
                    }

                    else

                    {
                        Console.Write(r[d, n] + " _ ");
                    }
                }
            }
                        break;

        case 3:
            Console.WriteLine("Это контент DLC чтобы его получить поставьте мне 5 |;^) ");
            break;




        case 4:
            Console.WriteLine("Удачи на дорогах");
            Environment.Exit(0);

            break;
    }
}