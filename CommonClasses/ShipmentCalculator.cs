using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
	public interface IShipmentCalculator
	{
		float CalculateShipping(Order order);
	}


	public class ShipmentCalculator : IShipmentCalculator
	{
		public float CalculateShipping(Order order)
		{
			if (order.TotalPrice < 10f)
				return order.TotalPrice * 0.1f;
			return 0;
		}

	}
}
