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
                if (_Name == null)
                {
                    throw new Exception("名前の入力がありません！");
                }
                return _Name;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("名前の入力がありません！");
                }
                _Name = value;
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
                if (_Birthdate == null)
                {
                    throw new Exception("誕生日の入力がありません！");
                }
                return _Birthdate;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("誕生日の入力がありません！");
                }
                _Birthdate = value;
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
                if (_Tel == null)
                {
                    throw new Exception("TELの入力がありません！");
                }
                return _Tel;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("TELの入力がありません！");
                }
                else{
                    //TELLの桁数チェックを行う
                    //全角‐(ハイフン)の場合→半角ハイフンへ変換
                    if(value.IndexOf("‐") != -1){
                        value = value.Replace("‐", "-");
                    }
                    //全角マイナスの場合→半角ハイフンへ変換
                    if(value.IndexOf("－") != -1){
                         value = value.Replace("－", "-");
                    }
                    //全角のダッシュの場合→半角ハイフンへ変換
                    if(value.IndexOf("―") != -1){
                        value = value.Replace("―", "-");
                    }

                    //"-"で区切って４桁以内、４桁以内、４桁以内 であることを確認
                    string[] strArray = value.Split('-');
                    //var strCount = strArray[].Count;
                    if (strArray.Length < 0 || strArray.Length > 3) {
                        throw new Exception("TELの区切り数が不正です！");
                    }
                    //数値チェック用のresult.形だけ.使用はしない.
                    int result = 0;
                    foreach (string stData in strArray)
                    {  
                        //数字だけかどうかのチェック
                        if (!int.TryParse(stData, out result))
                        {
                            throw new Exception("TELの入力値が不正です！");
                        }
                        if (stData.Length < 0 || stData.Length > 4)
                        {
                            throw new Exception("TELの入力値数が不正です！");
                        }
                    }
                }
                _Tel = value;
            }
        }
        public string MailAddress
        {
            get
            {
                if (_MailAddress == null)
                {
                    throw new Exception("MailAddressの入力がありません！");
                }
                return _MailAddress;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("MailAddressの入力がありません！");
                }
                //メールアドレスの入力値チェックを行う.
                //.Emailで終わっているかどうか.
                if (value.EndsWith(".Email") == false)
                {
                    throw new Exception("MailAddressの入力値が不正です！");
                }
                //全角文字が入っていないかどうか.
                byte [] byte_data = System.Text.Encoding.GetEncoding(932).GetBytes(value);
	            if (!(byte_data.Length == value.Length))
                {
                    throw new Exception("MailAddressの入力値(全角入力あり)不正です！");
                }
                //半角文字アルファベット以外が入っていないかどうか.
                

                _MailAddress = value;
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
                //if (Birthdate == null)
                //{
                //    throw new Exception("BirthDateの入力がありません！");
                //}
                int age = 0;

                age = DateTime.Now.Year - Birthdate.Year;
                return age;
            }
        }
    }
}
