using System;
using Enum.Entidades;
using Enum.Entidades.Enum;


namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {Id = 1080, Moment = DateTime.Now, Status = OrderStatus.Delivered};

            Console.WriteLine(order);
        }
    }
}
