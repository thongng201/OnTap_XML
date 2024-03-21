using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1_SinhVien
{
   public class DSSinhVien
    {
       List<SinhVien> dsSV = new List<SinhVien>();
       public DSSinhVien()
       {

       }


//===================================================================================
       public void Nhap(int nSV)
       {
           for(int i = 1; i<=nSV; i++)
           {
               Console.WriteLine("Moi ban nhap sinh vien thu {0}", i);
               // Tao tung SV nhap 
               SinhVien sv = new SinhVien();
               sv.Nhap();
               // Them SV vao list ds
               dsSV.Add(sv);
           }
       }

//===================================================================================
        public void LoadDS(string tenfile )
       {
           XmlDocument file = new XmlDocument();
           file.Load(tenfile);
           XmlNodeList nodeSV = file.SelectNodes("/DanhSach/SV"); 
            foreach (XmlNode svnode in nodeSV)
            {
                SinhVien sv = new SinhVien();
                sv.HoTen = svnode["HoTen"].InnerText;
                sv.MSSV = svnode["MSSV"].InnerText;
                sv.SoTCHoc = int.Parse( svnode["SoTCHoc"].InnerText);

                dsSV.Add(sv);
            }

       }

//===================================================================================
       public void XuatDS()
       {
           foreach(SinhVien sv in dsSV)
           {
               
               sv.Xuat();
               Console.WriteLine("===");
           }
       }

    }
}
