using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMunicipalityApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     All Municipalities
		/// </summary>
		/// <remarks>
		///     Returns all Municipalities. When parameters are specified, returns matching municipalities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="hasFinancials">Return municipalities with financials (optional)</param>
		/// <param name="governmentName">Return municipalities with a government name matching the given query (optional)</param>
		/// <param name="governmentType">Return municipalities with the given government type (optional)</param>
		/// <param name="areaName">Return municipalities with an area name matching the given query (optional)</param>
		/// <param name="areaType">Return municipalities with the given area type (optional)</param>
		/// <param name="city">Return municipalities in the given city (optional)</param>
		/// <param name="state">Return municipalities in the given state (optional)</param>
		/// <param name="zipcode">Return municipalities in the given zipcode (optional)</param>
		/// <param name="populationGreaterThan">Return municipalities with a population greater than the given number (optional)</param>
		/// <param name="populationLessThan">Return municipalities with a population less than the given number (optional)</param>
		/// <param name="enrollmentGreaterThan">Return municipalities with an enrollment greater than the given number (optional)</param>
		/// <param name="enrollmentLessThan">Return municipalities with an enrollment less than the given number (optional)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseMunicipalities</returns>
		ApiResponseMunicipalities GetAllMunicipalities(bool? hasFinancials = null, string governmentName = null,
			string governmentType = null, string areaName = null, string areaType = null, string city = null,
			string state = null, decimal? zipcode = null, decimal? populationGreaterThan = null,
			decimal? populationLessThan = null, decimal? enrollmentGreaterThan = null,
			decimal? enrollmentLessThan = null, string nextPage = null);

		/// <summary>
		///     All Municipalities
		/// </summary>
		/// <remarks>
		///     Returns all Municipalities. When parameters are specified, returns matching municipalities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="hasFinancials">Return municipalities with financials (optional)</param>
		/// <param name="governmentName">Return municipalities with a government name matching the given query (optional)</param>
		/// <param name="governmentType">Return municipalities with the given government type (optional)</param>
		/// <param name="areaName">Return municipalities with an area name matching the given query (optional)</param>
		/// <param name="areaType">Return municipalities with the given area type (optional)</param>
		/// <param name="city">Return municipalities in the given city (optional)</param>
		/// <param name="state">Return municipalities in the given state (optional)</param>
		/// <param name="zipcode">Return municipalities in the given zipcode (optional)</param>
		/// <param name="populationGreaterThan">Return municipalities with a population greater than the given number (optional)</param>
		/// <param name="populationLessThan">Return municipalities with a population less than the given number (optional)</param>
		/// <param name="enrollmentGreaterThan">Return municipalities with an enrollment greater than the given number (optional)</param>
		/// <param name="enrollmentLessThan">Return municipalities with an enrollment less than the given number (optional)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseMunicipalities</returns>
		ApiResponse<ApiResponseMunicipalities> GetAllMunicipalitiesWithHttpInfo(bool? hasFinancials = null,
			string governmentName = null, string governmentType = null, string areaName = null, string areaType = null,
			string city = null, string state = null, decimal? zipcode = null, decimal? populationGreaterThan = null,
			decimal? populationLessThan = null, decimal? enrollmentGreaterThan = null,
			decimal? enrollmentLessThan = null, string nextPage = null);

		/// <summary>
		///     Municipality by ID
		/// </summary>
		/// <remarks>
		///     Returns the Municipality with the given ID
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <returns>Municipality</returns>
		Municipality GetMunicipalityById(string id);

		/// <summary>
		///     Municipality by ID
		/// </summary>
		/// <remarks>
		///     Returns the Municipality with the given ID
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <returns>ApiResponse of Municipality</returns>
		ApiResponse<Municipality> GetMunicipalityByIdWithHttpInfo(string id);

		/// <summary>
		///     Financials for a Municipality
		/// </summary>
		/// <remarks>
		///     Returns financial statement data for the Municipality with the given ID
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <param name="fiscalYear">Return financials for the given fiscal year (optional)</param>
		/// <returns>ApiResponseMunicipalitiyFinancials</returns>
		ApiResponseMunicipalitiyFinancials GetMunicipalityFinancials(string id, decimal? fiscalYear = null);

		/// <summary>
		///     Financials for a Municipality
		/// </summary>
		/// <remarks>
		///     Returns financial statement data for the Municipality with the given ID
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <param name="fiscalYear">Return financials for the given fiscal year (optional)</param>
		/// <returns>ApiResponse of ApiResponseMunicipalitiyFinancials</returns>
		ApiResponse<ApiResponseMunicipalitiyFinancials> GetMunicipalityFinancialsWithHttpInfo(string id,
			decimal? fiscalYear = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     All Municipalities
		/// </summary>
		/// <remarks>
		///     Returns all Municipalities. When parameters are specified, returns matching municipalities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="hasFinancials">Return municipalities with financials (optional)</param>
		/// <param name="governmentName">Return municipalities with a government name matching the given query (optional)</param>
		/// <param name="governmentType">Return municipalities with the given government type (optional)</param>
		/// <param name="areaName">Return municipalities with an area name matching the given query (optional)</param>
		/// <param name="areaType">Return municipalities with the given area type (optional)</param>
		/// <param name="city">Return municipalities in the given city (optional)</param>
		/// <param name="state">Return municipalities in the given state (optional)</param>
		/// <param name="zipcode">Return municipalities in the given zipcode (optional)</param>
		/// <param name="populationGreaterThan">Return municipalities with a population greater than the given number (optional)</param>
		/// <param name="populationLessThan">Return municipalities with a population less than the given number (optional)</param>
		/// <param name="enrollmentGreaterThan">Return municipalities with an enrollment greater than the given number (optional)</param>
		/// <param name="enrollmentLessThan">Return municipalities with an enrollment less than the given number (optional)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseMunicipalities</returns>
		Task<ApiResponseMunicipalities> GetAllMunicipalitiesAsync(bool? hasFinancials = null,
			string governmentName = null, string governmentType = null, string areaName = null, string areaType = null,
			string city = null, string state = null, decimal? zipcode = null, decimal? populationGreaterThan = null,
			decimal? populationLessThan = null, decimal? enrollmentGreaterThan = null,
			decimal? enrollmentLessThan = null, string nextPage = null);

		/// <summary>
		///     All Municipalities
		/// </summary>
		/// <remarks>
		///     Returns all Municipalities. When parameters are specified, returns matching municipalities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="hasFinancials">Return municipalities with financials (optional)</param>
		/// <param name="governmentName">Return municipalities with a government name matching the given query (optional)</param>
		/// <param name="governmentType">Return municipalities with the given government type (optional)</param>
		/// <param name="areaName">Return municipalities with an area name matching the given query (optional)</param>
		/// <param name="areaType">Return municipalities with the given area type (optional)</param>
		/// <param name="city">Return municipalities in the given city (optional)</param>
		/// <param name="state">Return municipalities in the given state (optional)</param>
		/// <param name="zipcode">Return municipalities in the given zipcode (optional)</param>
		/// <param name="populationGreaterThan">Return municipalities with a population greater than the given number (optional)</param>
		/// <param name="populationLessThan">Return municipalities with a population less than the given number (optional)</param>
		/// <param name="enrollmentGreaterThan">Return municipalities with an enrollment greater than the given number (optional)</param>
		/// <param name="enrollmentLessThan">Return municipalities with an enrollment less than the given number (optional)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseMunicipalities)</returns>
		Task<ApiResponse<ApiResponseMunicipalities>> GetAllMunicipalitiesAsyncWithHttpInfo(bool? hasFinancials = null,
			string governmentName = null, string governmentType = null, string areaName = null, string areaType = null,
			string city = null, string state = null, decimal? zipcode = null, decimal? populationGreaterThan = null,
			decimal? populationLessThan = null, decimal? enrollmentGreaterThan = null,
			decimal? enrollmentLessThan = null, string nextPage = null);

		/// <summary>
		///     Municipality by ID
		/// </summary>
		/// <remarks>
		///     Returns the Municipality with the given ID
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <returns>Task of Municipality</returns>
		Task<Municipality> GetMunicipalityByIdAsync(string id);

		/// <summary>
		///     Municipality by ID
		/// </summary>
		/// <remarks>
		///     Returns the Municipality with the given ID
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <returns>Task of ApiResponse (Municipality)</returns>
		Task<ApiResponse<Municipality>> GetMunicipalityByIdAsyncWithHttpInfo(string id);

		/// <summary>
		///     Financials for a Municipality
		/// </summary>
		/// <remarks>
		///     Returns financial statement data for the Municipality with the given ID
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <param name="fiscalYear">Return financials for the given fiscal year (optional)</param>
		/// <returns>Task of ApiResponseMunicipalitiyFinancials</returns>
		Task<ApiResponseMunicipalitiyFinancials> GetMunicipalityFinancialsAsync(string id, decimal? fiscalYear = null);

		/// <summary>
		///     Financials for a Municipality
		/// </summary>
		/// <remarks>
		///     Returns financial statement data for the Municipality with the given ID
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <param name="fiscalYear">Return financials for the given fiscal year (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseMunicipalitiyFinancials)</returns>
		Task<ApiResponse<ApiResponseMunicipalitiyFinancials>> GetMunicipalityFinancialsAsyncWithHttpInfo(string id,
			decimal? fiscalYear = null);

		#endregion Asynchronous Operations
	}
}