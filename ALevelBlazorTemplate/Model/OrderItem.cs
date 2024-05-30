namespace ALevelBlazorTemplate.Model
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Habit Habit { get; set; }


    }
}
