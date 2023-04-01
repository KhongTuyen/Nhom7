using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH_XayDungCungHoangDao
{
    internal class TaoMayTinhCamTay
    {
        static void Main()
        {
            float a, b;
            string PhepTinh = default;
            float result = 0f;
            int lc;
            do
            {
                Console.Write("Nhap So Thu Nhat : ");
                a= Convert.ToSingle(Console.ReadLine());
                Console.Write("Nhap So Thu Hai : ");
                b = Convert.ToSingle(Console.ReadLine());
                Console.Write("Nhap Phep Tinh : ");
                PhepTinh = Console.ReadLine();
                switch (PhepTinh)
                {
                    case "+":
                        {
                            result = a + b;
                        };break;

                    case "-":
                        {
                            result = a - b;
                        }; break;

                    case "*":
                        {
                            result = a * b;
                        }; break;

                    case "/":
                        {
                            if(b == 0)
                            {
                                Console.WriteLine("Mau So Khong The La So 0 !");
                                System.Environment.Exit(0);
                            }
                            else
                            {
                                result =(float) a / b;
                            }
                            
                        }; break;

                    case "%":
                        {
                            result =(float) a % b;
                        }; break;

                    case "^":
                        {
                            result =(float) Math.Pow(a,b);
                        }; break;

                    default:
                        {
                            Console.WriteLine("Dau Khong Hop Le");
                        };break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{a} {PhepTinh} {b} = {result}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Nhap Lua Chon 1 De Tiep Tuc,0 Dung Chuong Trinh : ");
                lc = System.Int32.Parse(Console.ReadLine());
                if(lc == 0)
                {
                    System.Environment.Exit(0);
                }
            } while (true);
        }
    }
}
