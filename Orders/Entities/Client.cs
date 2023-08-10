namespace Oders.Entities
{
    class Client
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime BrithDate { get; set; }

        public Client(string name, string email, DateTime brithDate)
        {
            Name = name;
            Email = email;
            BrithDate = brithDate;
        }

        public override string ToString()
        {
            return $"{Name} ({BrithDate}) {Email}";
        }
    }
}