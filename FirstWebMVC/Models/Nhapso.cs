namespace FirstWebMVC.Models
{
    public class Nhapso
    {
          /// Tính bình phương của 1 số 
        public double BinhPhuong(double number)
        {
            double ketqua = number * number;
            return ketqua;
        }
        public void Main(string[] args)
        {
            double bp = BinhPhuong(5); // Gọi hàm
            Console.WriteLine("Bình phương của 5 là: " + bp);
        }
    }
}

