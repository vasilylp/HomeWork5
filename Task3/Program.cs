// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76
//-----------------------Решение---------------------------------------------

double[] CreateArray(int sizeArray, int leftSide, int rightSide)
{
              double[] array = new double[sizeArray];
              Random rand = new Random();
              for (int i = 0; i < array.Length; i++)
              {
                            array[i] = Math.Round(rand.Next(leftSide, rightSide) + rand.NextDouble(), 2);
              }
              return array;
}

void PrintArray(double[] array)
{
              System.Console.WriteLine("[" + String.Join("; ", array) + "]");
}





double DifferrenceMaxMin(double[] array)
{
              double max = array[0];
              double min = array[0];
              for (int i = 1; i < array.Length; i++)
              {
                            if (array[i] < min)
                            {
                                          min = array[i];
                            }
                            else if (array[i] > max)
                            {
                                          max = array[i];
                            }
              }
              double diffMaxMin = Math.Round(max - min, 2);
              return diffMaxMin;

}

void PrintDifferenceMaxMin(double difference)
{
              System.Console.Write($"Разница между Мах и Мин числами массива : {difference}");
}


double[] newArray = CreateArray(5, -10, 10);
PrintArray(newArray);
double diffMaxMin = DifferrenceMaxMin(newArray);
PrintDifferenceMaxMin(diffMaxMin);

