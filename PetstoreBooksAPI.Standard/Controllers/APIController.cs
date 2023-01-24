// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PetstoreBooksAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using PetstoreBooksAPI.Standard;
    using PetstoreBooksAPI.Standard.Authentication;
    using PetstoreBooksAPI.Standard.Http.Client;
    using PetstoreBooksAPI.Standard.Http.Request;
    using PetstoreBooksAPI.Standard.Http.Request.Configuration;
    using PetstoreBooksAPI.Standard.Http.Response;
    using PetstoreBooksAPI.Standard.Utilities;

    /// <summary>
    /// APIController.
    /// </summary>
    public class APIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal APIController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Get Best Sellers list.  If no date is provided returns the latest list.
        /// </summary>
        /// <param name="list">Required parameter: The name of the Times best sellers list (hardcover-fiction, paperback-nonfiction, ...). The /lists/names service returns all the list names. The encoded list names are lower case with hyphens instead of spaces (e.g. e-book-fiction, instead of E-Book Fiction)..</param>
        /// <param name="bestsellersDate">Optional parameter: YYYY-MM-DD  The week-ending date for the sales reflected on list-name. Times best sellers lists are compiled using available book sale data. The bestsellers-date may be significantly earlier than published-date. For additional information, see the explanation at the bottom of any best-seller list page on NYTimes.com (example: Hardcover Fiction, published Dec. 5 but reflecting sales to Nov. 29)..</param>
        /// <param name="publishedDate">Optional parameter: YYYY-MM-DD  The date the best sellers list was published on NYTimes.com (different than bestsellers-date).  Use "current" for latest list..</param>
        /// <param name="offset">Optional parameter: Sets the starting point of the result set (0, 20, ...).  Used to paginate thru books if list has more than 20. Defaults to 0.  The num_results field indicates how many books are in the list..</param>
        /// <returns>Returns the Models.GETListsFormatResponse response from the API call.</returns>
        public Models.GETListsFormatResponse GETListsFormat(
                string list,
                string bestsellersDate = null,
                string publishedDate = null,
                int? offset = null)
        {
            Task<Models.GETListsFormatResponse> t = this.GETListsFormatAsync(list, bestsellersDate, publishedDate, offset);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Best Sellers list.  If no date is provided returns the latest list.
        /// </summary>
        /// <param name="list">Required parameter: The name of the Times best sellers list (hardcover-fiction, paperback-nonfiction, ...). The /lists/names service returns all the list names. The encoded list names are lower case with hyphens instead of spaces (e.g. e-book-fiction, instead of E-Book Fiction)..</param>
        /// <param name="bestsellersDate">Optional parameter: YYYY-MM-DD  The week-ending date for the sales reflected on list-name. Times best sellers lists are compiled using available book sale data. The bestsellers-date may be significantly earlier than published-date. For additional information, see the explanation at the bottom of any best-seller list page on NYTimes.com (example: Hardcover Fiction, published Dec. 5 but reflecting sales to Nov. 29)..</param>
        /// <param name="publishedDate">Optional parameter: YYYY-MM-DD  The date the best sellers list was published on NYTimes.com (different than bestsellers-date).  Use "current" for latest list..</param>
        /// <param name="offset">Optional parameter: Sets the starting point of the result set (0, 20, ...).  Used to paginate thru books if list has more than 20. Defaults to 0.  The num_results field indicates how many books are in the list..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GETListsFormatResponse response from the API call.</returns>
        public async Task<Models.GETListsFormatResponse> GETListsFormatAsync(
                string list,
                string bestsellersDate = null,
                string publishedDate = null,
                int? offset = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/lists.json");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "list", list },
                { "bestsellers-date", bestsellersDate },
                { "published-date", publishedDate },
                { "offset", offset },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GETListsFormatResponse>(response.Body);
        }

        /// <summary>
        /// Get Best Sellers list by date.
        /// </summary>
        /// <param name="date">Required parameter: YYYY-MM-DD or "current"  The date the best sellers list was published on NYTimes.com.  Use "current" to get latest list..</param>
        /// <param name="list">Required parameter: Name of the Best Sellers List (e.g. hardcover-fiction). You can get the full list of names from the /lists/names.json service..</param>
        /// <param name="offset">Optional parameter: Sets the starting point of the result set (0, 20, ...).  Used to paginate thru books if list has more than 20. Defaults to 0.  The num_results field indicates how many books are in the list..</param>
        /// <returns>Returns the Models.GETListsDateListJsonResponse response from the API call.</returns>
        public Models.GETListsDateListJsonResponse GETListsDateListJson(
                string date,
                string list,
                int? offset = null)
        {
            Task<Models.GETListsDateListJsonResponse> t = this.GETListsDateListJsonAsync(date, list, offset);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Best Sellers list by date.
        /// </summary>
        /// <param name="date">Required parameter: YYYY-MM-DD or "current"  The date the best sellers list was published on NYTimes.com.  Use "current" to get latest list..</param>
        /// <param name="list">Required parameter: Name of the Best Sellers List (e.g. hardcover-fiction). You can get the full list of names from the /lists/names.json service..</param>
        /// <param name="offset">Optional parameter: Sets the starting point of the result set (0, 20, ...).  Used to paginate thru books if list has more than 20. Defaults to 0.  The num_results field indicates how many books are in the list..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GETListsDateListJsonResponse response from the API call.</returns>
        public async Task<Models.GETListsDateListJsonResponse> GETListsDateListJsonAsync(
                string date,
                string list,
                int? offset = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/lists/{date}/{list}.json");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "date", date },
                { "list", list },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "offset", offset },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GETListsDateListJsonResponse>(response.Body);
        }

        /// <summary>
        /// Get all books for all the Best Sellers lists for specified date.
        /// </summary>
        /// <param name="publishedDate">Optional parameter: YYYY-MM-DD  The best-seller list publication date. You do not have to specify the exact date the list was published. The service will search forward (into the future) for the closest publication date to the date you specify. For example, a request for lists/overview/2013-05-22 will retrieve the list that was published on 05-26.  If you do not include a published date, the current week's best sellers lists will be returned..</param>
        /// <returns>Returns the Models.OverviewResponse response from the API call.</returns>
        public Models.OverviewResponse GETListsFullOverviewFormat(
                string publishedDate = null)
        {
            Task<Models.OverviewResponse> t = this.GETListsFullOverviewFormatAsync(publishedDate);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get all books for all the Best Sellers lists for specified date.
        /// </summary>
        /// <param name="publishedDate">Optional parameter: YYYY-MM-DD  The best-seller list publication date. You do not have to specify the exact date the list was published. The service will search forward (into the future) for the closest publication date to the date you specify. For example, a request for lists/overview/2013-05-22 will retrieve the list that was published on 05-26.  If you do not include a published date, the current week's best sellers lists will be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OverviewResponse response from the API call.</returns>
        public async Task<Models.OverviewResponse> GETListsFullOverviewFormatAsync(
                string publishedDate = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/lists/full-overview.json");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "published_date", publishedDate },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.OverviewResponse>(response.Body);
        }

        /// <summary>
        /// Get top 5 books for all the Best Sellers lists for specified date.
        /// </summary>
        /// <param name="publishedDate">Optional parameter: YYYY-MM-DD  The best-seller list publication date. You do not have to specify the exact date the list was published. The service will search forward (into the future) for the closest publication date to the date you specify. For example, a request for lists/overview/2013-05-22 will retrieve the list that was published on 05-26.  If you do not include a published date, the current week's best sellers lists will be returned..</param>
        /// <returns>Returns the Models.OverviewResponse response from the API call.</returns>
        public Models.OverviewResponse GETListsOverviewFormat(
                string publishedDate = null)
        {
            Task<Models.OverviewResponse> t = this.GETListsOverviewFormatAsync(publishedDate);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get top 5 books for all the Best Sellers lists for specified date.
        /// </summary>
        /// <param name="publishedDate">Optional parameter: YYYY-MM-DD  The best-seller list publication date. You do not have to specify the exact date the list was published. The service will search forward (into the future) for the closest publication date to the date you specify. For example, a request for lists/overview/2013-05-22 will retrieve the list that was published on 05-26.  If you do not include a published date, the current week's best sellers lists will be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OverviewResponse response from the API call.</returns>
        public async Task<Models.OverviewResponse> GETListsOverviewFormatAsync(
                string publishedDate = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/lists/overview.json");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "published_date", publishedDate },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.OverviewResponse>(response.Body);
        }

        /// <summary>
        /// Get Best Sellers list names.
        /// </summary>
        /// <returns>Returns the Models.GETListsNamesFormatResponse response from the API call.</returns>
        public Models.GETListsNamesFormatResponse GETListsNamesFormat()
        {
            Task<Models.GETListsNamesFormatResponse> t = this.GETListsNamesFormatAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Best Sellers list names.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GETListsNamesFormatResponse response from the API call.</returns>
        public async Task<Models.GETListsNamesFormatResponse> GETListsNamesFormatAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/lists/names.json");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GETListsNamesFormatResponse>(response.Body);
        }

        /// <summary>
        /// Get Best Sellers list history.
        /// </summary>
        /// <param name="ageGroup">Optional parameter: The target age group for the best seller..</param>
        /// <param name="author">Optional parameter: The author of the best seller. The author field does not include additional contributors (see Data Structure for more details about the author and contributor fields).  When searching the author field, you can specify any combination of first, middle and last names.  When sort-by is set to author, the results will be sorted by author's first name..</param>
        /// <param name="contributor">Optional parameter: The author of the best seller, as well as other contributors such as the illustrator (to search or sort by author name only, use author instead).  When searching, you can specify any combination of first, middle and last names of any of the contributors.  When sort-by is set to contributor, the results will be sorted by the first name of the first contributor listed..</param>
        /// <param name="isbn">Optional parameter: International Standard Book Number, 10 or 13 digits  A best seller may have both 10-digit and 13-digit ISBNs, and may have multiple ISBNs of each type. To search on multiple ISBNs, separate the ISBNs with semicolons (example: 9780446579933;0061374229)..</param>
        /// <param name="offset">Optional parameter: Sets the starting point of the result set (0, 20, ...).  Used to paginate thru results if there are more than 20. Defaults to 0. The num_results field indicates how many results there are total..</param>
        /// <param name="price">Optional parameter: The publisher's list price of the best seller, including decimal point..</param>
        /// <param name="publisher">Optional parameter: The standardized name of the publisher.</param>
        /// <param name="title">Optional parameter: The title of the best seller  When searching, you can specify a portion of a title or a full title..</param>
        /// <returns>Returns the Models.GETListsBestSellersHistoryJsonResponse response from the API call.</returns>
        public Models.GETListsBestSellersHistoryJsonResponse GETListsBestSellersHistoryJson(
                string ageGroup = null,
                string author = null,
                string contributor = null,
                string isbn = null,
                int? offset = null,
                string price = null,
                string publisher = null,
                string title = null)
        {
            Task<Models.GETListsBestSellersHistoryJsonResponse> t = this.GETListsBestSellersHistoryJsonAsync(ageGroup, author, contributor, isbn, offset, price, publisher, title);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Best Sellers list history.
        /// </summary>
        /// <param name="ageGroup">Optional parameter: The target age group for the best seller..</param>
        /// <param name="author">Optional parameter: The author of the best seller. The author field does not include additional contributors (see Data Structure for more details about the author and contributor fields).  When searching the author field, you can specify any combination of first, middle and last names.  When sort-by is set to author, the results will be sorted by author's first name..</param>
        /// <param name="contributor">Optional parameter: The author of the best seller, as well as other contributors such as the illustrator (to search or sort by author name only, use author instead).  When searching, you can specify any combination of first, middle and last names of any of the contributors.  When sort-by is set to contributor, the results will be sorted by the first name of the first contributor listed..</param>
        /// <param name="isbn">Optional parameter: International Standard Book Number, 10 or 13 digits  A best seller may have both 10-digit and 13-digit ISBNs, and may have multiple ISBNs of each type. To search on multiple ISBNs, separate the ISBNs with semicolons (example: 9780446579933;0061374229)..</param>
        /// <param name="offset">Optional parameter: Sets the starting point of the result set (0, 20, ...).  Used to paginate thru results if there are more than 20. Defaults to 0. The num_results field indicates how many results there are total..</param>
        /// <param name="price">Optional parameter: The publisher's list price of the best seller, including decimal point..</param>
        /// <param name="publisher">Optional parameter: The standardized name of the publisher.</param>
        /// <param name="title">Optional parameter: The title of the best seller  When searching, you can specify a portion of a title or a full title..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GETListsBestSellersHistoryJsonResponse response from the API call.</returns>
        public async Task<Models.GETListsBestSellersHistoryJsonResponse> GETListsBestSellersHistoryJsonAsync(
                string ageGroup = null,
                string author = null,
                string contributor = null,
                string isbn = null,
                int? offset = null,
                string price = null,
                string publisher = null,
                string title = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/lists/best-sellers/history.json");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "age-group", ageGroup },
                { "author", author },
                { "contributor", contributor },
                { "isbn", isbn },
                { "offset", offset },
                { "price", price },
                { "publisher", publisher },
                { "title", title },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GETListsBestSellersHistoryJsonResponse>(response.Body);
        }

        /// <summary>
        /// Get book reviews.
        /// </summary>
        /// <param name="isbn">Optional parameter: Searching by ISBN is the recommended method. You can enter 10- or 13-digit ISBNs..</param>
        /// <param name="title">Optional parameter: You’ll need to enter the full title of the book. Spaces in the title will be converted into the characters %20..</param>
        /// <param name="author">Optional parameter: You’ll need to enter the author’s first and last name, separated by a space. This space will be converted into the characters %20..</param>
        /// <returns>Returns the Models.GETReviewsFormatResponse response from the API call.</returns>
        public Models.GETReviewsFormatResponse GETReviewsFormat(
                int? isbn = null,
                string title = null,
                string author = null)
        {
            Task<Models.GETReviewsFormatResponse> t = this.GETReviewsFormatAsync(isbn, title, author);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get book reviews.
        /// </summary>
        /// <param name="isbn">Optional parameter: Searching by ISBN is the recommended method. You can enter 10- or 13-digit ISBNs..</param>
        /// <param name="title">Optional parameter: You’ll need to enter the full title of the book. Spaces in the title will be converted into the characters %20..</param>
        /// <param name="author">Optional parameter: You’ll need to enter the author’s first and last name, separated by a space. This space will be converted into the characters %20..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GETReviewsFormatResponse response from the API call.</returns>
        public async Task<Models.GETReviewsFormatResponse> GETReviewsFormatAsync(
                int? isbn = null,
                string title = null,
                string author = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/reviews.json");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "isbn", isbn },
                { "title", title },
                { "author", author },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GETReviewsFormatResponse>(response.Body);
        }
    }
}