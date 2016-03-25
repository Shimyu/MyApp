using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;

namespace MyApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                Employee emp1 = new Employee(1000, "エビ＝デンス", Sex.Man, "1998/03/01", "ex_ebi.mail.add");
                emp1.Tel = "446-1500-8008";


                Employee emp2 = new Employee();
                emp2.Id = 1100;
                emp2.Name = "ナン＝センス";
                emp2.Sex = Sex.Man;
                emp2.Birthdate = DateTime.Parse("1890/03/12");
                emp2.Tel = "593-1375-446";
                emp2.MailAddress = "ex1_nan.mail.add";

                Employee emp3 = new Employee();
                emp3.Id = 1200;
                emp3.Name = "ヒヤ＝シンス";
                emp3.Sex = Sex.Women;
                emp3.Birthdate = DateTime.Parse("2003/05/01");
                emp3.Tel = "123-9874-6543";
                emp3.MailAddress = "ex2_hiya.mail.add";

                employees.Add(emp1);
                employees.Add(emp2);
                employees.Add(emp3);
            }
            catch (Exception e)
            {
                Console.WriteLine("エラー:{0}", e.Message);
            }

            OutPutFile.FileCopy(employees);
        }

        /// <summary>
        /// fileコピー用メソッド
        /// </summary>
        /// <param name="emp"></param>
        
            ////バックアップ作成

            ////pathのフォルダまでを取得
            //int pathchanged_c = path.LastIndexOf("\\");
            //string pathchanged = path.Substring(0, pathchanged_c);

            //string path2 = @"C:\Users\YM\Desktop";
            //string[] txtList = Directory.GetFiles(pathchanged);
            //foreach (string f in txtList)
            //{
            //    // ファイル名からパスを削除
            //    string fName = f.Substring(0, f.LastIndexOf("\\"));

            //    try
            //    {
            //        // Will not overwrite if the destination file already exists.
            //        File.Copy(Path.Combine(pathchanged, fName), Path.Combine(path2, fName));
            //    }

            //    // Catch exception if the file was already copied.
            //    catch (IOException copyError)
            //    {
            //        Console.WriteLine(copyError.Message);
            //    }
            //}
        }
    
}
