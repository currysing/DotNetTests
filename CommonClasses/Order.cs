using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
	public class Order
	{
		public float TotalPrice { get; set; }
		public DateTime DatePlaced { get; set; }

		public bool IsShipped {
			get
			{
				return shipment != null;
			}
		}

		public Shipment shipment { get; set; }
	}
}
