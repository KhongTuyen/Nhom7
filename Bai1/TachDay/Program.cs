namespace TachDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] a = new int[100];
            Console.Write("NHap so phan tu mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap vao phan tu thu a{i+1} :");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write($"So chan la: {a[i]} ");
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 1)
                {
                    Console.Write($"So le la: {a[i]}");
                }
            }
             

        }
    }
}