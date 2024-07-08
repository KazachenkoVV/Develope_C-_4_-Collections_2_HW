// Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу. 
// Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два 
// числа равных по сумме первому.

namespace C__HomeWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 3, 2, 1, 17, 9, 25, 13, 31, 8, 14, 48, 11, 5, 24, 17, 46 };
            int sum = 51;

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < ints.Length - 2; i++)
            {
                int addition = sum - ints[i];
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (set.Contains(addition - ints[j]))
                    {
                        Console.WriteLine($"Искомые числа: {ints[i]} + {ints[j]} + {addition - ints[j]} = {sum}");
                        return;
                    }
                    else
                        set.Add(ints[j]);
                }
                set.Clear();
            }
            Console.WriteLine($"Исходный массив не содержит чисел, в сумме дающих {sum}");
        }
    }
}
