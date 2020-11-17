namespace Core.Entities.Customers
{
    public class Branch :BaseEntity
    {
        public string Name { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
