namespace NewApp.Models
{
    public class Sinhvien 
    {
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public int Tuoi { get; set; }
        public int Sodienthoai { get; set; }
        public void Nhapthongtinsinhvien(string Ht)
        { 
            System.Console.WriteLine("Hoten: ");
            Hoten = Console.ReadLine();
        }
        public void Hienthithongtinsinhvien(int Sdt)
        {
            System.Console.WriteLine("Sodienthoai: ");
            Sodienthoai = Convert.ToInt16(Console.ReadLine());
        }
        public int GetYearOfBirth(int Tuoi)
        {
            int yearOfBirth = 2023 - Tuoi;
            return yearOfBirth;
        }
    }
}