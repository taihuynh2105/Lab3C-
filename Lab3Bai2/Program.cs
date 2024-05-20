using System;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
class Program
{
    private static string content;
    static void Main()
    {
        Data();
    }
    static void Data()
    {
        string username = "Tai";


        string password = "21412313";
        string time = DateTime.Now.ToString();

        using (StringWriter sw = new StringWriter())
        {
            string content = sw.ToString();

            sw.WriteLine("UserName: " + username);
            sw.WriteLine("PassWord: " + password);

            Console.WriteLine(content);
        }
        using (StringReader sr = new StringReader(content))
        {
           
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

    }
}