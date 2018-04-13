using System.Linq;
using ExtensionMethods;

namespace A_LINQ {
    internal static class Program {
        public static void Main(string[] args) {
            int[] testArray = {3, 9, 4, 6, 20, 10, 60, 80, 90, 50};

            var res1 = testArray.Where(x => x > 15).Select(x => x);
            res1.PrintArray();

            var res2 = res1.OrderBy(x => x);
            res2.PrintArray();
        }
    }
}