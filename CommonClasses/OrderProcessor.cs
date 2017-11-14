using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
	public class OrderProcessor
	{
		//readonly ShipmentCalculator calculator;
		readonly IShipmentCalculator calculator;

		public OrderProcessor(IShipmentCalculator shipmentCalculator)
		{
			calculator = shipmentCalculator;
		}

		public void Process(Order order)
		{
			if (order.IsShipped) throw new InvalidOperationException("Order already shipped");

			order.shipment = new Shipment
			{
				Cost = calculator.CalculateShipping(order),
				ShippingDate = DateTime.Today.AddDays(1)
			};
		}
	}
}
