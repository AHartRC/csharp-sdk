using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot;
	///     indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot;
	///     indicates that the date is forecased or Inferred
	/// </summary>
	/// <value>
	///     The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot;
	///     indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot;
	///     indicates that the date is forecased or Inferred
	/// </value>
	// TODO This came from EarningsRecord.cs
	public enum EarningsTypeEnum
	{
		/// <summary>
		///     Enum V for value: V
		/// </summary>
		[EnumMember(Value = "V")] V = 1,

		/// <summary>
		///     Enum T for value: T
		/// </summary>
		[EnumMember(Value = "T")] T = 2,

		/// <summary>
		///     Enum I for value: I
		/// </summary>
		[EnumMember(Value = "I")] I = 3
	}
}