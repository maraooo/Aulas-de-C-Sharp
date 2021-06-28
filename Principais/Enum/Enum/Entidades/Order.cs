using System;
using Enum.Entidades.Enum;

namespace Enum.Entidades
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment {get; set;}
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
