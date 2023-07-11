public class Giaiphuongtrinh
{
     public static void Main(string[] args)
    {
        Giaiphuongtrinh ps = new Giaiphuongtrinh();
            int a = 10; 
            int b = 5;
            int c = 8;
            double x;
            float delta;
            float x1;
            float x2;
            if(a != 0)
            {
                x = (double) - b / a;
                 System.Console.WriteLine("Phuong trinh co nghiem x = {0}", Math.Round(x,2));
            }
    }
}