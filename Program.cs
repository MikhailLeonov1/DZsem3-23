// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int cube = ReadInt("Введите N: ");  // Ввод N


for (int i = 1; i <= cube; i++)  // Цикл

{
    Console.Write($"{i * i * i} "); // Вывод кубов чисел
}

int ReadInt(string message) // Функция для ввода числа

{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}