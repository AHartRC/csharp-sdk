using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     The type of period that the stock price represents
	/// </summary>
	/// <value>The type of period that the stock price represents</value>
	// TODO This came from StockPrice.cs
	public enum StockPriceFrequencyEnum
	{
		/// <summary>
		///     Enum Daily for value: daily
		/// </summary>
		[EnumMember(Value = "daily")] Daily = 1,

		/// <summary>
		///     Enum Weekly for value: weekly
		/// </summary>
		[EnumMember(Value = "weekly")] Weekly = 2,

		/// <summary>
		///     Enum Monthly for value: monthly
		/// </summary>
		[EnumMember(Value = "monthly")] Monthly = 3,

		/// <summary>
		///     Enum Quarterly for value: quarterly
		/// </summary>
		[EnumMember(Value = "quarterly")] Quarterly = 4,

		/// <summary>
		///     Enum Yearly for value: yearly
		/// </summary>
		[EnumMember(Value = "yearly")] Yearly = 5
	}
}