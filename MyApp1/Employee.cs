using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1
{
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
        private DateTime _Birthdate;
        private string _MailAddress;


        /// <summary>
        /// コンストラクタ！ インスタンス時idを入れないとエラー発生！でぃーふぇんす
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="mailaddress"></param>
        /// <param name="birthdate"></param>
        public Employee(int id, string name, Sex sex, string birthdate, string mailaddress)
        {
            Id = id;
            Name = name;
            Birthdate = DateTime.Parse(birthdate);
            MailAddress = mailaddress;
        }

        /// <summary>
        /// IdのSet
        /// </summary>
        /// <exception cref="Exception">IDの値がNullのとき</exception>
        public int Id
        {
            get
            {
                if (_Id == 0)
                {
                    throw new Exception("IDの入力がありません！");
                }
                return _Id;
            }
            set
            {
                //set値はvalueに入るよ！
                if (value == 0)
                {
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
            set
            {
                if (_Name == null)
                {
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
                if (_Birthdate == null)
                {
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
                return _Tel;
            }
            set
            {
                if (_Tel == null)
                {
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
                if (_MailAddress == null)
                {
                    throw new Exception("MailAddressの入力がありません！");
                }
            }
        }
        /// <summary>
        /// Birthdateの値→age生成
        /// </summary>
        /// <exception cref="Exception">BirthDateの値がNullのとき</exception>
        public int Age
        {
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
