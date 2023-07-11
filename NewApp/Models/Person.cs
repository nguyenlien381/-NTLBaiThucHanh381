using System.Xml;
namespace NewApp.Models
{
    public class Person  
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public void EnterData()
        { 
            System.Console.WriteLine("FullName = ");
            FullName = Console.ReadLine();
            System.Console.WriteLine("Address = ");
            Address = Console.ReadLine();
            System.Console.WriteLine("Age = ");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} -{2} tuoi", FullName,Address,Age);
        }
        public void Display(string ten, int tuoi)
        {
            System.Console.WriteLine("Sinh vien {0} - {1}", ten,tuoi);
        }  
        public void Display(string ten, string diachi)
        {
         System.Console.WriteLine("Sinh vien {0} - {1}",ten,diachi);   
        }
        public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }
    }
}