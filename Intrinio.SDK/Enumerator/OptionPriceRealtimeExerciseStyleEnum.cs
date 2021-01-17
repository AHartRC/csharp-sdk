using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;E\&quot; &#x3D; \&quot;
	///     European\&quot;)
	/// </summary>
	/// <value>
	///     The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;E\&quot; &#x3D; \
	///     &quot;European\&quot;)
	/// </value>
	// TODO This came from OptionPriceRealtime
	public enum OptionPriceRealtimeExerciseStyleEnum
	{
		/// <summary>
		///     Enum A for value: A
		/// </summary>
		[EnumMember(Value = "A")] A = 1,

		/// <summary>
		///     Enum E for value: E
		/// </summary>
		[EnumMember(Value = "E")] E = 2
	}
}