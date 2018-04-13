using System;

namespace NullableExample {
    internal static class Program {
        public static void Main(string[] args) {
            Nullable<int> x = null;
            int? y = null;
            /* ERROR
            int z = null;  
            */
        }
    }
}