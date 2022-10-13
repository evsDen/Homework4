// // Задача 25
// Console.Clear();
// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int s = a;

// for (int i = 1; i < b; i++)
// {
// s = s * a;
// }
// Console.WriteLine($"A в степени В равно: {s}");

// // Задача 27
// Console.Clear();
// Console.WriteLine("Bведите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (a > 0)
// {
//    int n = a % 10;
//    a = a / 10;
//    sum = sum + n; 
// }
// Console.WriteLine($"Сумма всех цифр числа: {sum}");


// // Задача 29
// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"[{string.Join(", ", array)}]");
