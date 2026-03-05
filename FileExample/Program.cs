using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //D:\Email_FIles
            Directory.CreateDirectory(@"D:\Email_Files\chandu_k");
            Console.WriteLine("Directory created successfully.");

            File.Create(@"D:\Email_Files\chandu_k\email.txt").Close();
            Console.WriteLine("FIle created successfully.");

            StreamWriter str = new StreamWriter(@"D:\Email_Files\chandu_k\email.txt");
            str.WriteLine("Hi Chandu,");
            str.WriteLine("How are you?");
            str.WriteLine("I am fine.");
            str.WriteLine("Thanks.");
            str.Close();
            Console.WriteLine("Written to file successfully.");

           // FileStream f = new FileStream(@"D:\Email_Files\Ger.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(@"D:\Email_Files\Ger.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(s);

            //FileStream f=new FileStream(@"D:\Email_Files\chandu.pdf",FileMode.Open,FileAccess.Read);
            // byte[] b=new byte[f.Length];
            // f.Read(b,0,b.Length);
            // string s1=Encoding.UTF8.GetString(b);
            // Console.WriteLine(s1);
            // f.Close();
            Console.ReadKey();

        }
    }
}
