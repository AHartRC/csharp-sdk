using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Interface;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Api
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public class MunicipalityApi : IMunicipalityApi
	{
		private ExceptionFactory _exceptionFactory = (name, response) => null;

		/// <summary>
		///     Initializes a new instance of the <see cref="MunicipalityApi" /> class.
		/// </summary>
		/// <returns></returns>
		public MunicipalityApi(string basePath)
		{
			Configuration = new Configuration {BasePath = basePath};

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="MunicipalityApi" /> class
		///     using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public MunicipalityApi(Configuration configuration = null)
		{
			if (configuration == null) // use the default one in Configuration
				Configuration = Configuration.Default;
			else
				Configuration = configuration;

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Gets the base path of the API client.
		/// </summary>
		/// <value>The base path</value>
		public string GetBasePath()
		{
			return Configuration.ApiClient.RestClient.BaseUrl.ToString();
		}

		/// <summary>
		///     Gets or sets the configuration object
		/// </summary>
		/// <value>An instance of the Configuration</value>
		public Configuration Configuration { get; set; }

		/// <summary>
		///     Provides a factory method hook for the creation of exceptions.
		/// </summary>
		public ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				return _exceptionFactory;
			}
			set => _exceptionFactory = value;
		}

		/// <summary>
		///     All Municipalities Returns all Municipalities. When parameters are specified, returns matching municipalities.
		/// </summary>
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
		public ApiResponseMunicipalities GetAllMunicipalities(bool? hasFinancials = null, string governmentName = null,
			string governmentType = null, string areaName = null, string areaType = null, string city = null,
			string state = null, decimal? zipcode = null, decimal? populationGreaterThan = null,
			decimal? populationLessThan = null, decimal? enrollmentGreaterThan = null,
			decimal? enrollmentLessThan = null, string nextPage = null)
		{
			var localVarResponse = GetAllMunicipalitiesWithHttpInfo(hasFinancials, governmentName, governmentType,
				areaName, areaType, city, state, zipcode, populationGreaterThan, populationLessThan,
				enrollmentGreaterThan, enrollmentLessThan, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All Municipalities Returns all Municipalities. When parameters are specified, returns matching municipalities.
		/// </summary>
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
		public ApiResponse<ApiResponseMunicipalities> GetAllMunicipalitiesWithHttpInfo(bool? hasFinancials = null,
			string governmentName = null, string governmentType = null, string areaName = null, string areaType = null,
			string city = null, string state = null, decimal? zipcode = null, decimal? populationGreaterThan = null,
			decimal? populationLessThan = null, decimal? enrollmentGreaterThan = null,
			decimal? enrollmentLessThan = null, string nextPage = null)
		{
			var localVarPath = "/municipalities";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (hasFinancials != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "has_financials",
						hasFinancials)); // query parameter
			if (governmentName != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "government_name",
						governmentName)); // query parameter
			if (governmentType != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "government_type",
						governmentType)); // query parameter
			if (areaName != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "area_name", areaName)); // query parameter
			if (areaType != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "area_type", areaType)); // query parameter
			if (city != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "city", city)); // query parameter
			if (state != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "state", state)); // query parameter
			if (zipcode != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "zipcode", zipcode)); // query parameter
			if (populationGreaterThan != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "population_greater_than",
						populationGreaterThan)); // query parameter
			if (populationLessThan != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "population_less_than",
						populationLessThan)); // query parameter
			if (enrollmentGreaterThan != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "enrollment_greater_than",
						enrollmentGreaterThan)); // query parameter
			if (enrollmentLessThan != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "enrollment_less_than",
						enrollmentLessThan)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetAllMunicipalities", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseMunicipalities>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseMunicipalities) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseMunicipalities)));
		}

		/// <summary>
		///     All Municipalities Returns all Municipalities. When parameters are specified, returns matching municipalities.
		/// </summary>
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
		public async Task<ApiResponseMunicipalities> GetAllMunicipalitiesAsync(bool? hasFinancials = null,
			string governmentName = null, string governmentType = null, string areaName = null, string areaType = null,
			string city = null, string state = null, decimal? zipcode = null, decimal? populationGreaterThan = null,
			decimal? populationLessThan = null, decimal? enrollmentGreaterThan = null,
			decimal? enrollmentLessThan = null, string nextPage = null)
		{
			var localVarResponse = await GetAllMunicipalitiesAsyncWithHttpInfo(hasFinancials, governmentName,
				governmentType, areaName, areaType, city, state, zipcode, populationGreaterThan, populationLessThan,
				enrollmentGreaterThan, enrollmentLessThan, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All Municipalities Returns all Municipalities. When parameters are specified, returns matching municipalities.
		/// </summary>
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
		public async Task<ApiResponse<ApiResponseMunicipalities>> GetAllMunicipalitiesAsyncWithHttpInfo(
			bool? hasFinancials = null, string governmentName = null, string governmentType = null,
			string areaName = null, string areaType = null, string city = null, string state = null,
			decimal? zipcode = null, decimal? populationGreaterThan = null, decimal? populationLessThan = null,
			decimal? enrollmentGreaterThan = null, decimal? enrollmentLessThan = null, string nextPage = null)
		{
			var localVarPath = "/municipalities";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (hasFinancials != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "has_financials",
						hasFinancials)); // query parameter
			if (governmentName != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "government_name",
						governmentName)); // query parameter
			if (governmentType != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "government_type",
						governmentType)); // query parameter
			if (areaName != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "area_name", areaName)); // query parameter
			if (areaType != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "area_type", areaType)); // query parameter
			if (city != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "city", city)); // query parameter
			if (state != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "state", state)); // query parameter
			if (zipcode != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "zipcode", zipcode)); // query parameter
			if (populationGreaterThan != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "population_greater_than",
						populationGreaterThan)); // query parameter
			if (populationLessThan != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "population_less_than",
						populationLessThan)); // query parameter
			if (enrollmentGreaterThan != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "enrollment_greater_than",
						enrollmentGreaterThan)); // query parameter
			if (enrollmentLessThan != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "enrollment_less_than",
						enrollmentLessThan)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetAllMunicipalities", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseMunicipalities>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseMunicipalities) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseMunicipalities)));
		}

		/// <summary>
		///     Municipality by ID Returns the Municipality with the given ID
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <returns>Municipality</returns>
		public Municipality GetMunicipalityById(string id)
		{
			var localVarResponse = GetMunicipalityByIdWithHttpInfo(id);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Municipality by ID Returns the Municipality with the given ID
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <returns>ApiResponse of Municipality</returns>
		public ApiResponse<Municipality> GetMunicipalityByIdWithHttpInfo(string id)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling MunicipalityApi->GetMunicipalityById");

			var localVarPath = "/municipalities/{id}";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetMunicipalityById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Municipality>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Municipality) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Municipality)));
		}

		/// <summary>
		///     Municipality by ID Returns the Municipality with the given ID
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <returns>Task of Municipality</returns>
		public async Task<Municipality> GetMunicipalityByIdAsync(string id)
		{
			var localVarResponse = await GetMunicipalityByIdAsyncWithHttpInfo(id);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Municipality by ID Returns the Municipality with the given ID
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <returns>Task of ApiResponse (Municipality)</returns>
		public async Task<ApiResponse<Municipality>> GetMunicipalityByIdAsyncWithHttpInfo(string id)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling MunicipalityApi->GetMunicipalityById");

			var localVarPath = "/municipalities/{id}";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetMunicipalityById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Municipality>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Municipality) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Municipality)));
		}

		/// <summary>
		///     Financials for a Municipality Returns financial statement data for the Municipality with the given ID
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <param name="fiscalYear">Return financials for the given fiscal year (optional)</param>
		/// <returns>ApiResponseMunicipalitiyFinancials</returns>
		public ApiResponseMunicipalitiyFinancials GetMunicipalityFinancials(string id, decimal? fiscalYear = null)
		{
			var localVarResponse = GetMunicipalityFinancialsWithHttpInfo(id, fiscalYear);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Financials for a Municipality Returns financial statement data for the Municipality with the given ID
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <param name="fiscalYear">Return financials for the given fiscal year (optional)</param>
		/// <returns>ApiResponse of ApiResponseMunicipalitiyFinancials</returns>
		public ApiResponse<ApiResponseMunicipalitiyFinancials> GetMunicipalityFinancialsWithHttpInfo(string id,
			decimal? fiscalYear = null)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling MunicipalityApi->GetMunicipalityFinancials");

			var localVarPath = "/municipalities/{id}/financials";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
			if (fiscalYear != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetMunicipalityFinancials", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseMunicipalitiyFinancials>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseMunicipalitiyFinancials) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseMunicipalitiyFinancials)));
		}

		/// <summary>
		///     Financials for a Municipality Returns financial statement data for the Municipality with the given ID
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <param name="fiscalYear">Return financials for the given fiscal year (optional)</param>
		/// <returns>Task of ApiResponseMunicipalitiyFinancials</returns>
		public async Task<ApiResponseMunicipalitiyFinancials> GetMunicipalityFinancialsAsync(string id,
			decimal? fiscalYear = null)
		{
			var localVarResponse = await GetMunicipalityFinancialsAsyncWithHttpInfo(id, fiscalYear);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Financials for a Municipality Returns financial statement data for the Municipality with the given ID
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">An Intrinio ID of a Municipality</param>
		/// <param name="fiscalYear">Return financials for the given fiscal year (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseMunicipalitiyFinancials)</returns>
		public async Task<ApiResponse<ApiResponseMunicipalitiyFinancials>> GetMunicipalityFinancialsAsyncWithHttpInfo(
			string id, decimal? fiscalYear = null)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling MunicipalityApi->GetMunicipalityFinancials");

			var localVarPath = "/municipalities/{id}/financials";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
			if (fiscalYear != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetMunicipalityFinancials", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseMunicipalitiyFinancials>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseMunicipalitiyFinancials) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseMunicipalitiyFinancials)));
		}

		/// <summary>
		///     Sets the base path of the API client.
		/// </summary>
		/// <value>The base path</value>
		[Obsolete(
			"SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
		public void SetBasePath(string basePath)
		{
			// do nothing
		}

		/// <summary>
		///     Gets the default header.
		/// </summary>
		/// <returns>Dictionary of HTTP header</returns>
		[Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
		public IDictionary<string, string> DefaultHeader()
		{
			return new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);
		}

		/// <summary>
		///     Add default header.
		/// </summary>
		/// <param name="key">Header field name.</param>
		/// <param name="value">Header field value.</param>
		/// <returns></returns>
		[Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
		public void AddDefaultHeader(string key, string value)
		{
			Configuration.AddDefaultHeader(key, value);
		}
	}
}