bool inWork = true;

while (inWork)
{
    Console.Write("Выбери задачу ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1: // программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            {
                Console.WriteLine("программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
                Console.WriteLine("Ввидите 1 число");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ввидите 2 число");
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("Max = " + a);
                }
                else 
                {
                    Console.WriteLine("Max = " + b);
                }
             break;
            }
            case 2: //программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            {
                Console.WriteLine("программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел");
                Console.WriteLine("Ввидите 1 число");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ввидите 2 число");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Ввидите 3 число");
                int c = int.Parse(Console.ReadLine());
                var Max = a;
                if (Max < b)
                {
                    Max = b;
                    if (Max < c)
                    {
                        Max = c;
                        Console.WriteLine("Max = " + Max);
                    } 
                    else
                    {
                        Console.WriteLine("Max = " + Max);
                    }
                } 
                else if (Max < c) 
                {
                    Max = c; 
                    Console.WriteLine("Max = " + Max);
                }
                else 
                Console.WriteLine("Max = " + Max);
                break;
            }
            case 3: //программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            {
                Console.WriteLine("программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
                Console.WriteLine("Ввидите число");
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                  Console.WriteLine("да"); 
                }
                else
                {
                    Console.WriteLine("нет");
                }
                break;
            }
            case 4: //программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
            {
                Console.WriteLine("программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
                Console.WriteLine("Ввидите число");
                int n = int.Parse(Console.ReadLine());
                var r = 1;
                while (r <= n)
                {
                    if (r % 2 == 0)
                    {
                        Console.Write(r + ", ");
                        r++;
                    }
                    else
                    {
                        r++;
                    }
                }
                break;
            }
            case -1: inWork = false; break;

        }
    }
}
