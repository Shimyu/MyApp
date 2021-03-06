﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.Entity;

namespace MyApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // List<Employee> employees = new List<Employee>();

            try
            {
                Employee emp1 = new Employee(1000, "エビ＝デンス", Sex.Man, "1998/03/01", "ex_ebi.Email");
                emp1.Tel = "446―1560－8008";

                Employee emp2 = new Employee(1100, "ナン＝センス", Sex.Man, "1890/03/12", "ex1_nan.Email");
                emp2.Tel = "593-1375-446";

                Employee emp3 = new Employee(1200, "ヒヤ＝シンス", Sex.Women, "2003/05/01", "ex2_hiya.Email");
                emp3.Tel = "123-9874-6543";

                using (var context = new EmployeesContext())
                {
                    context.Employees.Add(emp1);
                    context.Employees.Add(emp2);
                    context.Employees.Add(emp3);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("エラー:{0}", e.Message);
            }

           // OutPutFile.FileCopy(employees);
        }

        public class EmployeesContext :DbContext
        {
            public EmployeesContext()
                : base("EmployeesContext")
            {

            }

            public DbSet<Employee> Employees { get; set; }
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
