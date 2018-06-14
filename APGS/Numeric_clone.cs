using System;
using System.Reflection;

namespace APGS
{
    public class Numeric_clone<T> where T : struct, IComparable<T>, IEquatable<T>, IConvertible
    {
        public Numeric_clone()
        {

        }

        public static readonly T MaxValue = ReadStaticField("MaxValue");
        public static readonly T MinValue = ReadStaticField("MinValue");

        private static T ReadStaticField(string name)
        {
            FieldInfo field = typeof(T).GetField(name, BindingFlags.Public | BindingFlags.Static);
            if (field == null)
            {
                throw new InvalidOperationException("Нечисловой тип: " + typeof(T).Name);
            }
            return (T)field.GetValue(null);
        }
    }
}