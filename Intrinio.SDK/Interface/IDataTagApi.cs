using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;
using Intrinio.SDK.Model.Search;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDataTagApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     All Data Tags
		/// </summary>
		/// <remarks>
		///     Returns all Data Tags. Returns Data Tags matching parameters when specified.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tag">Tag (optional)</param>
		/// <param name="type">Type (optional)</param>
		/// <param name="parent">ID of tag parent (optional)</param>
		/// <param name="statementCode">Statement Code (optional)</param>
		/// <param name="fsTemplate">Template (optional, default to industrial)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseDataTags</returns>
		ApiResponseDataTags GetAllDataTags(string tag = null, string type = null, string parent = null,
			string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Data Tags
		/// </summary>
		/// <remarks>
		///     Returns all Data Tags. Returns Data Tags matching parameters when specified.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tag">Tag (optional)</param>
		/// <param name="type">Type (optional)</param>
		/// <param name="parent">ID of tag parent (optional)</param>
		/// <param name="statementCode">Statement Code (optional)</param>
		/// <param name="fsTemplate">Template (optional, default to industrial)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseDataTags</returns>
		ApiResponse<ApiResponseDataTags> GetAllDataTagsWithHttpInfo(string tag = null, string type = null,
			string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Lookup Data Tag
		/// </summary>
		/// <remarks>
		///     Returns the Data Tag with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
		/// <returns>DataTag</returns>
		DataTag GetDataTagById(string identifier);

		/// <summary>
		///     Lookup Data Tag
		/// </summary>
		/// <remarks>
		///     Returns the Data Tag with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
		/// <returns>ApiResponse of DataTag</returns>
		ApiResponse<DataTag> GetDataTagByIdWithHttpInfo(string identifier);

		/// <summary>
		///     Search Data Tags
		/// </summary>
		/// <remarks>
		///     Searches for Data Tags matching the text &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseDataTagsSearch</returns>
		ApiResponseDataTagsSearch SearchDataTags(string query, int? pageSize = null);

		/// <summary>
		///     Search Data Tags
		/// </summary>
		/// <remarks>
		///     Searches for Data Tags matching the text &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseDataTagsSearch</returns>
		ApiResponse<ApiResponseDataTagsSearch> SearchDataTagsWithHttpInfo(string query, int? pageSize = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     All Data Tags
		/// </summary>
		/// <remarks>
		///     Returns all Data Tags. Returns Data Tags matching parameters when specified.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tag">Tag (optional)</param>
		/// <param name="type">Type (optional)</param>
		/// <param name="parent">ID of tag parent (optional)</param>
		/// <param name="statementCode">Statement Code (optional)</param>
		/// <param name="fsTemplate">Template (optional, default to industrial)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseDataTags</returns>
		Task<ApiResponseDataTags> GetAllDataTagsAsync(string tag = null, string type = null, string parent = null,
			string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Data Tags
		/// </summary>
		/// <remarks>
		///     Returns all Data Tags. Returns Data Tags matching parameters when specified.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tag">Tag (optional)</param>
		/// <param name="type">Type (optional)</param>
		/// <param name="parent">ID of tag parent (optional)</param>
		/// <param name="statementCode">Statement Code (optional)</param>
		/// <param name="fsTemplate">Template (optional, default to industrial)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseDataTags)</returns>
		Task<ApiResponse<ApiResponseDataTags>> GetAllDataTagsAsyncWithHttpInfo(string tag = null, string type = null,
			string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Lookup Data Tag
		/// </summary>
		/// <remarks>
		///     Returns the Data Tag with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
		/// <returns>Task of DataTag</returns>
		Task<DataTag> GetDataTagByIdAsync(string identifier);

		/// <summary>
		///     Lookup Data Tag
		/// </summary>
		/// <remarks>
		///     Returns the Data Tag with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
		/// <returns>Task of ApiResponse (DataTag)</returns>
		Task<ApiResponse<DataTag>> GetDataTagByIdAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Search Data Tags
		/// </summary>
		/// <remarks>
		///     Searches for Data Tags matching the text &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseDataTagsSearch</returns>
		Task<ApiResponseDataTagsSearch> SearchDataTagsAsync(string query, int? pageSize = null);

		/// <summary>
		///     Search Data Tags
		/// </summary>
		/// <remarks>
		///     Searches for Data Tags matching the text &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseDataTagsSearch)</returns>
		Task<ApiResponse<ApiResponseDataTagsSearch>>
			SearchDataTagsAsyncWithHttpInfo(string query, int? pageSize = null);

		#endregion Asynchronous Operations
	}
}