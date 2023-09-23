namespace Dz4
{
    // Написать скрипт для расчета корреляции Пирсона между
    // двумя случайными величинами (двумя массивами). Можете
    // использовать любую парадигму, но рекомендую использовать
    // функциональную, т.к. в этом примере она значительно
    // упростит вам жизнь.
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] array1 = new double[] { 24, 27, 26, 21, 20, 31, 26, 22, 20, 18, 30, 29, 24, 26 };
            double[] array2 = new double[] { 100, 115, 117, 119, 134, 94, 105, 103, 111, 124, 122, 109, 110, 86 };

            const double result = -0.421;
            double value = Math.Round(Calculator.Calc(array1, array2), 3);

            Console.WriteLine(result == value);
            Console.WriteLine($"value = {value}");

        }
    }

    class Calculator
    {
        internal static double Calc(double[] arrayX, double[] arrayY)
        {
            if (arrayX.Length != arrayY.Length)
            {
                throw new Exception("Массивы разной длины.");
            }

            var avgX = arrayX.Average();
            var avgY = arrayY.Average();

            var arrDeltaX = GetDeltaArray(arrayX, avgX);
            var arrDeltaY = GetDeltaArray(arrayY, avgY);

            var arrDeltaXSqrt = GetSqrtArray(arrDeltaX);
            var arrDeltaYSqrt = GetSqrtArray(arrDeltaY);

            var dividend = GetMultiArray(arrDeltaX, arrDeltaY).Sum();
            var devider = Math.Sqrt(arrDeltaXSqrt.Sum() * arrDeltaYSqrt.Sum());

            var result = dividend / devider;
            return result;
        }

        private static double[] GetDeltaArray(double[] arr, double average)
        {
            List<double> result = new(arr.Length);
            foreach (var item in arr)
            {
                result.Add(item - average);
            }

            return result.ToArray();
        }

        private static double[] GetSqrtArray(double[] arr)
        {
            List<double> result = new(arr.Length);
            foreach (var item in arr)
            {
                result.Add(item * item);
            }

            return result.ToArray();
        }

        private static double[] GetMultiArray(double[] arr1, double[] arr2)
        {
            List<double> result = new(arr1.Length);
            for (int i = 0; i < arr1.Length; i++)
            {
                result.Add(arr1[i] * arr2[i]);
            }

            return result.ToArray();
        }
    }
}