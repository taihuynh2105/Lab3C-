using System;
using System.IO;
using System.Text;
class Program
{
    
    static void Create()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string dataDirectory = @"C:\\Users\T&T\\Desktop\\Lab3\\Lab3Bai3\\data\\";

        Directory.CreateDirectory(dataDirectory);
        string dataFilePath = Path.Combine (dataDirectory, "data.txt");
        
        using (StreamWriter writer = new StreamWriter(dataFilePath))
        {
            writer.WriteLine("MSSV: PD10956 | Ho va ten: Huynh Le Tai");

        }
        Console.WriteLine("Đã ghi xong sang địa chỉ " + dataFilePath);
    }   
    static void Copy()
    {
        string sourceDirectory = @"C:\\Users\T&T\\Desktop\\Lab3\\Lab3Bai3\\data\\";
        string targetDirectory = @"C:\\Users\T&T\\Desktop\\Lab3\\Lab3Bai3\\data2\\";
        if (Directory.Exists(sourceDirectory))
        {
            Directory.CreateDirectory(targetDirectory);
            string[] files = Directory.GetFiles(sourceDirectory);

            foreach (string file in files)
            {
                string fileName= Path.GetFileName(file);
                string targetFile= Path.Combine(targetDirectory, fileName);
                File.Copy(file, targetFile, true);
            }
            Console.WriteLine("Sao chép hoàn tất");

        }
        else
        {
            Console.WriteLine("Thư mục nguồn không tồn tại");
        }
    }

    static void Main()
    {
        Create();
        Copy();
    }
}