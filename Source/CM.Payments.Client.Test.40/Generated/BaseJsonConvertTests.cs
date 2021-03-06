﻿using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

//<auto-generated>
//	IMPORTANT NOTE:
//	This code is generated by MessageUnitTestGenerator in this project.
//	Date and time: 06-04-2018 14:52:27
//
//	Changes to this file may cause incorrect behavior and will be lost on the next code generation.
//</auto-generated>
namespace CM.Payments.Client.Test
{
	[ExcludeFromCodeCoverage]
	public abstract class BaseJsonConvertTests
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BaseJsonConvertTests"/> class.
		/// </summary>
		protected BaseJsonConvertTests()
		{
			JsonConvert.DefaultSettings = () => new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				ContractResolver = new DefaultContractResolver(),
				ObjectCreationHandling = ObjectCreationHandling.Replace
			};
		}

		/// <summary>
		/// Conversions the test.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj">The object.</param>
		/// <returns></returns>
		public T ConversionTest<T>(T obj)
		{
			Assert.IsNotNull(obj);
			var serialized = JsonConvert.SerializeObject(obj);
			Assert.IsNotNull(serialized);
			var deserialized = JsonConvert.DeserializeObject<T>(serialized);
			Assert.IsNotNull(deserialized);
			return deserialized;
		}
	}
}
