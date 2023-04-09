using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH_XayDungCungHoangDao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ngay, thang;
            int lc;
            do
            {
                Console.Write("Nhap Ngay : ");
                ngay = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap Thang : ");
                thang = System.Int32.Parse(Console.ReadLine());
                // Kiem Thang Tinh Dung Dan Cua Ngay Thang
                switch (thang)
                {
                    case 1:
                        {
                            if (ngay > 31)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 2:
                        {
                            if (ngay > 29)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 3:
                        {
                            if (ngay > 31)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 4:
                        {
                            if (ngay > 30)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 5:
                        {
                            if (ngay > 31)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 6:
                        {
                            if (ngay > 30)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 7:
                        {
                            if (ngay > 31)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 8:
                        {
                            if (ngay > 31)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 9:
                        {
                            if (ngay > 30)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 10:
                        {
                            if (ngay > 31)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 11:
                        {
                            if (ngay > 30)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    case 12:
                        {
                            if (ngay > 31)
                            {
                                Console.WriteLine("Ngay Sinh Khong Hop Le!");
                            }
                        }; break;
                    default:
                        {
                            Console.WriteLine("Thang Sinh Khong Hopp Le!");
                        }; break;
                        
                }
                Console.Write("Nhap Lua Chon 1 de tiep tuc,0 dung chuong trinh : ");
                lc = Convert.ToInt32(Console.ReadLine());
                if (lc == 0)
                {
                    System.Environment.Exit(0);
                }
                else if(lc == 1)
                {
                    string result = "";
                    switch (thang)
                    {
                        case 1:
                            {
                                if(ngay <= 19)
                                {
                                    result = "Ma Ket";
                                }
                                else
                                {
                                    result = "Bao Binh";
                                }
                            };break;

                        case 2:
                            {
                                if (ngay <= 18)
                                {
                                    result = "Bao Binh";
                                }
                                else
                                {
                                    result = "Song Ngu";
                                }
                            }; break;

                        case 3:
                            {
                                if (ngay <= 20)
                                {
                                    result = "Song Ngu";
                                }
                                else
                                {
                                    result = "Bach Duong";
                                }
                            }; break;

                        case 4:
                            {
                                if (ngay <= 19)
                                {
                                    result = "Bach Duong";
                                }
                                else
                                {
                                    result = "Kim Nguu";
                                }
                            }; break;

                        case 5:
                            {
                                if (ngay <= 20)
                                {
                                    result = "Kim Nguu";
                                }
                                else
                                {
                                    result = "Song Tu";
                                }
                            }; break;

                        case 6:
                            {
                                if (ngay <= 20)
                                {
                                    result = "Song Tu";
                                }
                                else
                                {
                                    result = "Cu Giai";
                                }
                            }; break;

                        case 7:
                            {
                                if (ngay <= 22)
                                {
                                    result = "Cu Giai";
                                }
                                else
                                {
                                    result = "Su Tu";
                                }
                            }; break;

                        case 8:
                            {
                                if (ngay <= 22)
                                {
                                    result = "Su Tu";
                                }
                                else
                                {
                                    result = "Xu Nu";
                                }
                            }; break;

                        case 9:
                            {
                                if (ngay <= 22)
                                {
                                    result = "Xu Nu";
                                }
                                else
                                {
                                    result = "Thien Binh";
                                }
                            }; break;

                        case 10:
                            {
                                if (ngay <= 22)
                                {
                                    result = "Thien Binh";
                                }
                                else
                                {
                                    result = "Thien Yet";
                                }
                            }; break;

                        case 11:
                            {
                                if (ngay <= 21)
                                {
                                    result = "Thien Yet";
                                }
                                else
                                {
                                    result = "Nhan Ma";
                                }
                            }; break;

                        case 12:
                            {
                                if (ngay <= 21)
                                {
                                    result = "Nhan Ma";
                                }
                                else
                                {
                                    result = "Ma Ket";
                                }
                            }; break;
                        default:
                            {
                                result = "Thong Tin Khong Chinh Xac !";
                            };break;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Cung Hoang Dao Cua Ban La : {result}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } while (true);
            

            //In Ra Cung Hoang Dao

        }
    }
}
