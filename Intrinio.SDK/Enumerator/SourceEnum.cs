using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{

	/// <summary>
	///     The source of the data
	/// </summary>
	/// <value>The source of the data</value>
	// TODO This came from ApiResponseSecurityIntradayPrices.cs
	public enum SourceEnum
	{
		/// <summary>
		///     Enum Iex for value: iex
		/// </summary>
		[EnumMember(Value = "iex")] Iex = 1,

		/// <summary>
		///     Enum Bats for value: bats
		/// </summary>
		[EnumMember(Value = "bats")] Bats = 2
	}
}