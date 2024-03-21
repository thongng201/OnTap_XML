using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_SinhVien
{
    public class SinhVien
    {
        string _MSSV;
        string _HoTen;
        int _SoTCHoc;

        public int SoTCHoc
        {
            get { return _SoTCHoc; }
            set { _SoTCHoc = value; }
        }

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        public string MSSV
        {
            get { return _MSSV; }
            set { _MSSV = value; }
        }
        public SinhVien()
        {


        }

 //===================================================================================
        public void Nhap()
        {
            Console.Write("MSSV:");
            _MSSV = Console.ReadLine();
            Console.Write("Ten:");
            _HoTen = Console.ReadLine();
            Console.Write("So TC:");
            _SoTCHoc = int.Parse(Console.ReadLine());
        }

//===================================================================================
        public void Xuat()
        {
            Console.Write("MSSS la :{0}", _MSSV);
            Console.Write("HoTen la :{0}", _HoTen);
            Console.Write("Tinchi la :{0}", _SoTCHoc);
        }


    }
}
