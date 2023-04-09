using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_Demo.Models;
using System.Text.RegularExpressions;
using System.Reflection;
namespace Wpf_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Tạo một đối tượng trỏ tới Models
        QLBanHangContext db = new QLBanHangContext();

        //Hàm Hiển thị dữ liệu
        private void HienThiDuLieu()
        {
            var query = from sp in db.SanPhams
                        orderby sp.DonGia
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.DonGia,
                            sp.SoLuong,
                            ThanhTien = sp.DonGia * sp.SoLuong
                        };
            dgvSanPham.ItemsSource = query.ToList();
        }

        //Hàm load dữ liệu lên ComboBox
        private void HienThiCB()
        {
            var query = from lsp in db.LoaiSanPhams
                        select lsp;
            cboLoai.ItemsSource = query.ToList();
            cboLoai.DisplayMemberPath = "TenLoai";
            cboLoai.SelectedValuePath = "MaLoai";
            cboLoai.SelectedIndex= 0;
        }
        //Nút Thêm
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            //Kiểm tra không cho nhập trùng mã sản phẩm
            var query = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMa.Text));
            if(query != null)
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại", "Thong Bao");
                HienThiDuLieu();
            }
            else
            {
                SanPham spMoi = new SanPham();
                spMoi.MaSp = txtMa.Text;
                spMoi.TenSp= txtTen.Text;
                spMoi.DonGia = double.Parse(txtDonGia.Text);
                spMoi.SoLuong = int.Parse(txtSoLuong.Text);
                LoaiSanPham itemSelected = (LoaiSanPham)cboLoai.SelectedItem;
                spMoi.MaLoai= itemSelected.MaLoai;
                db.SanPhams.Add(spMoi);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thong Bao");
                HienThiDuLieu();
            }
            
        }

        //nút Sửa
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            //Xác định 1 sản phẩm để sửa
            var spSua = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMa.Text));
            if(spSua != null)
            {
                spSua.TenSp = txtTen.Text;
                LoaiSanPham itemSelected = (LoaiSanPham)cboLoai.SelectedItem;
                spSua.MaLoai = itemSelected.MaLoai;
                spSua.DonGia = double.Parse(txtDonGia.Text);
                spSua.SoLuong = int.Parse(txtSoLuong.Text) ;
                db.SaveChanges() ;
                MessageBox.Show("Sửa thành công!", "Thong Bao");
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần sửa!");
            }
        }

        //nút Xóa
        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            //Xác định 1 sản phẩm cần xóa theo mã
            var spXoa = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMa.Text));
            if(spXoa != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thong Bao", MessageBoxButton.YesNo);
                    if(rs == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(spXoa);
                    db.SaveChanges() ;
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Không có sản phẩm cần xóa!", "Thong Bao");
            }
        }

        //nút Tìm
        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            LoaiSanPham lsp = (LoaiSanPham)cboLoai.SelectedItem;
            var query = from sp in db.SanPhams
                        where sp.MaLoai == lsp.MaLoai
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.DonGia,
                            sp.SoLuong,
                            sp.MaLoai,
                            ThanhTien = sp.DonGia * sp.SoLuong
                        };
            dgvSanPham.ItemsSource= query.ToList();
        }
        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            Window2 myWindow = new Window2();
            myWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDuLieu();
            HienThiCB();
        }
    }
}
