// <copyright file="Results2.cs" company="APIMatic">
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
    /// Results2.
    /// </summary>
    public class Results2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Results2"/> class.
        /// </summary>
        public Results2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Results2"/> class.
        /// </summary>
        /// <param name="listName">list_name.</param>
        /// <param name="bestsellersDate">bestsellers_date.</param>
        /// <param name="publishedDate">published_date.</param>
        /// <param name="displayName">display_name.</param>
        /// <param name="normalListEndsAt">normal_list_ends_at.</param>
        /// <param name="updated">updated.</param>
        /// <param name="books">books.</param>
        /// <param name="corrections">corrections.</param>
        public Results2(
            string listName = null,
            string bestsellersDate = null,
            string publishedDate = null,
            string displayName = null,
            int? normalListEndsAt = null,
            string updated = null,
            List<Models.Book1> books = null,
            object corrections = null)
        {
            this.ListName = listName;
            this.BestsellersDate = bestsellersDate;
            this.PublishedDate = publishedDate;
            this.DisplayName = displayName;
            this.NormalListEndsAt = normalListEndsAt;
            this.Updated = updated;
            this.Books = books;
            this.Corrections = corrections;
        }

        /// <summary>
        /// Gets or sets ListName.
        /// </summary>
        [JsonProperty("list_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ListName { get; set; }

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
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets NormalListEndsAt.
        /// </summary>
        [JsonProperty("normal_list_ends_at", NullValueHandling = NullValueHandling.Ignore)]
        public int? NormalListEndsAt { get; set; }

        /// <summary>
        /// Gets or sets Updated.
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// Gets or sets Books.
        /// </summary>
        [JsonProperty("books", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Book1> Books { get; set; }

        /// <summary>
        /// Gets or sets Corrections.
        /// </summary>
        [JsonProperty("corrections", NullValueHandling = NullValueHandling.Ignore)]
        public object Corrections { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Results2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Results2 other &&
                ((this.ListName == null && other.ListName == null) || (this.ListName?.Equals(other.ListName) == true)) &&
                ((this.BestsellersDate == null && other.BestsellersDate == null) || (this.BestsellersDate?.Equals(other.BestsellersDate) == true)) &&
                ((this.PublishedDate == null && other.PublishedDate == null) || (this.PublishedDate?.Equals(other.PublishedDate) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.NormalListEndsAt == null && other.NormalListEndsAt == null) || (this.NormalListEndsAt?.Equals(other.NormalListEndsAt) == true)) &&
                ((this.Updated == null && other.Updated == null) || (this.Updated?.Equals(other.Updated) == true)) &&
                ((this.Books == null && other.Books == null) || (this.Books?.Equals(other.Books) == true)) &&
                ((this.Corrections == null && other.Corrections == null) || (this.Corrections?.Equals(other.Corrections) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ListName = {(this.ListName == null ? "null" : this.ListName == string.Empty ? "" : this.ListName)}");
            toStringOutput.Add($"this.BestsellersDate = {(this.BestsellersDate == null ? "null" : this.BestsellersDate == string.Empty ? "" : this.BestsellersDate)}");
            toStringOutput.Add($"this.PublishedDate = {(this.PublishedDate == null ? "null" : this.PublishedDate == string.Empty ? "" : this.PublishedDate)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName == string.Empty ? "" : this.DisplayName)}");
            toStringOutput.Add($"this.NormalListEndsAt = {(this.NormalListEndsAt == null ? "null" : this.NormalListEndsAt.ToString())}");
            toStringOutput.Add($"this.Updated = {(this.Updated == null ? "null" : this.Updated == string.Empty ? "" : this.Updated)}");
            toStringOutput.Add($"this.Books = {(this.Books == null ? "null" : $"[{string.Join(", ", this.Books)} ]")}");
            toStringOutput.Add($"Corrections = {(this.Corrections == null ? "null" : this.Corrections.ToString())}");
        }
    }
}