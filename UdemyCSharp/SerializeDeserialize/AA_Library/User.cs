namespace AA_Library {
    public class User {
        public string Name;
        public string Id;
        public string Email;

        public override string ToString() {
            return $"House: Name: {Name}, E-mail: {Email}, Id: {Id}";
        }
    }
}