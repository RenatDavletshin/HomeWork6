// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввел пользователь.

Console.Write($"Введите число М(количество чисел): ");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[M];

void InputNumbers(int M)
{
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if (massiveNumbers[i] > 0) 
    count++; 
  }
  return count;
}

InputNumbers(M);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");