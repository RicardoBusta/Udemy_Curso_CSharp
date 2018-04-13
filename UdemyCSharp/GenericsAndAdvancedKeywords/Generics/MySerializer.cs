using System.IO;
using System.Xml.Serialization;

namespace Generics {
    public static class MySerializer {
        public static void Serialize(object obj) {
            var type = obj.GetType();
            var writer = new StreamWriter($"{type.Name}.xml");

            var serializer = new XmlSerializer(type);
            serializer.Serialize(writer, obj);
            writer.Close();
        }

        public static T Deserialize<T>() {
            var type = typeof(T);
            var reader = new StreamReader($"{type.Name}.xml");

            var serializer = new XmlSerializer(type);
            var obj = (T) serializer.Deserialize(reader);
            reader.Close();
            return obj;
        }
    }
}