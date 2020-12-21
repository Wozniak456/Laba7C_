using System;

namespace Labka7C
{
    class Program
    {
        static double[] inputArray(char L, int number) // Генерація масиву. 
        {
            double[] array = new double[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write($"Input {L}[{i}]: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            return array;
        }
        static double maxValueFunc(in double[] array, out int n) // Знаходження найбільшого елемента масиву і його індекса
        {
            double max_value = array[0];
            int i_m = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max_value)
                {
                    max_value = array[i];
                    i_m = i;
                }
            }
            Console.WriteLine($"The max value is: {max_value}, the index of the max value is {i_m}");
            n = i_m;
            return max_value;
        }

        
        static double[] buildArrayC(double[] arrayA, double[] arrayB) // Побудова масиву С
        {
            double[] array = new double[arrayA.Length];
            for (int i = 0; i < arrayA.Length; i++)
            {
                array[i] = Math.Abs(arrayA[i] * arrayA[i] - arrayB[i] * arrayB[i]);
            }
            return array;
        }
        static void printArray(char L, double[] array) // Виведення масиву
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{L}[{i}] = {array[i]}");
            }
        }
        static double Serednie(double[] array) // Знаходження середнього значення
        {
            double s = 0; double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            result = s / array.Length;
            Console.Write($"The average value of array: {result}\n");
            return result;
        }
        static void Main(string[] args)
        {
            int maxElemIndex = 0;
            Console.Write("Input the amount of elements of the array: ");
            int elementsCount = Convert.ToInt32(Console.ReadLine());
            double[] array_A = inputArray('A', elementsCount);
            Console.WriteLine();
            double[] array_B = inputArray('B', elementsCount);
            double[] array_C = buildArrayC(array_A, array_B);
            Console.WriteLine("\nArray C: ");
            printArray('C',array_C);
            double maxValue = maxValueFunc(array_C, out maxElemIndex);
            array_C[maxElemIndex] = Serednie(array_C);
            Console.WriteLine("\nNew array C: ");
            printArray('C', array_C);
        }
    }
}



