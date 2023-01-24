// <copyright file="Results.cs" company="APIMatic">
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
    /// Results.
    /// </summary>
    public class Results
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Results"/> class.
        /// </summary>
        public Results()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Results"/> class.
        /// </summary>
        /// <param name="bestsellersDate">bestsellers_date.</param>
        /// <param name="publishedDate">published_date.</param>
        /// <param name="lists">lists.</param>
        public Results(
            string bestsellersDate = null,
            string publishedDate = null,
            List<Models.List> lists = null)
        {
            this.BestsellersDate = bestsellersDate;
            this.PublishedDate = publishedDate;
            this.Lists = lists;
        }

        /// <summary>
        /// Gets or sets BestsellersDate.
        /// </summary>
        [JsonProperty("bestsellers_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BestsellersDate { get; set; }

        /// <summary>
        /// Gets or sets PublishedDate.
        /// </summary>
        [JsonProperty("published_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets Lists.
        /// </summary>
        [JsonProperty("lists", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.List> Lists { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Results : ({string.Join(", ", toStringOutput)})";
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

            return obj is Results other &&
                ((this.BestsellersDate == null && other.BestsellersDate == null) || (this.BestsellersDate?.Equals(other.BestsellersDate) == true)) &&
                ((this.PublishedDate == null && other.PublishedDate == null) || (this.PublishedDate?.Equals(other.PublishedDate) == true)) &&
                ((this.Lists == null && other.Lists == null) || (this.Lists?.Equals(other.Lists) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BestsellersDate = {(this.BestsellersDate == null ? "null" : this.BestsellersDate == string.Empty ? "" : this.BestsellersDate)}");
            toStringOutput.Add($"this.PublishedDate = {(this.PublishedDate == null ? "null" : this.PublishedDate == string.Empty ? "" : this.PublishedDate)}");
            toStringOutput.Add($"this.Lists = {(this.Lists == null ? "null" : $"[{string.Join(", ", this.Lists)} ]")}");
        }
    }
}