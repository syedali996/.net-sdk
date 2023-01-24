// <copyright file="Results3.cs" company="APIMatic">
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
    /// Results3.
    /// </summary>
    public class Results3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Results3"/> class.
        /// </summary>
        public Results3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Results3"/> class.
        /// </summary>
        /// <param name="listName">list_name.</param>
        /// <param name="displayName">display_name.</param>
        /// <param name="listNameEncoded">list_name_encoded.</param>
        /// <param name="oldestPublishedDate">oldest_published_date.</param>
        /// <param name="newestPublishedDate">newest_published_date.</param>
        /// <param name="updated">updated.</param>
        public Results3(
            string listName = null,
            string displayName = null,
            string listNameEncoded = null,
            string oldestPublishedDate = null,
            string newestPublishedDate = null,
            Models.UpdatedEnum? updated = null)
        {
            this.ListName = listName;
            this.DisplayName = displayName;
            this.ListNameEncoded = listNameEncoded;
            this.OldestPublishedDate = oldestPublishedDate;
            this.NewestPublishedDate = newestPublishedDate;
            this.Updated = updated;
        }

        /// <summary>
        /// Gets or sets ListName.
        /// </summary>
        [JsonProperty("list_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ListName { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets ListNameEncoded.
        /// </summary>
        [JsonProperty("list_name_encoded", NullValueHandling = NullValueHandling.Ignore)]
        public string ListNameEncoded { get; set; }

        /// <summary>
        /// Gets or sets OldestPublishedDate.
        /// </summary>
        [JsonProperty("oldest_published_date", NullValueHandling = NullValueHandling.Ignore)]
        public string OldestPublishedDate { get; set; }

        /// <summary>
        /// Gets or sets NewestPublishedDate.
        /// </summary>
        [JsonProperty("newest_published_date", NullValueHandling = NullValueHandling.Ignore)]
        public string NewestPublishedDate { get; set; }

        /// <summary>
        /// Gets or sets Updated.
        /// </summary>
        [JsonProperty("updated", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.UpdatedEnum? Updated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Results3 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Results3 other &&
                ((this.ListName == null && other.ListName == null) || (this.ListName?.Equals(other.ListName) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.ListNameEncoded == null && other.ListNameEncoded == null) || (this.ListNameEncoded?.Equals(other.ListNameEncoded) == true)) &&
                ((this.OldestPublishedDate == null && other.OldestPublishedDate == null) || (this.OldestPublishedDate?.Equals(other.OldestPublishedDate) == true)) &&
                ((this.NewestPublishedDate == null && other.NewestPublishedDate == null) || (this.NewestPublishedDate?.Equals(other.NewestPublishedDate) == true)) &&
                ((this.Updated == null && other.Updated == null) || (this.Updated?.Equals(other.Updated) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ListName = {(this.ListName == null ? "null" : this.ListName == string.Empty ? "" : this.ListName)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName == string.Empty ? "" : this.DisplayName)}");
            toStringOutput.Add($"this.ListNameEncoded = {(this.ListNameEncoded == null ? "null" : this.ListNameEncoded == string.Empty ? "" : this.ListNameEncoded)}");
            toStringOutput.Add($"this.OldestPublishedDate = {(this.OldestPublishedDate == null ? "null" : this.OldestPublishedDate == string.Empty ? "" : this.OldestPublishedDate)}");
            toStringOutput.Add($"this.NewestPublishedDate = {(this.NewestPublishedDate == null ? "null" : this.NewestPublishedDate == string.Empty ? "" : this.NewestPublishedDate)}");
            toStringOutput.Add($"this.Updated = {(this.Updated == null ? "null" : this.Updated.ToString())}");
        }
    }
}