using PresentationControls;
using System.ComponentModel;
using System.Reflection;

namespace Phonebook.Resources
{
    public static class PhonebookUtility
    {
        public static T GetEnumValueFromDescription<T>(string description)
        {
            MemberInfo[] fis = typeof(T).GetFields();

            foreach (var fi in fis)
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0 && attributes[0].Description == description)
                    return (T)Enum.Parse(typeof(T), fi.Name);
            }

            throw new Exception("Not found");
        }

        public static string GetStringCategoryFromCheckBoxComboBox(CheckBoxComboBox checkBoxComboBox)
        {
            var categories = checkBoxComboBox.Text.Trim().Split(',');

            var stringCategory = categories
                .Select(x => ((int)GetEnumValueFromDescription<CategoryEnum>(x.Trim())).ToString())
                .Aggregate((a, b) => $"{a},{b}");

            return stringCategory;
        }

        public static string GetStringCategory(CheckBoxComboBox checkBoxComboBox)
        {
            var categories = checkBoxComboBox.Text.Trim().Split(',');

            var stringCategory = categories
                .Select(x => ((int)GetEnumValueFromDescription<CategoryEnum>(x.Trim())).ToString())
                .Aggregate((a, b) => $"{a},{b}");

            return stringCategory;
        }

        public static string GetDescription<T>(this T enumValue)
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return null;

            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    description = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return description;
        }
    }
}
