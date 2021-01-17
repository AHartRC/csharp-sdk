using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     Indicates the time of the announcement
	/// </summary>
	/// <value>Indicates the time of the announcement</value>
	// TODO This came from EarningsRecord.cs
	public enum EarningsTimeOfDayEnum
	{
		/// <summary>
		///     Enum BeforeMarket for value: Before Market
		/// </summary>
		[EnumMember(Value = "Before Market")] BeforeMarket = 1,

		/// <summary>
		///     Enum DuringMarket for value: During Market
		/// </summary>
		[EnumMember(Value = "During Market")] DuringMarket = 2,

		/// <summary>
		///     Enum AfterMarket for value: After Market
		/// </summary>
		[EnumMember(Value = "After Market")] AfterMarket = 3,

		/// <summary>
		///     Enum Unspecified for value: Unspecified
		/// </summary>
		[EnumMember(Value = "Unspecified")] Unspecified = 4
	}
}