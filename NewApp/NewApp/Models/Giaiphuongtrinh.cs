using System;
namespace NewApp.Models
{
    public class Giaiphuongtrinh
    {
        public string Giaiphuongtrinhbacnhat(double a, double b)
        {
            string Thongbao ="";
            return ("Thong bao ");
            double x;
            System.Console.WriteLine("Nhap vao so a: ");
            a = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Nhap vao so b: ");
            b = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Phuong trinh bac nhat la: {0}x + {1} = 0.", a,b);
            if(a == 0 && b == 0)
            {
                System.Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if(a == 0 && b != 0)
            {
                System.Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if(a != 0)
            {
                x = (double) - b / a;
                System.Console.WriteLine("Phuong trinh co nghiem x = {0}", Math.Round(x,2));
            }
        }
        public String Giaiphuongtrinhbachai(double a, double b, double c)
        {
            String Thongbao ="";
            return ("Thong bao ");
            double x;
            double x1;
            double x2;
            System.Console.WriteLine("Nhap vao so a: ");
            a = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Nhap vao so b: ");
            b = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Nhap vao so c: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0 && b!=0)
            {
                System.Console.WriteLine("Phuong trinh co mot nghiem: x = {0}", (-c / b));
            }
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                System.Console.WriteLine("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                System.Console.WriteLine("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
            }
            else
            {
                System.Console.WriteLine("Phuong trinh vo nghiem.");
            }
        }

    }
}