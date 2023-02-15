// Напишите программу, которая задаёт массив из 8 элементов, которые вводит пользователь, 
// и выводит их на экран.

Console.WriteLine("Введите восемь элементов массива: ");
int [ ] array = Console.ReadLine().Split (" ").Select(x=>int.Parse(x)).ToArray(); 
for (int i=0; i<array.Length; i++)
array [i] = array [i];
if (array.Length<=8) 
Console.WriteLine($"[{string.Join(" , " , array)}]");
else 
Console.WriteLine($"Error!!! Количество элементов массива превышает допустимый размер");
