using LibraryManagementSystem.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public static class Extensions
    {
        //public static bool IsInformationIsNullOrEmpty(this PersonData person)
        //{
        //    if (string.IsNullOrEmpty(person.FirstName) || string.IsNullOrEmpty(person.LastName) || string.IsNullOrEmpty(person.CellPhone) || string.IsNullOrEmpty(person.NationalCode))
        //    {
        //        MessageBox.Show("please enter your information ! ");
        //        return false;
        //    }
        //    return true;
        //}

        public static bool IsNationalCodeValid(this string nationalCode)
        {
            if (nationalCode.Length != 10 || !long.TryParse(nationalCode, out var _nationalCode))
            {
                MessageBox.Show("لطفا کد ملی خود را به درستی وارد نمایید ");
                return false;
            }
            return true;
        }

        public static string ReplacePersianAndArabicNumbers(this string cellPhone)
        {
            return cellPhone.Replace('۰', '0').Replace('۱', '1').Replace('۲', '2').Replace('۳', '3').Replace('۴', '4').Replace('۵', '5')
                                .Replace('۶', '6').Replace('۷', '7').Replace('۸', '8').Replace('۹', '9');
        }

        public static string ValidateCellPhone(this string cellPhone)
        {
            try
            {
                if (cellPhone.Length < 11 || cellPhone.Length > 13 || (!cellPhone.StartsWith("09") && !cellPhone.StartsWith("989") && !cellPhone.StartsWith("+989")))
                {
                    MessageBox.Show(" لطفا شماره همراه خود را به درستی وارد نمایید");
                    return null;
                }
                else
                {
                    if (cellPhone.StartsWith("989"))
                    {
                        cellPhone = "0" + cellPhone.Substring(2, 10);
                    }
                    else if (cellPhone.StartsWith("+989"))
                    {
                        cellPhone = "0" + cellPhone.Substring(3, 10);
                    }
                }
                return cellPhone;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("لطفا شماره همراه خود را به درستی وارد نمایید");
                return null;
            }
            catch (Exception)
            {
                MessageBox.Show("در بررسی شماره همراه خطای پیش بینی نشده اتفاق افتاد");
                return null;
            }
        }

        public static string GetDescription(this Enum value)
        {
            return value.GetType()
                    .GetMember(value.ToString())
                    .FirstOrDefault()
                    ?.GetCustomAttribute<DescriptionAttribute>()
                    ?.Description;
        }

        public static List<ComboBoxModel> GetComboBoxData()
        {
            var result = new List<ComboBoxModel>();
            var values = Enum.GetValues(typeof(BookStatus));
            foreach (BookStatus item in values)
            {
                result.Add(new ComboBoxModel()
                {
                    Value = (int)item,
                    Name = item.GetDescription()
                });
            }
            return result;
        }

        public static List<Member> GetMembersFromJsonFile()
        {
            string memberFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "Members.json");
            if (File.Exists(memberFilePath))
            {
                string jsonDataStr = File.ReadAllText(memberFilePath);
                if (!string.IsNullOrWhiteSpace(jsonDataStr))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<List<Member>>(jsonDataStr);
                    }
                    catch (Exception)
                    {
                        return new List<Member>();
                    }
                }
            }
            return new List<Member>();
        }

        public static List<Book> GetBooksFromJsonFile()
        {
            string bookFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "Books.json");
            if (File.Exists(bookFilePath))
            {
                string jsonDataStr = File.ReadAllText(bookFilePath);
                if (!string.IsNullOrWhiteSpace(jsonDataStr))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<List<Book>>(jsonDataStr);
                    }
                    catch (Exception)
                    {
                        return new List<Book>();
                    }
                }
            }
            return new List<Book>();
        }

        public static void SetMembersToJsonFile(this List<Member> members)
        {
            string memberFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "Members.json");
            File.WriteAllText(memberFilePath, JsonConvert.SerializeObject(members));
        }

        public static void SetBooksToJsonFile(this List<Book> books)
        {
            string bookFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "Books.json");
            File.WriteAllText(bookFilePath, JsonConvert.SerializeObject(books));
        }
    }
}
