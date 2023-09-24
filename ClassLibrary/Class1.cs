namespace ClassLibrary
{
    public static class Class1
    {
        public static int fun1(int a, int b)
        {
            return a>b ? a : b;
        }

        public static int fun2(int[][] mas)
        {
            int sum = 0;
            for(int i=0;i<mas.Length;i++)
            {
                for(int j = 0; j < mas[i].Length; ++j)
                {
                    if(i+j == mas[i].Length - 1)
                        sum += mas[i][j];
                }
            }
            return sum;
        }

        public static int fun3(int[][] mas)
        {
            int min = 9999999;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length - i; ++j)
                {
                    if (mas[i][j] < min)
                    {
                        min = mas[i][j];
                    }
                }
            }
            return min;
        }

    }
}