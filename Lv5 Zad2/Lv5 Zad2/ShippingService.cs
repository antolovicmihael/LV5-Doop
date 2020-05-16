using System;
using System.Collections.Generic;
using System.Text;

namespace Lv5_Zad2
{
    class ShippingService
    {
        private double massValue = 3.99;

        public double PacketPrice(IShipable item)
        {
            double price;

            price = massValue + item.Weight;

            return massValue;
        }

    }
}
