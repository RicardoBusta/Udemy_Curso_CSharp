using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods {
    public static class Extensions {
        public static void Print(this object o) {
            Console.WriteLine($"({o.GetType().Name}) {o}");
        }
        
        public static void PrintArray<T>(this IEnumerable<T> array, string separator = " ") {
            var stringBuilder = new StringBuilder();
            foreach (var obj in array) {
                stringBuilder.Append(obj + separator);
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}