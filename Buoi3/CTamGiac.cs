using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    internal class CTamGiac
    {
        double a;
        double b;
        double c;
        // phuong thuc khoi tao
        public CTamGiac()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public CTamGiac(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public CTamGiac (CTamGiac tamgiac)
        {
            a  = tamgiac.a;
            b = tamgiac.b; 
            c = tamgiac.c;
        }

        // phuong thuc giao tiep
        public double canhA
        {
            get { return a; }
            set {
                if (value < 0)
                    throw new Exception("Error");
                else
                  a = value;
            }
        }

        public double canhB
        {
            get { return b; }
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                else
                    b = value;
            }
        }

        public double canhC
        {
            get { return c; }
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                else
                    c = value;
            }
        }
        // cac phuong thuc cua lop
        public double tinhCV()
        {
            return a + b + c;
        }

        public double tinhDT()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p- b) * (p- c));    
        }
    }
}
