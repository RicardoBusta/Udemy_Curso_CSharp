using System;
using System.IO;
using System.Xml.Serialization;
using AA_Library;

namespace AB_SerializeXML {
    internal static class Program {
        public static void Main(string[] args) {
            var user = new User() {Name = "Fulano Sicrando Beltrano", Id = "1337", Email = "fulano@sicrano.com"};

            var stream = new StreamWriter("output.xml");

            var serializer = new XmlSerializer(typeof(User));

            serializer.Serialize(stream, user);

            Console.Write("Finished serialization.\n");
        }
    }
}