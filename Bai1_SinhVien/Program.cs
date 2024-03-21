using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_SinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            DSSinhVien ds = new DSSinhVien();

            //ds.Nhap(2);
            ds.LoadDS("danhsach.xml");
            ds.XuatDS();
            Console.ReadLine();
        }
    }
}
