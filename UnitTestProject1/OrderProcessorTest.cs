using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonClasses;

namespace UnitTestProject1
{
	[TestClass]
	public class OrderProcessorTest
	{
		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void Process_OrderAlreadyShipped_ThrowException()
		{
			FakeShipingCalculator fake = new FakeShipingCalculator();
			OrderProcessor orderprocessor = new OrderProcessor(fake);

			Order ord = new Order { shipment = new Shipment() };

			orderprocessor.Process(ord);
		}
	}


	public class FakeShipingCalculator : IShipmentCalculator
	{
		public float CalculateShipping(Order order)
		{
			return 1;
		}
	}

}


