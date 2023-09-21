using Empower.Library.Room0;

namespace SLC_AS_XWATest_1
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Text;
	using Skyline.DataMiner.Automation;
	
	/// <summary>
	/// Represents a DataMiner Automation script.
	/// </summary>
	public class Script
	{
        /// <summary>
        /// The script entry point.
        /// </summary>
        /// <param name="engine">Link with SLAutomation process.</param>
        public void Run(IEngine engine)
        {
            engine.GenerateInformation("Hello World!");
            var order = OrderFactory.CreateOrder("JansChange 2 number 9s, a number 6 with extra dip and a large soda");
            order.Dispatch("Leroy Jenkins");
        }
    }
}