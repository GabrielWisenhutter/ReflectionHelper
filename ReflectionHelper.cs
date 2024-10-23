using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHelper
{
    public static class ReflectionHelper
    {
        public static T CreateWithPrivateProperties<T>(params (string propertyName, object value)[] propertyValues) where T : class
        {
            var instance = (T)FormatterServices.GetUninitializedObject(typeof(T));

            foreach (var (propertyName, value) in propertyValues)
            {
                var field = typeof(T).GetField($"<{propertyName}>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance);
                if (field == null)
                {
                    throw new ArgumentException($"Backing field for property '{propertyName}' not found on type '{typeof(T)}'.");
                }
                field.SetValue(instance, value);
            }

            return instance;
        }
    }
}
