namespace Course
{
    class Calculator
    {
        public static int Soma(params int[] numbers)
        {
            int soma = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                soma += numbers[i];
            }
            return soma;

        }

        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}