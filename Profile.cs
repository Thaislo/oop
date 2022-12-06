using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTinder
{
    internal class NguoiDung
    {

        //private string? Email;
        //private string? SoDienThoai;
        private string ten;
        private int tuoi;
        private string gioithieu;
        private string sothich;
        private string chucdanh;
        private string donvilamviec;
        private string noisinhsong;
        private bool gioitinh;
        private string tinhtrang;
        private bool thichgioitinh;

        protected bool theodoi;
        private bool chan;


        private int[] luongdanhgia;
        private int danhgia;
        private int tongdanhgia;


        //private NguoiDung[] danhsachhienthicacdoituong;
        
        private int[] danhgianguoihenho;

        public NguoiDung()
        {

        }
        public NguoiDung(string ten, int tuoi, string gioithieu, string sothich, string chucdanh, string congty, string truong, string noisinhsong, bool gioitinh, string tinhtrang, bool thichgioitinh)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.gioithieu = gioithieu;
            this.sothich = sothich;
            this.chucdanh = chucdanh;
            this.donvilamviec = congty;
            this.noisinhsong = noisinhsong;
            this.gioitinh = gioitinh;
            this.tinhtrang = tinhtrang;
            this.thichgioitinh = thichgioitinh;
        }

        public NguoiDung(string ten)
        {
            this.ten = ten;
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        /*public bool Follow
        {
            get { return theodoi; }
            set { theodoi = value; }
        }*/
        public void Xuat()
        {
            Console.WriteLine(ten);
            /*Console.WriteLine(tuoi);
            Console.WriteLine(gioithieu);
            Console.WriteLine(chucdanh);
            Console.WriteLine(donvilamviec);
            Console.WriteLine(noisinhsong);
            Console.WriteLine(gioitinh);
            Console.WriteLine(tinhtrang);
            //Console.WriteLine(SoThich);*/
        }
        /*public void Swipe()
        {
            int choice;
            foreach (NguoiDung doituong in danhsachhienthicacdoituong)
            {
                do
                {
                    Console.WriteLine(doituong.Ten);
                    Console.WriteLine("1. Like");
                    Console.WriteLine("2. Nope");
                    Console.WriteLine("3. Open profile");
                    choice = Int32.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            doituong.theodoi = true;
                            break;
                        case 2:
                            doituong.theodoi = false;
                            break;
                        case 3:
                            doituong.Xuat();
                            break;
                    }
                } while (choice != 3);
            }
        }*/
        public void ChanNguoiDung()
        {
            int x;
            Console.WriteLine("Ban co muon chan nguoi dung nay");
            x = Console.Read();
            switch (x)
            {
                case 1:
                    Console.WriteLine("Ban da chan nguoi dung nay");
                    this.chan = true;
                    break;
                case 2:
                    this.chan = false;
                    break;
            }
        }
        public void HuyChanNguoiDung()
        {
            int x;
            Console.WriteLine("Ban co muon huy chan nguoi dung nay");
            x = Console.Read();
            switch (x)
            {
                case 1:
                    Console.WriteLine("Ban da huy chan nguoi dung nay");
                    this.chan = false;
                    break;
                case 2:
                    this.chan = true;
                    break;
            }
        }
        public bool HuyTheoDoiNguoiDung()
        {
            int x;
            Console.WriteLine("Ban co muon huy theo doi nguoi dung nay");
            x = Console.Read();
            switch (x)
            {
                case 1:
                    Console.WriteLine("Ban da huy theo doi nguoi dung nay");
                    this.theodoi = false;
                    break;
                case 2:
                    this.theodoi = true;
                    break;
            }
            return this.theodoi;
        }
        /*public void ThichDoiTuong()
        {
            int x;
            Console.WriteLine("1. Thich\n" + "2. Bo Qua");
            switch(x)
            {
                case 1:

                    break;
                case 2:
                    break;
            }
        }*/

        public void ThemDoiTuong(NguoiDung nguoidung)
        {
            //danhsachhienthicacdoituong.Add(nguoidung);
        }

        /*public void HienThiDoiTuong()
        {
         //   if (theodoi)
                foreach (NguoiDung item in danhsachhienthicacdoituong)
                {
                    //if (item.theodoi)
                        Console.WriteLine(item.ten);
                }
        }*/
        /*public bool NhuCauGioiTinhTimKiem(List<NguoiDung> gioitinh)
        {
            Console.WriteLine("Nhu cau tim kiem");
            Console.WriteLine("1. Nam\n" + "2. Nu");
            if (gioitinh == danhsachhienthicacdoituong)
                return true;           //true = Nam, false = Nu
            else
                return false;
        }
        public bool NhuCauKhuVucTimKiem(List<NguoiDung> khuvuc)
        {
            Console.WriteLine("Khu vuc tim kiem");
            Console.WriteLine("1. Trong khu vuc\n" + "2. Toan quoc");
            if (khuvuc == danhsachhienthicacdoituong)
                return true;          //true = Trong khu vuc, false = Toan quoc
            else
                return false;
        }*/
        public int DanhGia()
        {
            for (int i = 0; i < luongdanhgia.Length; i++)
            {
                tongdanhgia += luongdanhgia[i];
            }
            danhgia = tongdanhgia / luongdanhgia.Length;
            return danhgia;
        }
        public void DanhGiaNguoiHen(int danhgia)
        {
            danhgianguoihenho[danhgianguoihenho.Length] = danhgia;
        }
        public void BaiViet()
        {
            Post p = new Post(this, "sln", DateTime.Now);
            Post[] posts = new Post[] { p };
            //p.XoaLichSuBaiViet(p);
            LichSuBaiViet(posts);
        }
        public void LichSuBaiViet(Post[] posts)
        {
            foreach (Post post in posts)
            {
                Console.WriteLine(post.ten);
            }
        }
    }
}

/*"- User: 
    - Thông tin cơ bản: username, pass, image….
    -tạo account
    - login, forget pass, sign-in
    - Cac tiêu chí 
    - Viết các post 
    - Hẹn hò, xong hẹn hò….
    - Feedback với người hẹn
    - Block người 
    - Theo dõi người 

- Chat: 
    -người chat
    - content
    - like, share, comment
-
-Post:  
    -content
    - Hoạt động mới,
    - ng post 
- Tìm nguòi phù hợp:
    -Tính độ phù hợp trên các tiêu chí  */