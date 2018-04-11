using System;
using System.IO;
using System.Web.Script.Serialization;
using AA_Library;

namespace AE_DeserializeJSON {
    internal static class Program {
        public static void Main(string[] args) {
            try {
                var stream = new StreamReader("output.json");
                var str = stream.ReadToEnd();

                var serializer = new JavaScriptSerializer();
                var user = serializer.Deserialize<User>(str);

                Console.Write($"{user}\n");
            } catch (Exception e) {
                Console.Write($"{e.Message}\n");
            }

            Console.Write("Finished serialization.\n");
        }
    }
}