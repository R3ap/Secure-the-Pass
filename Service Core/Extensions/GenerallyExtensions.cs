using System.ComponentModel;
using System.Reflection;

namespace Password_Manager_Services_Core.Extensions
{
    public static class GenerallyExtensions
    {
        public static T? GetDefaultValue<T, TClass>(this string propertyName)
        {
            var property = typeof(TClass).GetProperty(propertyName);

            if (property.GetCustomAttribute(typeof(DefaultValueAttribute)) is DefaultValueAttribute attribute)
            {
                return (T)attribute.Value;
            }
            return default;
        }
    }
}
