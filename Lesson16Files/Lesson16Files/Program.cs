using System;
using System.IO;
using System.Text;

namespace Lesson16Files
{
    class Program
    {
        static void Main(string[] args)
        {

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            DriveInfo cd = new DriveInfo(allDrives[0].Name);

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine(d.Name);
                Console.WriteLine(d.TotalSize);
            }



            Console.WriteLine(cd.Name);
            Console.WriteLine(allDrives[0].TotalSize);


            string dirName = "/";
            string[] files = Directory.GetFiles(dirName);

            Console.WriteLine(files.Length);


            int k = 0;
            foreach (string s in files)
            {
                k++;
                Console.WriteLine(k);
                Console.WriteLine(s);
            }


            FileInfo fi = new FileInfo(files[0]);
            Console.WriteLine(fi.CreationTime);

            string path = "/Users/dmitrynovik/test.txt";
            var file = new FileInfo(path);
            FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);

            File.WriteAllText(@"/Users/dmitrynovik/test2.txt", "hello");
            //File.Encrypt("/Users/dmitrynovik/test2.txt");


            //FileSystemInfo fsi = new FileSystemInfo(files[0]);
            //Console.WriteLine(FileSystemInfo(files[0].cre));
            //Console.WriteLine(DisplayFileSystemInfoAttributes(new FileInfo(files[0])));

            //Console.WriteLine(named.TotalSize);
            //Console.WriteLine("Hello World!");

            Stream mystream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (mystream = File.OpenRead(path))
            {
                byte[] info = new byte[1024];
    
                mystream.Read(info, 0, info.Length);
                Console.WriteLine(info[0]);
            }
 

        }   
    }
}
