using System.Collections.Generic;
using System.Linq;
using AA_Library;
using ExtensionMethods;

namespace C_LINQ_Obj {
    internal class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                new User{Name = "Joao", Email = "joao@xyz", Id = "1"},
                new User{Name = "Maria", Email = "maria@abc", Id = "2"},
                new User{Name = "Jose", Email = "jose@abc", Id = "3"},
                new User{Name = "Fulano", Email = "fulano@xyz", Id = "4"},
                new User{Name = "Sicrano", Email = "sicrano@abc", Id = "5"},
            };

            var xyzUsers = users.Where(user => user.Email.EndsWith("xyz")).OrderBy(user => user.Name);
            xyzUsers.PrintArray("\n");
        }
    }
}