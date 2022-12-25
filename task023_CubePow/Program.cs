// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

//Console.SetBufferSize (Int32.MaxValue - 1, Int32.MaxValue - 1);

Console.SetCursorPosition (10,2);
Console.WriteLine("Таблица кубов от 1 до N");
Console.SetCursorPosition (10,4);

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введенное значение не является числом");
            //Console.SetCursorPosition(10,Console.CursorTop+1);
        }
    }

    return result;
}

double[] GetPow(int x)
{
    double[] mass = new double[x];

    for (int index = 0; index < x; index++)
    {
        mass[index] = Math.Pow(index+1, 3);
        
    }
    return mass;    
}

int result = GetNumber("Введите число:  ");
//Console.SetCursorPosition(10,Console.CursorTop+1);


double[] massPow = GetPow(result); 

for (int i = 0; i < massPow.Length; i++)
{
    //Console.SetCursorPosition(10,Console.CursorTop+1);
    Console.WriteLine($"Третья степень числа {i+1} равна: {massPow[i]}");
   // Console.SetCursorPosition(10,Console.CursorTop+1);
}

//Console.SetCursorPosition(10,Console.CursorTop+1);

Console.Write("* * *");
