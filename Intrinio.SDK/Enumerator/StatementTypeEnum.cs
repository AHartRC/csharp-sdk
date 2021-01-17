using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     The format of the financial statment to which this Data Tag belongs
	/// </summary>
	/// <value>The format of the financial statment to which this Data Tag belongs</value>
	// TODO This came from DateTag.cs
	public enum StatementTypeEnum
	{
		/// <summary>
		///     Enum Financial for value: financial
		/// </summary>
		[EnumMember(Value = "financial")] Financial = 1,

		/// <summary>
		///     Enum Industrial for value: industrial
		/// </summary>
		[EnumMember(Value = "industrial")] Industrial = 2
	}
}