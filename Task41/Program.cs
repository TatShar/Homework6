// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write ("Какое количество числе вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"Введите значение элемента номер {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());  
            
         if (array[i]>0)  
         {
            count=count+1;
         }
         else count=count;
    }
        Console.Write (count);





