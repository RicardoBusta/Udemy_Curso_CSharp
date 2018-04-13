namespace AA_Library {
    public class Car {
        public string Model;
        public string Id;
        public string Year;
        
        public override string ToString() {
            return $"Car: Model: {Model}, Id: {Id}, Year: {Year}";
        }
    }
}