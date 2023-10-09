using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbitmq
{
    public class BusConstants
    {
        public const string RabbitMqUri = "rabbitmq://localhost:5673/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string OrderQueue = "validate-order-queue";
    }
}
