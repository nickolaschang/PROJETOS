using System;
using ProgramaEnumeracao.Entities.Enums;
using ProgramaEnumeracao.Entities;
namespace ProgramaEnumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entities.Enums.OrderStatus.PendingPayment
                
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>(txt);

            Console.WriteLine(txt);
        }
    }
}
