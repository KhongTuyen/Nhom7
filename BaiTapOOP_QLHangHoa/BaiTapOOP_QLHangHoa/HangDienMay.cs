using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP_QLHangHoa
{
    class HangDienMay : HangHoa
    {
        private Date TGBH = new Date();
        private int CongSuat;

        public HangDienMay()
        {
            CongSuat = 0;
        }
        public void NhapHDM()
        {
                NhapHangHoa();
                Console.Write("Nhap Thoi Gian Bao Hanh : ");
                Console.WriteLine();
                TGBH.NhapDate();
                Console.Write("Nhap Cong Suat : ");
                CongSuat = Convert.ToInt32(Console.ReadLine());
            
         }

        public string getMaHang()
        {
            return MaHang;
        }
        public void XuatHDM()
        {
            XuatHangHoa();
            Console.Write("Thoi Gian Bao Hanh : ");
            TGBH.XuatDate();
            Console.Write("Cong Suat : " + CongSuat);
        }

       
    }

    
}
