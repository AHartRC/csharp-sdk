using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     The type of Option (put or call).
	/// </summary>
	/// <value>The type of Option (put or call).</value>
	// TODO This came from OptionRealtime.cs
	public enum OptionRealtimeTypeEnum
	{
		/// <summary>
		///     Enum Put for value: put
		/// </summary>
		[EnumMember(Value = "put")] Put = 1,

		/// <summary>
		///     Enum Call for value: call
		/// </summary>
		[EnumMember(Value = "call")] Call = 2
	}
}