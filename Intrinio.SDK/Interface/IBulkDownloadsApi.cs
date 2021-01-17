using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IBulkDownloadsApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     All Links
		/// </summary>
		/// <remarks>
		///     Returns all active bulk downloads for your account with links to download.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponseBulkDownloadLinks</returns>
		ApiResponseBulkDownloadLinks GetBulkDownloadLinks();

		/// <summary>
		///     All Links
		/// </summary>
		/// <remarks>
		///     Returns all active bulk downloads for your account with links to download.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of ApiResponseBulkDownloadLinks</returns>
		ApiResponse<ApiResponseBulkDownloadLinks> GetBulkDownloadLinksWithHttpInfo();

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     All Links
		/// </summary>
		/// <remarks>
		///     Returns all active bulk downloads for your account with links to download.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponseBulkDownloadLinks</returns>
		Task<ApiResponseBulkDownloadLinks> GetBulkDownloadLinksAsync();

		/// <summary>
		///     All Links
		/// </summary>
		/// <remarks>
		///     Returns all active bulk downloads for your account with links to download.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (ApiResponseBulkDownloadLinks)</returns>
		Task<ApiResponse<ApiResponseBulkDownloadLinks>> GetBulkDownloadLinksAsyncWithHttpInfo();

		#endregion Asynchronous Operations
	}
}