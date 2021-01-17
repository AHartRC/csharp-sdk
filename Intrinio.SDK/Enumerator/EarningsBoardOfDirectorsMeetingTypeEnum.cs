using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a
	///     Shareholder meeting
	/// </summary>
	/// <value>
	///     The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a
	///     Shareholder meeting
	/// </value>
	// TODO This came from EarningsRecord.cs
	public enum EarningsBoardOfDirectorsMeetingTypeEnum
	{
		/// <summary>
		///     Enum B for value: B
		/// </summary>
		[EnumMember(Value = "B")] B = 1,

		/// <summary>
		///     Enum S for value: S
		/// </summary>
		[EnumMember(Value = "S")] S = 2
	}
}