using System.IO.Pipes;
using NewApp.Models;
public class Sinhvien
{
    public static void Main(string[] args)
    {
        Sinhvien ps = new Sinhvien();
        string Ht = "Nguyen Thi Lien";
        int Sdt = 093625345;
        int Tuoi = 21;
        System.Console.WriteLine("{0} - {1} -{2}",Ht,Sdt,Tuoi);
    }
    
}
