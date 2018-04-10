namespace AA_Library {
    public class User {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }

        public override string ToString() {
            return $"Read: Name: {Name}, E-mail: {Email}, Id: {Id}";
        }
    }
}