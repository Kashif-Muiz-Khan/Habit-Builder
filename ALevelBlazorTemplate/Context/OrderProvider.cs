using ALevelBlazorTemplate.Context;
using ALevelBlazorTemplate.Model;
using Microsoft.EntityFrameworkCore;


namespace ALevelBlazorTemplate.Context
{
    public class OrderProvider
    {
        private readonly DatabaseContext _context;

        public OrderProvider(DatabaseContext context)
        {
            _context = context;
        }



        public async Task<List<Order>?> GetAllOrdersAsync()
        {
            // Return all orders
            return await _context.Orders
                .Include(order => order.User)
                .Include(order => order.Items)
                .ThenInclude(item => item.Habit)
                .OrderBy(order => order.Id)
                .ToListAsync();
        }

        public async Task CreateOrder(User user, IEnumerable<OrderItem> items)
        {
            // Create a new order
            var order = new Order
            {
                User = user,
                Items = items.Select(item => new OrderItem
                {
                    Habit = item.Habit
                }).ToList(),
                Day = DateOnly.FromDateTime(DateTime.Now),
            };

            // Add the order to the database
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        

        public async Task<Order?> GetOrderAsync(int id)
        {
            // Return the order with the specified ID
            return await _context.Orders
                .Include(order => order.User)
                .Include(order => order.Items)
                .ThenInclude(item => item.Habit.Id)
                .Include(item => item.TotalPoints)
                .FirstOrDefaultAsync(order => order.Id == id);
        }


        public async Task<int> GetTotalOrdersForUserAsync(User user)
        {
            // Return the total number of orders for the specified user
            return await _context.Orders
                .Where(order => order.User.Id == user.Id)
                .CountAsync();
        }





    }
}