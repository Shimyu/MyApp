using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.IO;
using System.Configuration;
namespace MyApp1
{
    public static class OutPutFile
    {
        public static void FileCopy(List<Employee> emp)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            string path = appSettings["FilePath"];//=@"C:\Users\YM\Desktop\Test.txt";
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
    }
}
