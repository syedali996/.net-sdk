// <copyright file="GETListsBestSellersHistoryJsonResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PetstoreBooksAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PetstoreBooksAPI.Standard;
    using PetstoreBooksAPI.Standard.Utilities;

    /// <summary>
    /// GETListsBestSellersHistoryJsonResponse.
    /// </summary>
    public class GETListsBestSellersHistoryJsonResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GETListsBestSellersHistoryJsonResponse"/> class.
        /// </summary>
        public GETListsBestSellersHistoryJsonResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GETListsBestSellersHistoryJsonResponse"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="copyright">copyright.</param>
        /// <param name="numResults">num_results.</param>
        /// <param name="results">results.</param>
        public GETListsBestSellersHistoryJsonResponse(
            string status = null,
            string copyright = null,
            int? numResults = null,
            List<Models.Results4> results = null)
        {
            this.Status = status;
            this.Copyright = copyright;
            this.NumResults = numResults;
            this.Results = results;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Copyright.
        /// </summary>
        [JsonProperty("copyright", NullValueHandling = NullValueHandling.Ignore)]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets NumResults.
        /// </summary>
        [JsonProperty("num_results", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumResults { get; set; }

        /// <summary>
        /// Gets or sets Results.
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Results4> Results { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GETListsBestSellersHistoryJsonResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GETListsBestSellersHistoryJsonResponse other &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Copyright == null && other.Copyright == null) || (this.Copyright?.Equals(other.Copyright) == true)) &&
                ((this.NumResults == null && other.NumResults == null) || (this.NumResults?.Equals(other.NumResults) == true)) &&
                ((this.Results == null && other.Results == null) || (this.Results?.Equals(other.Results) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Copyright = {(this.Copyright == null ? "null" : this.Copyright == string.Empty ? "" : this.Copyright)}");
            toStringOutput.Add($"this.NumResults = {(this.NumResults == null ? "null" : this.NumResults.ToString())}");
            toStringOutput.Add($"this.Results = {(this.Results == null ? "null" : $"[{string.Join(", ", this.Results)} ]")}");
        }
    }
}