using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP_QLHangHoa
{
    class HangThucPham : HangHoa
    {
        private Date NgaySX = new Date();
        private Date NgayHH = new Date();
        private string NCC;

        public HangThucPham()
        {
            NCC = "";
        }

        public void NhapHangTP()
        {
            NhapHangHoa();
            Console.WriteLine();
            Console.Write("Nhap Ngay San Xuat : ");
            Console.WriteLine();
            NgaySX.NhapDate();
            Console.Write("Nhap Ngay Het Han : ");
            NgayHH.NhapDate();
            Console.Write("Nhap Nha Cung Cap : ");
            NCC = Console.ReadLine();
        }
        public void XuatHangTP()
        {
            XuatHangHoa();
            Console.Write("Ngay San Xuat : ");
            Console.WriteLine();
            NgaySX.XuatDate();
            Console.Write("Ngay Het Han : ");
            NgayHH.XuatDate();
            Console.Write("Nha Cung Cap : " + NCC);
        }

       
    }
}
