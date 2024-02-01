
namespace Program2
{
    public class Client
    {
        public Client(int id, string name, int amount)
        {
            Id = id;
            Name = name;
            Amount = amount;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
