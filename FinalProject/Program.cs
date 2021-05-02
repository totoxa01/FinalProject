using System;
using System.IO;

namespace FinalProject
{
    class Program
    {

        static void Main(string[] args)
        {
            string dirName = "E:\\";
            //опеределение каталогов по указанному пути
            try
            {
                if (Directory.Exists(dirName))
                {
                    Console.WriteLine("Подкаталоги:");
                    string[] dirs = Directory.GetDirectories(dirName);
                    int i = 0;
                    foreach (string s in dirs)
                    {
                        Console.WriteLine(s);//диск с каталогами
                        //string[] dirsP = Directory.GetDirectories(s);
                        //if (Directory.Exists(dirs[i]))
                        //{
                        //    foreach (string s1 in dirsP)
                        //    {
                        //        string[] text=FolderClass.ClassSplit.SpliString(s1);
                        //        foreach(string j in text)
                        //        {
                        //            Console.Write(" ");
                        //            Console.WriteLine(j);
                        //            Console.Write(" ");
                        //        }                                
                        //    }
                        //}
                        //i++;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
                
            Console.ReadKey();
        }
    
    }
}
