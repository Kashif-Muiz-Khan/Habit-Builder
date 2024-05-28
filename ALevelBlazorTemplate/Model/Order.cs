namespace ALevelBlazorTemplate.Model
{
    public class Order
    {
        public int Id { get; set; }

        public User User { get; set; }
        public List<OrderItem> Items { get; set; } = [];
        public DateOnly Day { get; set; }
        public int TotalPoints => Items.Sum(item => item.Habit.Point);
    }

}
