// Задача 41: Пользователь вводит с клавиатуры или задает самостоятельно M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

using System;

void print_array(int [] local_array)  // Функция печати массива
{
    Console.Write("[");  // Выводим красивую скобку
    for(int i=0; i < local_array.Length-1; i++)  // Печатаем все элементы масиива, разделенные запятой, 
    {                                            // кроме последнего элемента
        Console.Write($"{local_array[i]}, ");
    }
    Console.WriteLine($"{local_array[local_array.Length-1]}]");  // Печатаем последний элемент массива со скобкой
}

Console.WriteLine("Выберите 1, 2 или 3:");
Console.WriteLine("1 - Массив заполняется с клавиатуры");
Console.WriteLine("2 - Массив заполняется заданными значениями при программировании");
Console.WriteLine("3 - Массив заполняется случайными значениями");
Console.Write("Введите режим работы: ");

int [] myArray = new int[0];  //объявляем массив пока неопределенного размера

switch (Convert.ToInt32(Console.ReadLine()))  // выбиираем режим работы
{
    case 1: 
        Console.Write("Введите размер массива: ");
        Array.Resize(ref myArray,Convert.ToInt32(Console.ReadLine()));  // изменяем размер массива

        for(int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"Введите значение myArray[{i+1}]:");
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        break;
    case 2: 
        Array.Resize(ref myArray, 10); // изменяем размер массива
        Array.Copy(new int[10] { 1, -3, 5 ,-6, 6, 10, 15, -2, 0, 1},myArray, 10); // заполняем массив
        break;
    case 3: 
        Random rnd = new Random();  // все случайно
        myArray = new int[rnd.Next(1,26)];
        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = rnd.Next(-20,21);
        }
        break;
    default:  // защита от неадекватов
        Console.WriteLine("Введен неверный режим работы! Выход.");
        Environment.Exit(0); // принудительный выход из программы
        break;
}

Console.WriteLine("Исходный массив:");
print_array(myArray);
int myCount = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i]>0) { myCount++; }  // элементарный подсчет
}
Console.WriteLine($"В массиве {myCount} значений больше 0.");
