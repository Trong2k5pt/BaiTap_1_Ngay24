using System;
using System.Collections;

class Giay
{
    public string giayId;
    public string tenGiay;
    public string thuongHieu;
    public int size;
    public string mauSac;
    public double gia;
    public int tonKho;

    public Giay(string giayId, string tenGiay, string thuongHieu, int size, string mauSac, double gia, int tonKho)
    {
        this.giayId = giayId;
        this.tenGiay = tenGiay;
        this.thuongHieu = thuongHieu;
        this.size = size;
        this.mauSac = mauSac;
        this.gia = gia;
        this.tonKho = tonKho;
    }
}

class Program
{
    static ArrayList danhSachGiay = new ArrayList();

    static void Main(string[] args)
    {
        int choice = 0;
        do
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Cua hang ban giay NET101");
            Console.WriteLine("1. Them moi mot doi Giay");
            Console.WriteLine("2. Danh sach Giay");
            Console.WriteLine("3. Mua Giay");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("------------------------");
            Console.Write("Nhap lua chon cua ban: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThemGiay();
                    break;
                case 2:
                    HienThiDanhSachGiay();
                    break;
                case 3:
                    MuaGiay();
                    break;
                case 4:
                    Console.WriteLine("Cam on ban da su dung chuong trinh!");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 4);
    }

    static void ThemGiay()
    {
        Console.WriteLine("Them moi mot doi Giay");

        Console.Write("Nhap giayId: ");
        string giayId = Console.ReadLine();

        Console.Write("Nhap tenGiay: ");
        string tenGiay = Console.ReadLine();

        Console.Write("Nhap thuongHieu: ");
        string thuongHieu = Console.ReadLine();

        Console.Write("Nhap size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap mauSac: ");
        string mauSac = Console.ReadLine();

        Console.Write("Nhap gia: ");
        double gia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap tonKho: ");
        int tonKho = Convert.ToInt32(Console.ReadLine());

        Giay giay = new Giay(giayId, tenGiay, thuongHieu, size, mauSac, gia, tonKho);
        danhSachGiay.Add(giay);

        Console.WriteLine("Them Giay thanh cong!");
    }

    static void HienThiDanhSachGiay()
    {
        Console.WriteLine("Danh sach Giay");

        foreach (Giay giay in danhSachGiay)
        {
            Console.WriteLine("giayId: " + giay.giayId);
            Console.WriteLine("tenGiay: " + giay.tenGiay);
            Console.WriteLine("thuongHieu: " + giay.thuongHieu);
            Console.WriteLine("size: " + giay.size);
            Console.WriteLine("mauSac: " + giay.mauSac);
            Console.WriteLine("gia: " + giay.gia);
            Console.WriteLine("tonKho: " + giay.tonKho);
            Console.WriteLine("------------------------");
        }
    }

    static void MuaGiay()
    {
        Console.WriteLine("Mua Giay");

        Console.Write("Nhap giayId: ");
        string giayId = Console.ReadLine();

        Giay giay = TimGiayTheoId(giayId);

        if (giay != null)
        {
            Console.Write("Nhap so luong muon mua: ");
            int soLuong = Convert.ToInt32(Console.ReadLine());

            if (soLuong <= giay.tonKho)
            {
                giay.tonKho -= soLuong;
                Console.WriteLine("Ban da mua thanh cong " + soLuong + " doi Giay " + giay.tenGiay);
            }
            else
            {
                Console.WriteLine("Khong du so luong ton kho cho doi Giay nay.");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay doi Giay co giayId = " + giayId);
        }
    }

    static Giay TimGiayTheoId(string giayId)
    {
        foreach (Giay giay in danhSachGiay)
        {
            if (giay.giayId == giayId)
            {
                return giay;
            }
        }
        return null;
    }
}