using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP_QLHangHoa
{
    internal class Program
    {
        static  void Main(string[] args)
        {
                int n;
                Console.Write("Nhap So Luong Hang : ");
                n = System.Int32.Parse(Console.ReadLine());
                HangDienMay[] x = new HangDienMay[10];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"                 ===== Nhap Hang Dien May {i + 1} ======");
                    x[i] = new HangDienMay();
                    x[i].NhapHDM();
                }

                Console.WriteLine("1.Hien Thi Hang Hoa");
                Console.WriteLine("2.Them Hang Hoa");
                Console.WriteLine("3.Sua Hang Hoa");
                Console.WriteLine("4.Xoa Hang Hoa");


                int lc;
                while (true)
                {
                    Console.Write("Nhap Lua Chon : ");
                    lc = System.Int32.Parse(Console.ReadLine());
                    switch (lc)
                    {
                        case 1:
                            {
                                Console.WriteLine(" ====== Hien Thi Thong Tin Hang Hoa ======");
                                Console.ForegroundColor = ConsoleColor.Green;
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine($" ===== Hang Dien May {i + 1} ======");
                                    x[i].XuatHDM();
                                    Console.WriteLine();
                                }
                            }; break;

                        case 2:
                            {
                            HangDienMay y = new HangDienMay();
                            y.NhapHDM();
                            for (int i = n - 1; i >= 0; i--)
                            {
                                x[i + 1] = x[i];
                            }
                            x[0] = y;
                            n++;

                        }; break;

                    case 3: {
                            string MaHangSS;
                            Console.Write("Nhap Ma Hang Muon Xoa : ");
                            MaHangSS = Console.ReadLine();
                            for(int i = 0; i < n; i++)
                            {
                                if(StringComparer.Ordinal.Equals(x[i].getMaHang(), MaHangSS))
                                {
                                    x[i] = x[i+1];
                                }
                            }
                            n--;
                        };break;
                    }
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
            
            
        }
    }
}
