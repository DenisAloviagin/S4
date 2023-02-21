internal class Program
{
    private static void Main(string[] args)
    {
        int Prompt(string message, string readInput)
        {
            System.Console.Write(message);
            string ReadInput = System.Console.ReadLine();
            int result = int.Parse(ReadInput);
            return result;
        }

        int[] GenerateArray(int Length, int minValue, int maxValue);
        {
            int[] array = new int[Length];
            Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        void PrintArray(int[] array)
        {
            System.Console.Write("[");
            for (int i = 0; i < array.Length - 1; i++)
            {
                System.Console.Write($"{array[i]}, ");
            }
            System.Console.Write($"{array[array.Length - 1]}");
            System.Console.WriteLine("]");
        }

        int Length = Prompt("Длина массива: ", ReadInput);
        int min = Prompt("Начальное значение, для диапазона случайного числ: ", ReadInput);
        int max = Prompt("Конечное значение, для диапазона случайного числа: ", ReadInput);
        int[] array = GenerateArray(Length, min, max);

        PrintArray(array);
    }
}