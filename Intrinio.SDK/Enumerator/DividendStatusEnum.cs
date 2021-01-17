using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     Status of the dividend
	/// </summary>
	/// <value>Status of the dividend</value>
	// TODO This came from DividendRecord.cs
	public enum DividendStatusEnum
	{
		/// <summary>
		///     Enum P for value: P
		/// </summary>
		[EnumMember(Value = "P")] P = 1,

		/// <summary>
		///     Enum X for value: X
		/// </summary>
		[EnumMember(Value = "X")] X = 2,

		/// <summary>
		///     Enum S for value: S
		/// </summary>
		[EnumMember(Value = "S")] S = 3,

		/// <summary>
		///     Enum R for value: R
		/// </summary>
		[EnumMember(Value = "R")] R = 4
	}
}