using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee emp1 = new Employee();
            emp1.Id = 1000;
            emp1.Name = "エビ＝デンス";
            emp1.Sex = Sex.Man;
            emp1.Birthdate = DateTime.Parse("1998/03/01");
            emp1.Age = ageCalc(emp1.Birthdate);
            emp1.Tel = "446-1500-8008";
            emp1.MailAddress = "ex_ebi.mail.add";

            Employee emp2 = new Employee();
            emp2.Id = 1100;
            emp2.Name = "ナン＝センス";
            emp2.Sex = Sex.Man;
            emp2.Birthdate = DateTime.Parse("1890/03/12");
            emp2.Age = ageCalc(emp2.Birthdate);
            emp2.Tel = "593-1375-446";
            emp2.MailAddress = "ex1_nan.mail.add";

            Employee emp3 = new Employee();
            emp3.Id = 1200;
            emp3.Name = "ヒヤ＝シンス";
            emp3.Sex = Sex.Women;
            emp3.Birthdate = DateTime.Parse("2003/05/01");
            emp3.Age = ageCalc(emp3.Birthdate);
            emp3.Tel = "123-9874-6543";
            emp3.MailAddress = "ex2_hiya.mail.add";

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            fileCopy(employees);
        }
        public static int ageCalc(DateTime birth)
        {
            int age = 0;

            age  = DateTime.Now.Year - birth.Year;
            return age;
        }
        /// <summary>
        /// fileコピー用メソッド
        /// </summary>
        /// <param name="emp"></param>
            public static void fileCopy(List<Employee> emp) {
                    string path = @"C:\Users\YM\Desktop\Test.txt";
                    if (!File.Exists(path))
                        {
                            //テキスト作成
                            using (StreamWriter sw = File.CreateText(path))
                            {
                                foreach (Employee employee in emp)
                                {
                                    sw.WriteLine("項目名\n");
                                    sw.WriteLine("Id:" + employee.Id);
                                    sw.WriteLine("Name:" + employee.Name);
                                    sw.WriteLine("Sex:" + employee.Sex);
                                    sw.WriteLine("Birthdate:" + employee.Birthdate.ToString("yyyy/MM/dd"));
                                    sw.WriteLine("Age:" + employee.Age);
                                    sw.WriteLine("Tel:" + employee.Tel);
                                    sw.WriteLine("MailAddress:" + employee.MailAddress);
                                    sw.WriteLine("\r\n");
                                }
                            }
                        }
                }
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
    public enum Sex
    {
        Man,
      Women,
    }
    /// <summary>
    /// 従業員くらーす
    /// </summary>
    public class Employee
    {
        public int Id;
        public string Name;
        public Sex Sex;
        public DateTime Birthdate;
        public int Age;
        public string Tel;
        public string MailAddress;
        //public int[] Id = new int[3];
        //public string[] Name = new string[3];
        //public Sex[] Sex = new Sex[3];
        //public DateTime[] Birthdate = new DateTime[3];
        //public string[] Tel = new string[3];
        //public string[] MailAddress = new string[3];
    }
}
