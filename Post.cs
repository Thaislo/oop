using QuanLyTinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTinder
{
    internal class Post : NguoiDung
    {
        private bool like;
        private string comment;
        private bool share;
        private string noidung;
        private DateTime thoigian;

        private DateTime[] lichsudangbaiviet;

        public Post()
        {
            
        }
        public Post(NguoiDung ten, string nd, DateTime thoigian)
        {
            this.noidung = nd;
            this.thoigian = thoigian;
        }
        public void XoaLichSuBaiViet(Post p)
        {
            
        }
        public void ThichBaiViet()
        {
            
        }
        public void BinhLuan()
        {

        }
    }
}
