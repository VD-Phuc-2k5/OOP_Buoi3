using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    internal class CThiSinh
    {
        string hoVaTen;
        string soBaoDanh;
        int namSinh;
        double diemLT;
        double diemTH;

        // contructor
        public CThiSinh() {
            HoVaTen = "Hua Quang Tam";
            SoBaoDanh = "123";
            NamSinh = 2005;
            DiemLT = 0;
            DiemTH = 0;
        }
        public CThiSinh(string hoVaTen, string soBaoDanh, int namSinh, double diemLT, double diemTH) {
            HoVaTen = hoVaTen;
            SoBaoDanh = soBaoDanh;
            NamSinh = namSinh;
            DiemLT = diemLT;
            DiemTH = diemTH;
        }

        public CThiSinh(CThiSinh thiSinh)
        {
            hoVaTen = thiSinh.hoVaTen;
            soBaoDanh = thiSinh.soBaoDanh;
            namSinh = thiSinh.namSinh;
            diemLT = thiSinh.diemLT;
            diemTH = thiSinh.diemTH;
        }

        // phuong thuc giao tiep
        public string HoVaTen
        {
            get { return hoVaTen; }
            set {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Họ và tên không dược để trống");
                }
                else 
                    hoVaTen = value; 
            }
        }

        public string SoBaoDanh
        {
            get { return soBaoDanh; }
            set { soBaoDanh = value; }
        }
       
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        } 

        public double DiemLT
        {
            get { return diemLT; }
            set {
                if (0 <= value && value <= 10) 
                    diemLT = value;
                else
                {
                    throw new Exception("Điểm lý thuyết không hợp lệ");
                }
            }
        }

        public double DiemTH
        {
            get { return diemTH; }
            set {
                if (0 <= value && value <= 10)
                    diemTH = value;
                else
                    throw new Exception("Điểm TH không hợp lệ");
            }
        }

        // method of class
        public string xetKetQua()
        {
            double tongDiem = diemTH + diemLT;
            return tongDiem > 10 && diemLT >= 2 && diemTH >= 2 ? "Đậu" : "Rớt";
        }

        public void xuatThongTin()
        {
            Console.WriteLine($"{hoVaTen} {soBaoDanh} {namSinh} {diemLT} {diemTH}");
        }
    }
}
