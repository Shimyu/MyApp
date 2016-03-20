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
        public void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                Employee emp1 = new Employee();
                emp1.Id = 1000;
                emp1.Name = "エビ＝デンス";
                emp1.Sex = Sex.Man;
                emp1.Birthdate = DateTime.Parse("1998/03/01");
                emp1.Tel = "446-1500-8008";
                emp1.MailAddress = "ex_ebi.mail.add";

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

            fileCopy(employees);
        }

        /// <summary>
        /// fileコピー用メソッド
        /// </summary>
        /// <param name="emp"></param>
        public void fileCopy(List<Employee> emp) {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            string path = appSettings["FilePath"];//=@"C:\Users\YM\Desktop\Test.txt";
            if (!File.Exists(path)){
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
        private int _Id;
        private string _Name;
        private string _Tel;
        private string _MailAddress;
        private DateTime _Birthdate;

        /// <summary>
        /// IdのSet
        /// </summary>
        /// <exception cref="Exception">IDの値がNullのとき</exception>
        public int Id
        {
            get
            { 
                return _Id; 
            }
            set
            {
                if (Id == null){
                    throw new Exception("IDの入力がありません！");
                }
                _Id = value;
            }
        }

        /// <summary>
        /// NameのSet
        /// </summary>
        /// <exception cref="Exception">Nameの値がNullのとき</exception>
        public string Name
        {
            get
            {
                return _Name;
            }
            set{
                if(_Name == null){
                    throw new Exception("名前の入力がありません！");
                }
            }
        }
        /// <summary>
        /// SexのSet
        /// </summary>
        /// <exception cref="Exception">Sexの値がNullのとき</exception>
        public Sex Sex
        {
            get;
            //{
            //    return _Sex;
            //}
            set;
            //{
            //    if (_Sex == null){
            //        throw new Exception("性別の入力がありません！");
            //    }
            //}
        }

        /// <summary>
        /// BirthdateのSet
        /// </summary>
        /// <exception cref="Exception">Birthdateの値がNullのとき</exception>
        public DateTime Birthdate
            {
                get
                {
                    return _Birthdate;
                }
            set
            {
                if (_Birthdate == null){
                    throw new Exception("誕生日の入力がありません！");
                }
            }
        }

        /// <summary>
        ///TelのSet
        /// </summary>
        /// <exception cref="Exception">Telの値がNullのとき</exception>
        public string Tel
        {
            get
            {
                return _Tel ;
            }
            set
            {
                if (_Tel == null){
                    throw new Exception("TELの入力がありません！");
                }
            }
        }
        public string MailAddress
        {
            get
            {
                return _MailAddress;
            }
            set
            {
                if (_MailAddress == null){
                    throw new Exception("MailAddressの入力がありません！");
                }
            }
        }
        /// <summary>
        /// Birthdateの値→age生成
        /// </summary>
        /// <exception cref="Exception">BirthDateの値がNullのとき</exception>
        public int Age {
            get
            {
                if (Birthdate == null)
                {
                    throw new Exception("BirthDateの入力がありません！");
                }
                int age = 0;

                age = DateTime.Now.Year - Birthdate.Year;
                return age;
            }
        }
    }
}
