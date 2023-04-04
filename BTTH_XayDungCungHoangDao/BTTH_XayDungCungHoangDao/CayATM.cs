using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH_XayDungCungHoangDao
{
    internal class CayATM
    {
        static int DangNhap(string userName, string password)
        {
            int result = default;
            if (String.Compare(userName, "Tamkem511") != 0)
            {
                result = 0;
            }else if (String.Compare(password, "05112002") != 0)
            {
                result = 1;  
            }
            else if(String.Compare(userName, "Tamkem511") == 0 && String.Compare(password, "05112002") == 0)
            {
                result = 2;
            }
            return result;
        }



        static void Main()
        {
            int TKG = 0;
            long S = 0;
            string userName = "";
            string password = "";
            Console.Write("Nhap Tai Khoan : ");
            userName = Console.ReadLine();
            Console.Write("Nhap Mat Khau : ");
            password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("====== Dang Nhap  ======");
            Console.ForegroundColor = ConsoleColor.White;


            if(DangNhap(userName,password) == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tai Khoan Khong Chinh Xac !");
                Console.ForegroundColor = ConsoleColor.White;
                
            }
            else if (DangNhap(userName,password) == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mat Khau Khong Chinh Xac !");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("====== Dang Nhap Thanh Cong ======");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1.Nap Tien");
                Console.WriteLine("2.Xem So Du");
                Console.WriteLine("3.Rut Tien");
                Console.WriteLine("4.Dang Xuat");
                int lc;
                while (true)
                {
                    Console.Write("Nhap Lua Chon De Tiep Tuc : ");
                    lc = System.Int32.Parse(Console.ReadLine());
                    switch (lc)
                    {
                        case 1:
                            {
                                do
                                {
                                    Console.Write("Nhap So Tien Muon Nap (> 10000) : ");
                                    TKG = Convert.ToInt32(Console.ReadLine());
                                } while (TKG < 10000);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("====== Nap Tien Thanh Cong ======");
                                Console.ForegroundColor = ConsoleColor.White;
                                S += TKG;
                            }; break;

                        case 2:
                            {
                                Console.WriteLine("So Du TK : " + S);
                            }; break;

                        case 3:
                            {
                                
                                int lc2;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("1.Rut 200K");
                                Console.WriteLine("2.Rut 500K");
                                Console.WriteLine("3.Nhap So Tien Rut");
                                Console.WriteLine("4.Ket Thuc Rut Tien");
                                Console.ForegroundColor = ConsoleColor.White;
                                
                                    Console.Write("Nhap Lua Chon Rut Tien : ");
                                    lc2 = Convert.ToInt32(Console.ReadLine());
                                    switch(lc2){
                                        case 1:
                                            {
                                                if(S > 200000 && (S - 200000 > 10000))
                                                {
                                                    S -= 200000;
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("====== Rut Tien Thanh Cong ======");
                                                    Console.ForegroundColor = ConsoleColor.White;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("So Du Tai Khoan Khong Du");
                                                }
                                            };break;

                                        case 2:
                                            {
                                                if (S > 500000 && (S - 500000 > 10000))
                                                {
                                                    S -= 500000;
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("====== Rut Tien Thanh Cong ======");
                                                    Console.ForegroundColor = ConsoleColor.White;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("So Du Tai Khoan Khong Du");
                                                }
                                            }; break;

                                        case 3:
                                            {
                                            int SoTien;
                                            Console.Write("Nhap So Tien : ");
                                                SoTien = Convert.ToInt32(Console.ReadLine());
                                                if(SoTien % 10 == 0 && SoTien < S && S - SoTien > 10000)
                                                {
                                                    S = S - SoTien;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("So Du Tai Khoan Khong Du");
                                                }
                                            };break;
                                        case 4:
                                            {
                                                //System.Environment.Exit(0);
                                                break;
                                            };break;
                                    }
                                
                            };break;
                    }
                }
            }
            
        }
    }
}
