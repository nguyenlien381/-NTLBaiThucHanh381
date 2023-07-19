using System.Collections;
using System.Collections.Specialized;
using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        //Student std = new Student();
        //std.EnterData();
        //std.Display();
        // Person ps = new Person();
        // string str = "Nguyen thi lien";
        //int a = 21;
        //System.Console.WriteLine("{0} sinh nam {1}",str,ps.GetYearOfBirth(a));
        //* GPT PT = new GPT();
        //PT.Phuongtrinhbacnhat();
        //PT.GiaiPTB2(); 
        //NHAP THONG TIN 
        ArrayList arrStudent = new ArrayList();
        System.Console.Write("nhap n=   ");
        int n = Convert.ToInt32(Console.ReadLine());
        for( int i = 0; i < n; i ++)
        {
            Student std = new Student ();
            std.EnterData();
            //ADD 
            arrStudent.Add(std);
        }
        //HIEN THI THONG TIN TRONG ARRAY LIST
        foreach(Student std in arrStudent)
        {
            std.Display();
        }
        
        //SUA THONG TIN
        System.Console.WriteLine("Nhap thong tin sinh vien muon sua: ");
        string str = Console.ReadLine();
        foreach (Student std in arrStudent)
        {
            if (std.StudentCode.Equals(std))
            {
                int intIndex = -1;
                while(intIndex < 0 || intIndex >= n)
                {
                    System.Console.WriteLine("Nhap chi so cua phan tu muon sua: ");
                    intIndex = Convert.ToInt32(Console.ReadLine());
                    //khai bao 1 phan tu Student moi
                    Student stdUpdate = new Student();
                    stdUpdate.EnterData();
                    //gan phan tu moi vao phan tu co index = intIndex
                    arrStudent[intIndex] = stdUpdate;
                }
                foreach ( Student stdUpdate in arrStudent )
                {
                    stdUpdate.Display();
                }
            }
            
        }
    }
}
