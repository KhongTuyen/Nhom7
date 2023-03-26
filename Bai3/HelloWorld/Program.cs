namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Hay nhap vao 2 so.");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b; 
            Console.Write($" {a} + {b} = {c} "  );
        }
    }
}