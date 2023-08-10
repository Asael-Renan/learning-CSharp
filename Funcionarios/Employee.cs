namespace MyApp {
    public class Employee {
        public int id { get; set; }
        public string? name;
        public double salary { get; set; }

        public void increaseSalary(double percentage) {
            salary += salary / percentage;
        }
    }
}