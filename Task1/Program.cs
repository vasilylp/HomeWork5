// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
//----------------Решение---------------------------------------------------------

int[] CreateArrey(int sizeArr, int leftRangeArr, int rightRangeArr)
{
              int[] array = new int[sizeArr];
              Random rand = new Random();

              for (int i = 0; i < array.Length; i++)
              {
                            array[i] = rand.Next(leftRangeArr, rightRangeArr + 1);
              }
              return array;
}

void printArray(int[] array)
{
              System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}

int EvenNumber(int[] array)
{
              int evenNum = 0;
              for (int i = 0; i < array.Length; i++)
              {
                            if (array[i] % 2 == 0)
                            {
                                          evenNum += 1;
                            }
              }
              return evenNum;
}

void printEvenNumber(int evenNum)
{
              System.Console.WriteLine($"Четных чисел в массиве : {evenNum} ");
}

int[] newArray = CreateArrey(6, 100, 1000);
printArray(newArray);
int evenNum = EvenNumber(newArray);
printEvenNumber(evenNum);

