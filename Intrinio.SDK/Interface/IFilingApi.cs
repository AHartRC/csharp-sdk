using System;
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
	public interface IFilingApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     All Filings
		/// </summary>
		/// <remarks>
		///     Returns all Filings. Returns Filings matching parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="reportType">
		///     Filter by report type. Separate values with commas to return multiple The filing &lt;a href
		///     &#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\
		///     &quot;&gt;report types&lt;/a&gt;. (optional)
		/// </param>
		/// <param name="startDate">Filed on or after the given date (optional)</param>
		/// <param name="endDate">Filed before or after the given date (optional)</param>
		/// <param name="industryCategory">Return companies in the given industry category (optional)</param>
		/// <param name="industryGroup">Return companies in the given industry group (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseFilings</returns>
		ApiResponseFilings GetAllFilings(string company, string reportType = null, DateTime? startDate = null,
			DateTime? endDate = null, string industryCategory = null, string industryGroup = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     All Filings
		/// </summary>
		/// <remarks>
		///     Returns all Filings. Returns Filings matching parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="reportType">
		///     Filter by report type. Separate values with commas to return multiple The filing &lt;a href
		///     &#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\
		///     &quot;&gt;report types&lt;/a&gt;. (optional)
		/// </param>
		/// <param name="startDate">Filed on or after the given date (optional)</param>
		/// <param name="endDate">Filed before or after the given date (optional)</param>
		/// <param name="industryCategory">Return companies in the given industry category (optional)</param>
		/// <param name="industryGroup">Return companies in the given industry group (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseFilings</returns>
		ApiResponse<ApiResponseFilings> GetAllFilingsWithHttpInfo(string company, string reportType = null,
			DateTime? startDate = null, DateTime? endDate = null, string industryCategory = null,
			string industryGroup = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Filing Notes
		/// </summary>
		/// <remarks>
		///     Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="reportType">
		///     Notes contained in filings that match the given &lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report
		///     type&lt;/a&gt; (optional)
		/// </param>
		/// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
		/// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
		/// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
		/// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseFilingNotes</returns>
		ApiResponseFilingNotes GetAllNotes(string company = null, string reportType = null,
			DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null,
			DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Filing Notes
		/// </summary>
		/// <remarks>
		///     Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="reportType">
		///     Notes contained in filings that match the given &lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report
		///     type&lt;/a&gt; (optional)
		/// </param>
		/// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
		/// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
		/// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
		/// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseFilingNotes</returns>
		ApiResponse<ApiResponseFilingNotes> GetAllNotesWithHttpInfo(string company = null, string reportType = null,
			DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null,
			DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Lookup Filing
		/// </summary>
		/// <remarks>
		///     Returns the Filing with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID of the Filing</param>
		/// <returns>Filing</returns>
		Filing GetFilingById(string id);

		/// <summary>
		///     Lookup Filing
		/// </summary>
		/// <remarks>
		///     Returns the Filing with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID of the Filing</param>
		/// <returns>ApiResponse of Filing</returns>
		ApiResponse<Filing> GetFilingByIdWithHttpInfo(string id);

		/// <summary>
		///     All Fundamentals by Filing
		/// </summary>
		/// <remarks>
		///     Returns all Fundamentals for the SEC Filing with the given &#x60;identifier&#x60;. Returns Fundamentals matching
		///     parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <param name="statementCode">Filters fundamentals by statement code (optional)</param>
		/// <param name="type">Filters fundamentals by type (optional)</param>
		/// <param name="fiscalYear">Filters fundamentals by fiscal year (optional)</param>
		/// <param name="fiscalPeriod">Filters fundamentals by fiscal period (optional)</param>
		/// <param name="startDate">Returns fundamentals on or after the given date (optional)</param>
		/// <param name="endDate">Returns fundamentals on or before the given date (optional)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseFilingFundamentals</returns>
		ApiResponseFilingFundamentals GetFilingFundamentals(string identifier, string statementCode = null,
			string type = null, int? fiscalYear = null, string fiscalPeriod = null, DateTime? startDate = null,
			DateTime? endDate = null, string nextPage = null);

		/// <summary>
		///     All Fundamentals by Filing
		/// </summary>
		/// <remarks>
		///     Returns all Fundamentals for the SEC Filing with the given &#x60;identifier&#x60;. Returns Fundamentals matching
		///     parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <param name="statementCode">Filters fundamentals by statement code (optional)</param>
		/// <param name="type">Filters fundamentals by type (optional)</param>
		/// <param name="fiscalYear">Filters fundamentals by fiscal year (optional)</param>
		/// <param name="fiscalPeriod">Filters fundamentals by fiscal period (optional)</param>
		/// <param name="startDate">Returns fundamentals on or after the given date (optional)</param>
		/// <param name="endDate">Returns fundamentals on or before the given date (optional)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseFilingFundamentals</returns>
		ApiResponse<ApiResponseFilingFundamentals> GetFilingFundamentalsWithHttpInfo(string identifier,
			string statementCode = null, string type = null, int? fiscalYear = null, string fiscalPeriod = null,
			DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

		/// <summary>
		///     Filing Html
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <returns>string</returns>
		string GetFilingHtml(string identifier);

		/// <summary>
		///     Filing Html
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <returns>ApiResponse of string</returns>
		ApiResponse<string> GetFilingHtmlWithHttpInfo(string identifier);

		/// <summary>
		///     Filing Text
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <returns>string</returns>
		string GetFilingText(string identifier);

		/// <summary>
		///     Filing Text
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <returns>ApiResponse of string</returns>
		ApiResponse<string> GetFilingTextWithHttpInfo(string identifier);

		/// <summary>
		///     Filing Note by ID
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
		/// <returns>FilingNote</returns>
		FilingNote GetNote(string identifier, string contentFormat = null);

		/// <summary>
		///     Filing Note by ID
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
		/// <returns>ApiResponse of FilingNote</returns>
		ApiResponse<FilingNote> GetNoteWithHttpInfo(string identifier, string contentFormat = null);

		/// <summary>
		///     Filing Note HTML
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <returns>string</returns>
		string GetNoteHtml(string identifier);

		/// <summary>
		///     Filing Note HTML
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <returns>ApiResponse of string</returns>
		ApiResponse<string> GetNoteHtmlWithHttpInfo(string identifier);

		/// <summary>
		///     Filing Note Text
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <returns>string</returns>
		string GetNoteText(string identifier);

		/// <summary>
		///     Filing Note Text
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <returns>ApiResponse of string</returns>
		ApiResponse<string> GetNoteTextWithHttpInfo(string identifier);

		/// <summary>
		///     Search Filing Notes
		/// </summary>
		/// <remarks>
		///     Searches for Filing Notes using the &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search for notes that contain all or parts of this text</param>
		/// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
		/// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseFilingNotesSearch</returns>
		ApiResponseFilingNotesSearch SearchNotes(string query, DateTime? filingStartDate = null,
			DateTime? filingEndDate = null, int? pageSize = null);

		/// <summary>
		///     Search Filing Notes
		/// </summary>
		/// <remarks>
		///     Searches for Filing Notes using the &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search for notes that contain all or parts of this text</param>
		/// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
		/// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseFilingNotesSearch</returns>
		ApiResponse<ApiResponseFilingNotesSearch> SearchNotesWithHttpInfo(string query,
			DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     All Filings
		/// </summary>
		/// <remarks>
		///     Returns all Filings. Returns Filings matching parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="reportType">
		///     Filter by report type. Separate values with commas to return multiple The filing &lt;a href
		///     &#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\
		///     &quot;&gt;report types&lt;/a&gt;. (optional)
		/// </param>
		/// <param name="startDate">Filed on or after the given date (optional)</param>
		/// <param name="endDate">Filed before or after the given date (optional)</param>
		/// <param name="industryCategory">Return companies in the given industry category (optional)</param>
		/// <param name="industryGroup">Return companies in the given industry group (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseFilings</returns>
		Task<ApiResponseFilings> GetAllFilingsAsync(string company, string reportType = null,
			DateTime? startDate = null, DateTime? endDate = null, string industryCategory = null,
			string industryGroup = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Filings
		/// </summary>
		/// <remarks>
		///     Returns all Filings. Returns Filings matching parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="reportType">
		///     Filter by report type. Separate values with commas to return multiple The filing &lt;a href
		///     &#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\
		///     &quot;&gt;report types&lt;/a&gt;. (optional)
		/// </param>
		/// <param name="startDate">Filed on or after the given date (optional)</param>
		/// <param name="endDate">Filed before or after the given date (optional)</param>
		/// <param name="industryCategory">Return companies in the given industry category (optional)</param>
		/// <param name="industryGroup">Return companies in the given industry group (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseFilings)</returns>
		Task<ApiResponse<ApiResponseFilings>> GetAllFilingsAsyncWithHttpInfo(string company, string reportType = null,
			DateTime? startDate = null, DateTime? endDate = null, string industryCategory = null,
			string industryGroup = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Filing Notes
		/// </summary>
		/// <remarks>
		///     Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="reportType">
		///     Notes contained in filings that match the given &lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report
		///     type&lt;/a&gt; (optional)
		/// </param>
		/// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
		/// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
		/// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
		/// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseFilingNotes</returns>
		Task<ApiResponseFilingNotes> GetAllNotesAsync(string company = null, string reportType = null,
			DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null,
			DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Filing Notes
		/// </summary>
		/// <remarks>
		///     Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="reportType">
		///     Notes contained in filings that match the given &lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report
		///     type&lt;/a&gt; (optional)
		/// </param>
		/// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
		/// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
		/// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
		/// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseFilingNotes)</returns>
		Task<ApiResponse<ApiResponseFilingNotes>> GetAllNotesAsyncWithHttpInfo(string company = null,
			string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null,
			DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Lookup Filing
		/// </summary>
		/// <remarks>
		///     Returns the Filing with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID of the Filing</param>
		/// <returns>Task of Filing</returns>
		Task<Filing> GetFilingByIdAsync(string id);

		/// <summary>
		///     Lookup Filing
		/// </summary>
		/// <remarks>
		///     Returns the Filing with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID of the Filing</param>
		/// <returns>Task of ApiResponse (Filing)</returns>
		Task<ApiResponse<Filing>> GetFilingByIdAsyncWithHttpInfo(string id);

		/// <summary>
		///     All Fundamentals by Filing
		/// </summary>
		/// <remarks>
		///     Returns all Fundamentals for the SEC Filing with the given &#x60;identifier&#x60;. Returns Fundamentals matching
		///     parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <param name="statementCode">Filters fundamentals by statement code (optional)</param>
		/// <param name="type">Filters fundamentals by type (optional)</param>
		/// <param name="fiscalYear">Filters fundamentals by fiscal year (optional)</param>
		/// <param name="fiscalPeriod">Filters fundamentals by fiscal period (optional)</param>
		/// <param name="startDate">Returns fundamentals on or after the given date (optional)</param>
		/// <param name="endDate">Returns fundamentals on or before the given date (optional)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseFilingFundamentals</returns>
		Task<ApiResponseFilingFundamentals> GetFilingFundamentalsAsync(string identifier, string statementCode = null,
			string type = null, int? fiscalYear = null, string fiscalPeriod = null, DateTime? startDate = null,
			DateTime? endDate = null, string nextPage = null);

		/// <summary>
		///     All Fundamentals by Filing
		/// </summary>
		/// <remarks>
		///     Returns all Fundamentals for the SEC Filing with the given &#x60;identifier&#x60;. Returns Fundamentals matching
		///     parameters when supplied.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <param name="statementCode">Filters fundamentals by statement code (optional)</param>
		/// <param name="type">Filters fundamentals by type (optional)</param>
		/// <param name="fiscalYear">Filters fundamentals by fiscal year (optional)</param>
		/// <param name="fiscalPeriod">Filters fundamentals by fiscal period (optional)</param>
		/// <param name="startDate">Returns fundamentals on or after the given date (optional)</param>
		/// <param name="endDate">Returns fundamentals on or before the given date (optional)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseFilingFundamentals)</returns>
		Task<ApiResponse<ApiResponseFilingFundamentals>> GetFilingFundamentalsAsyncWithHttpInfo(string identifier,
			string statementCode = null, string type = null, int? fiscalYear = null, string fiscalPeriod = null,
			DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

		/// <summary>
		///     Filing Html
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <returns>Task of string</returns>
		Task<string> GetFilingHtmlAsync(string identifier);

		/// <summary>
		///     Filing Html
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <returns>Task of ApiResponse (string)</returns>
		Task<ApiResponse<string>> GetFilingHtmlAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Filing Text
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <returns>Task of string</returns>
		Task<string> GetFilingTextAsync(string identifier);

		/// <summary>
		///     Filing Text
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Filing identifier</param>
		/// <returns>Task of ApiResponse (string)</returns>
		Task<ApiResponse<string>> GetFilingTextAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Filing Note by ID
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
		/// <returns>Task of FilingNote</returns>
		Task<FilingNote> GetNoteAsync(string identifier, string contentFormat = null);

		/// <summary>
		///     Filing Note by ID
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
		/// <returns>Task of ApiResponse (FilingNote)</returns>
		Task<ApiResponse<FilingNote>> GetNoteAsyncWithHttpInfo(string identifier, string contentFormat = null);

		/// <summary>
		///     Filing Note HTML
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <returns>Task of string</returns>
		Task<string> GetNoteHtmlAsync(string identifier);

		/// <summary>
		///     Filing Note HTML
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <returns>Task of ApiResponse (string)</returns>
		Task<ApiResponse<string>> GetNoteHtmlAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Filing Note Text
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <returns>Task of string</returns>
		Task<string> GetNoteTextAsync(string identifier);

		/// <summary>
		///     Filing Note Text
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID of the filing note</param>
		/// <returns>Task of ApiResponse (string)</returns>
		Task<ApiResponse<string>> GetNoteTextAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Search Filing Notes
		/// </summary>
		/// <remarks>
		///     Searches for Filing Notes using the &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search for notes that contain all or parts of this text</param>
		/// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
		/// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseFilingNotesSearch</returns>
		Task<ApiResponseFilingNotesSearch> SearchNotesAsync(string query, DateTime? filingStartDate = null,
			DateTime? filingEndDate = null, int? pageSize = null);

		/// <summary>
		///     Search Filing Notes
		/// </summary>
		/// <remarks>
		///     Searches for Filing Notes using the &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search for notes that contain all or parts of this text</param>
		/// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
		/// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseFilingNotesSearch)</returns>
		Task<ApiResponse<ApiResponseFilingNotesSearch>> SearchNotesAsyncWithHttpInfo(string query,
			DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null);

		#endregion Asynchronous Operations
	}
}