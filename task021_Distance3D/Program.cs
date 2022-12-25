// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.SetCursorPosition (10,1);

Console.WriteLine("Определение расстояния между двумя точками в 3D пространстве");

int GetNumber(string message) // Задаем функцию ввода нужного числа. тип данных integer
{
    int result = 0;

    while(true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);
            Console.WriteLine("Повторите ввод! Координаты задаются целым числом");
            Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);
        }
    }

    return result;
}

Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+2);

Console.WriteLine("Задайте координаты точки А - ");
int x1 = GetNumber("введите абциссу,  x1: ");
int y1 = GetNumber("введите ординату, y1: ");
int z1 = GetNumber("введите апликату, z1: ");
Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);

Console.WriteLine("Задайте координаты точки В - ");
int x2 = GetNumber("введите абциссу,  x2: ");
int y2 = GetNumber("введите ординату, y2: ");
int z2 = GetNumber("введите апликату, z2: ");
Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);

double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));

Console.WriteLine($"Расстояние между точками с координатами А ({x1},{y1},{z1}) и В ({x2},{y2},{z2}) равно:   {result}");


Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);

Console.Write("* * *");