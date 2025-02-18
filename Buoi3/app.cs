using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    internal class Programs
    {
      static void Main(string[] args)
      {
            Console.InputEncoding = Encoding.UTF8;
            // Thi sinh 1
            CThiSinh thiSinh1 = new CThiSinh();
            thiSinh1.HoVaTen = "Hứa Quang Tâm";
            thiSinh1.SoBaoDanh = "2001230692";
            thiSinh1.NamSinh = 2005;
            thiSinh1.DiemLT = 2;
            thiSinh1.DiemTH = 2;
            thiSinh1.xuatThongTin();

            // Thi sinh 2
            CThiSinh thiSinh2 = new CThiSinh("Hứa Quang Tâm", "2001230692", 2005, 2, 2);
            thiSinh2.xuatThongTin();

            // Thi sinh 3
            CThiSinh thiSinh3 = new CThiSinh(thiSinh1);
            thiSinh3.xuatThongTin();

            // Tam giac 1
            CTamGiac tamgiac1 = new CTamGiac(3, 4, 5);
            Console.WriteLine($"Chu vi: {tamgiac1.tinhCV()}");
            Console.WriteLine($"Diện tích: {tamgiac1.tinhDT()}");

            // Tam giac 2
            CTamGiac tamgiac2 = new CTamGiac();
            tamgiac2.canhA = 4;
            tamgiac2.canhB = 6;
            tamgiac2.canhC = 10;
            Console.WriteLine($"Chu vi: {tamgiac2.tinhCV()}");
            Console.WriteLine($"Diện tích: {tamgiac2.tinhDT()}");
        }  
    }
}
