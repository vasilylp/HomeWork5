// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

//-------------------------Решение-----------------------------------------------

string[] NewArray(int sizeArr, int rangeArr)
{
              string[] array = new string[sizeArr];
              Random rand = new Random();
              int i = 0;
              while (i < sizeArr)
              {

                            int num = rand.Next(0, rangeArr);
                            array[i] = Convert.ToString(Convert.ToInt32(num));
                            i++;
              }
              return array;
}

void PrintArray(string[] array)
{
              Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}

int SumOddPosition(string[] array)
{
              int sumOdd = 0;
              for (int i = 0; i < array.Length; i++)
              {
                            if (i == 0 || i % 2 == 0)
                            {
                                          sumOdd = sumOdd + Convert.ToInt32(Convert.ToString(array[i]));
                            }
              }
              return sumOdd;
}

void PrintSumOdd(int sumOdd)
{
              System.Console.WriteLine($"Сумма чисел массива на нечетных позициях начиная с 0 -> {sumOdd}");
}

string[] newArray = NewArray(8, 10);
PrintArray(newArray);
int sumOdd = SumOddPosition(newArray);
PrintSumOdd(sumOdd);
