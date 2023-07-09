// See https://aka.ms/new-console-template for more information
public class Sinhvien
{
    public static void Main (string[] args)
    {
        System.Console.WriteLine("Nhap ten sinh vien: ");
        string Name = Console.ReadLine()!;
        System.Console.WriteLine("Nhap ma sinh vien: ");
        string Id = Console.ReadLine()!;
        double a, b, c;
        System.Console.WriteLine("diem toan = ");
        a = double.Parse(Console.ReadLine()!);
        System.Console.WriteLine("diem ly = ");
        b = double.Parse(Console.ReadLine()!);
        System.Console.WriteLine("diem hoa = ");
        c = double.Parse(Console.ReadLine()!);
        double ĐTB = (a + b + c)/3;
        System.Console.WriteLine("Diem Trung Binh la = {0}",ĐTB);
    }
}

