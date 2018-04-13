using System.Linq;
using ExtensionMethods;

namespace B_LINQ {
    internal static class Program {
        public static void Main() {
            int[] testArray = {3, 9, 4, 6, 20, 10, 60, 80, 90, 50};

            var res1 = from x in testArray where x > 10 orderby x select x;
            res1.PrintArray();
        }
    }
}