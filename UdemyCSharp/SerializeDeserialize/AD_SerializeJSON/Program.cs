using System;
using System.IO;
using System.Web.Script.Serialization;
using AA_Library;

namespace AD_SerializeJSON {
    internal class Program {
        public static void Main(string[] args) {
            var user = new User() {Name = "Derpino Fuu", Id = "2018", Email = "derpino@mene.com"};

            var serializer = new JavaScriptSerializer();

            var serialized = serializer.Serialize(user);
            
            var stream = new StreamWriter("output.json");
            stream.Write(serialized);
            stream.Close();

            Console.Write("Finished serialization.\n");
        }
    }
}