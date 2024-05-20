using System;
using System.Diagnostics;
using System.IO;
using System.Text;
class Program
{
    static void Data()
    {
        string path = "data.txt";
        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("UserName: Tai");
                sw.WriteLine("PassWord: 2112313");
                sw.WriteLine("Hello Word");
            }
        }
        using(FileStream fs = new FileStream(path, FileMode.Open))
        {
            using (StreamReader sd = new StreamReader(fs, Encoding.UTF8))
            {

                string line;
                while ((line = sd.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
              
            }
            Console.WriteLine("Dữ liệu đã chuyển sang file txt");
        }

    }
    static void Main()
    {
        Data();
    }
}