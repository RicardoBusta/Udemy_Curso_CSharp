using System;
using AA_Library;
using ExtensionMethods;

namespace VarAndDynamic {
    internal static class Program {       
        public static void Main(string[] args) {
            object t1 = "asd";
            object t2 = 1234;
            object t3 = new User();
            t1.Print();
            t2.Print();
            t3.Print();
            
            var v1 = "asd";
            var v2 = 1234;
            var v3 = new User();
            v1.Print();
            v2.Print();
            v3.Print();
            /* Error:
            var v3;
            */

            dynamic d1 = new User { Name = "fulaninho"};

            try {
                Console.WriteLine(d1.Name);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            
            try {
                Console.WriteLine(d1.Model);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
            // Obs: O objeto do tipo dynamic não pega o método de extensão! :O
            try {
                d1.Print();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}