using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     The logic operator to use when screening
	/// </summary>
	/// <value>The logic operator to use when screening</value>
	// TODO This came from SecurityScreenClause.cs
	public enum SecurityScreenClauseOperatorEnum
	{
		/// <summary>
		///     Enum Eq for value: eq
		/// </summary>
		[EnumMember(Value = "eq")] Eq = 1,

		/// <summary>
		///     Enum Gt for value: gt
		/// </summary>
		[EnumMember(Value = "gt")] Gt = 2,

		/// <summary>
		///     Enum Gte for value: gte
		/// </summary>
		[EnumMember(Value = "gte")] Gte = 3,

		/// <summary>
		///     Enum Lt for value: lt
		/// </summary>
		[EnumMember(Value = "lt")] Lt = 4,

		/// <summary>
		///     Enum Lte for value: lte
		/// </summary>
		[EnumMember(Value = "lte")] Lte = 5,

		/// <summary>
		///     Enum Contains for value: contains
		/// </summary>
		[EnumMember(Value = "contains")] Contains = 6
	}
}