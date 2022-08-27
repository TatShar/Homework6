// Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Ведите значение b1: ");
        int b1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
        int k1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
        int b2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
        int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Спасибо, начинаю вычисление точки пересечения");
        
        if (b2==b1||k2==k1)
        {
            Console.Write("Прямые совпадают");
        }
        else if (k2==k1)
        {
            Console.Write("Прямые параллельны");
        }
        else
        {
        int x= (b2-b1)/(k2-k1);
        int y = k1*x+b1;
        Console.WriteLine($"координаты точки пересечения: {x};{y}");
        }

         



