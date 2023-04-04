using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP_QLHangHoa
{
    class Date 
    {
        private int d, m, y;

        public Date()
        {
            d = m = y = 0;
        }

        public void NhapDate()
        {
            Console.Write("Nhap Ngay : ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Thang : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Nam : ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public void XuatDate()
        {
            Console.WriteLine($"{d}/{m}/{y}");
        }
    }
}
