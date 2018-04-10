using System;
using System.IO;
using System.Xml.Serialization;
using AA_Library;

namespace AC_DeserializeXML {
    internal class Program {
        public static void Main(string[] args) {
            var serializer = new XmlSerializer(typeof(User));

            try {
                var reader = new StreamReader("output.xml");
                var user = (User) serializer.Deserialize(reader);
                Console.Write($"{user.ToString()}\n");
            } catch (Exception e) {
                Console.Write($"Error: {e.Message}\n");
            }

            Console.Write("Finished deserialization.\n");
        }
    }
}