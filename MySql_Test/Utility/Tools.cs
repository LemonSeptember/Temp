using System;
using System.Data;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace MySql_Test.Utility
{
    public static class Tools
    {
        public static TModel DataRowToModel<TModel>(this DataRow dr)
        {
            Type type = typeof(TModel);
            TModel md = (TModel)Activator.CreateInstance(type);
            foreach (PropertyInfo prop in type.GetProperties())
            {
                prop.SetValue(md, dr[prop.Name]);
            }
            return md;
        }

        public static string EncryptToMd5(string password)
        {
            string md5_pwd = "";
            MD5 md5 = MD5.Create();
            byte[] array = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            foreach (byte item in array)
            {
                md5_pwd += item.ToString("X");
            }
            return md5_pwd;
        }

    }

    public static class StringExtensions
    {
        public static bool Contains(this String str, String substring,
                                    StringComparison comp)
        {
            if (substring == null)
                throw new ArgumentNullException("substring",
                                             "substring cannot be null.");
            else if (!Enum.IsDefined(typeof(StringComparison), comp))
                throw new ArgumentException("comp is not a member of StringComparison",
                                         "comp");

            return str.IndexOf(substring, comp) >= 0;
        }
    }
}
