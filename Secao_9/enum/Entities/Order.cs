using System;
using Enums_Exemplo.Entities.Enums;

namespace Enums_Exemplo.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}
