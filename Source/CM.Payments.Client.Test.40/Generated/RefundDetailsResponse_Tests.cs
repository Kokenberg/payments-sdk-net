﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.Payments.Client.Model;
using System.Reflection;
using Newtonsoft.Json;
using CM.Payments.Client.Converters;
using CM.Payments.Client.Enums;

//<auto-generated>
//	IMPORTANT NOTE:
//	This code is generated by MessageUnitTestGenerator in this project.
//	Date and time: 06-04-2018 14:52:28
//
//	Changes to this file may cause incorrect behavior and will be lost on the next code generation.
//</auto-generated>
namespace CM.Payments.Client.Test
{
	[TestClass, ExcludeFromCodeCoverage]
	public partial class RefundDetailsResponseTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void RefundDetailsResponse()
		{
			var obj = new RefundDetailsResponse
			{
				CreditTransactionReference = "Lorum_636",
				CreditTransactionStatus = "Lorum_830",
				DebitTransactionReference = "Lorum_605",
				DebitTransactionStatus = "Lorum_782",
				PurchaseId = "Lorum_513",
				RefundBic = "Lorum_296",
				RefundIban = "Lorum_162",
				RefundName = "Lorum_400"
			};
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj.CreditTransactionReference, deserialized.CreditTransactionReference);
			Assert.AreEqual(obj.CreditTransactionStatus, deserialized.CreditTransactionStatus);
			Assert.AreEqual(obj.DebitTransactionReference, deserialized.DebitTransactionReference);
			Assert.AreEqual(obj.DebitTransactionStatus, deserialized.DebitTransactionStatus);
			Assert.AreEqual(obj.PurchaseId, deserialized.PurchaseId);
			Assert.AreEqual(obj.RefundBic, deserialized.RefundBic);
			Assert.AreEqual(obj.RefundIban, deserialized.RefundIban);
			Assert.AreEqual(obj.RefundName, deserialized.RefundName);
		}
	}
}