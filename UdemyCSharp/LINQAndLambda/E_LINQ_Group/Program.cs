using System.Linq;
using ExtensionMethods;

namespace E_LINQ_Group {
    internal static class Program {
        public static void Main(string[] args) {
            var list = new[] {1, 1, 2, 3, 5, 8, 9, 10, 1, 2, 4, 6, 5, 5, 3, 2, 9, 7};

            var list1 = list.OrderBy(x => x);
            list1.PrintArray();

            var list2 = list.Distinct().OrderBy(x => x);
            list2.PrintArray();

            var list3 = list.OrderBy(x => x).GroupBy(x => x).Select(x => x.Key);
            list3.PrintArray();
        }
    }
}