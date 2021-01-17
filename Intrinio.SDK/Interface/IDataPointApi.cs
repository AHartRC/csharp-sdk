using System.Threading.Tasks;
using Intrinio.SDK.Client;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDataPointApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     Data Point (Number)
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <returns>decimal?</returns>
		decimal? GetDataPointNumber(string identifier, string tag);

		/// <summary>
		///     Data Point (Number)
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <returns>ApiResponse of decimal?</returns>
		ApiResponse<decimal?> GetDataPointNumberWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Data Point (Text)
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <returns>string</returns>
		string GetDataPointText(string identifier, string tag);

		/// <summary>
		///     Data Point (Text)
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <returns>ApiResponse of string</returns>
		ApiResponse<string> GetDataPointTextWithHttpInfo(string identifier, string tag);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     Data Point (Number)
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <returns>Task of decimal?</returns>
		Task<decimal?> GetDataPointNumberAsync(string identifier, string tag);

		/// <summary>
		///     Data Point (Number)
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <returns>Task of ApiResponse (decimal?)</returns>
		Task<ApiResponse<decimal?>> GetDataPointNumberAsyncWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Data Point (Text)
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <returns>Task of string</returns>
		Task<string> GetDataPointTextAsync(string identifier, string tag);

		/// <summary>
		///     Data Point (Text)
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <returns>Task of ApiResponse (string)</returns>
		Task<ApiResponse<string>> GetDataPointTextAsyncWithHttpInfo(string identifier, string tag);

		#endregion Asynchronous Operations
	}
}