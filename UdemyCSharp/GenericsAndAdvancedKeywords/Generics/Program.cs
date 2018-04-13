using System;
using AA_Library;

namespace Generics {
    internal static class Program {
        public static void Main(string[] args) {
            var user = new User {Name = "Fulano", Email = "fulano@gmail.com", Id = "12354"};
            var car = new Car {Model = "carrim", Id = "123", Year = "1900"};
            var house = new House {Address = "rua dos bobos", Id = "0"};

            MySerializer.Serialize(user);
            MySerializer.Serialize(car);
            MySerializer.Serialize(house);

            var user2 = MySerializer.Deserialize<User>();
            var car2 = MySerializer.Deserialize<Car>();
            var house2 = MySerializer.Deserialize<House>();
            
            Console.WriteLine(user2);
            Console.WriteLine(car2);
            Console.WriteLine(house2);
        }
    }
}