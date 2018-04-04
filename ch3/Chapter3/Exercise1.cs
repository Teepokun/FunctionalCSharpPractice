// 1 Write a generic function that takes a string and parses it as a value of an enum. It
// should be usable as follows:

// Enum.Parse<DayOfWeek>("Friday") // => Some(DayOfWeek.Friday)
// Enum.Parse<DayOfWeek>("Freeday") // => None
using System;
using LaYumba.Functional;
using static LaYumba.Functional.F;

namespace Chapter3
{

    public static class Exercise1
    {
        private static Option<T> Lift<T>(this T t) => t;
        private static Func<Type, bool> IsEnum => t => t.IsEnum;
  
        public static Option<T> Parse<T>(string value) where T : struct, IConvertible
            => typeof(T)
                .Lift()
                .Where(IsEnum)
                .Map(m => value)
                .Bind(TryParseEnum<T>);

        private static Option<T> TryParseEnum<T>(this string val) where T : struct, IConvertible
            => System.Enum.TryParse(val, out T result) ? Some(result) : None;
        
    }

    public enum DayOfWeek
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
