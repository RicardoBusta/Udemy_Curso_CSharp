using System;

namespace ExtensionMethods {
    public static class Extensions {
        public static void Print(this object o) {
            Console.WriteLine($"({o.GetType().Name}) {o}");
        }
    }
}