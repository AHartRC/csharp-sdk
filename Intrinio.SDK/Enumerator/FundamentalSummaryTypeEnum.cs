using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     The type of Fundamental
	/// </summary>
	/// <value>The type of Fundamental</value>
	// TODO This came from FundamentalSummary.cs
	public enum FundamentalSummaryTypeEnum
	{
		/// <summary>
		///     Enum Reported for value: reported
		/// </summary>
		[EnumMember(Value = "reported")] Reported = 1,

		/// <summary>
		///     Enum Restated for value: restated
		/// </summary>
		[EnumMember(Value = "restated")] Restated = 2,

		/// <summary>
		///     Enum Calculated for value: calculated
		/// </summary>
		[EnumMember(Value = "calculated")] Calculated = 3
	}
}