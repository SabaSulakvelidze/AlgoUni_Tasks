using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Order
    {
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }

        public Order(string productName, int quantity)
        {
            ProductName = productName;
            Quantity = quantity;
        }
    }
}
