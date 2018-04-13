namespace AA_Library {
    public class House {
        public string Address;
        public string Id;
        
        public override string ToString() {
            return $"House: Address: {Address}, Id:{Id}";
        }
    }
}