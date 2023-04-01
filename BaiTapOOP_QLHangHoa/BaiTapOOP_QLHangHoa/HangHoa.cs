using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP_QLHangHoa
{
     class HangHoa
    {
        public  string MaHang;
        public  string TenHang;
        private  int SLTon;

        public HangHoa()
        {
            MaHang = "";
            TenHang = "";
            SLTon = 0;
        }

        public void NhapHangHoa()
        {
            Console.Write("Nhap Ma Hang : ");
            MaHang = Console.ReadLine();
            Console.Write("Nhap Ten Hang : ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap So Luong Ton : ");
            SLTon = Convert.ToInt32(Console.ReadLine());
        }

        public void XuatHangHoa()
        {
            Console.WriteLine($"Ma Hang : {MaHang}       Ten Hang : {TenHang}       So Luong Ton : {SLTon}");
        }

        
    }
}
