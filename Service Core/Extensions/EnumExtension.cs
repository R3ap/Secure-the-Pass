using System.ComponentModel;
using System.Reflection;

namespace Secure_The_Pass_Services_Core.Extensions
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value, string seperator = ", ")
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);

            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attr)
                    {
                        return attr.Description;
                    }
                    else
                    {
                        return name;
                    }
                }
            }
            else
            {
                var values = Enum.GetValues(type);
                var names = new List<string>();
                foreach (Enum item in values)
                {
                    if (Convert.ToInt32(item) != 0 && value.HasFlag(item))
                    {
                        names.Add(item.GetDescription());
                    }
                }
                return string.Join(seperator, names);
            }
            return null;
        }
    }
}
