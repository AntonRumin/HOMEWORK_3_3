// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// На вход поступает пятизначное число. 

Console.Clear();

Console.SetCursorPosition (10,2);

Console.WriteLine("ЯВЛЯЕТСЯ ЛИ ЧИСЛО ПАЛИНДРОМОМ");



int GetNumber(string message) // задаем функцию ввода нужного числа. тип данных integer
{
    int result = 0;

    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 9999 && result <100000) // возможен иной вариант подсчета количества цифр
        {
            break;
        }
        else
        {
            Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);
            Console.WriteLine("Введенное число не удовлетворяет условиям задачи");
            Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);
        }
    }

    return result;
}

Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);

int num = GetNumber("Введите пятизначное число: "); // Предполагается, что пользователь знает, что пятизначное число должно быть целым

Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);

if (num/10000 == num%10 && num/1000%10 == num%100/10)
{
    Console.WriteLine("Число {0} - Палиндром!", num); // Иной вариант форматирования

}
else
{
    Console.WriteLine("Число: {0} - НЕ Палиндром!", num );

}


Console.SetCursorPosition(Console.CursorLeft+10,Console.CursorTop+1);

Console.Write("* * *");