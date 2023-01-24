// <copyright file="Results5.cs" company="APIMatic">
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
    /// Results5.
    /// </summary>
    public class Results5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Results5"/> class.
        /// </summary>
        public Results5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Results5"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="publicationDt">publication_dt.</param>
        /// <param name="byline">byline.</param>
        /// <param name="bookTitle">book_title.</param>
        /// <param name="bookAuthor">book_author.</param>
        /// <param name="summary">summary.</param>
        /// <param name="isbn13">isbn13.</param>
        public Results5(
            string url = null,
            string publicationDt = null,
            string byline = null,
            string bookTitle = null,
            string bookAuthor = null,
            string summary = null,
            List<string> isbn13 = null)
        {
            this.Url = url;
            this.PublicationDt = publicationDt;
            this.Byline = byline;
            this.BookTitle = bookTitle;
            this.BookAuthor = bookAuthor;
            this.Summary = summary;
            this.Isbn13 = isbn13;
        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets PublicationDt.
        /// </summary>
        [JsonProperty("publication_dt", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationDt { get; set; }

        /// <summary>
        /// Gets or sets Byline.
        /// </summary>
        [JsonProperty("byline", NullValueHandling = NullValueHandling.Ignore)]
        public string Byline { get; set; }

        /// <summary>
        /// Gets or sets BookTitle.
        /// </summary>
        [JsonProperty("book_title", NullValueHandling = NullValueHandling.Ignore)]
        public string BookTitle { get; set; }

        /// <summary>
        /// Gets or sets BookAuthor.
        /// </summary>
        [JsonProperty("book_author", NullValueHandling = NullValueHandling.Ignore)]
        public string BookAuthor { get; set; }

        /// <summary>
        /// Gets or sets Summary.
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets Isbn13.
        /// </summary>
        [JsonProperty("isbn13", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Isbn13 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Results5 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Results5 other &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.PublicationDt == null && other.PublicationDt == null) || (this.PublicationDt?.Equals(other.PublicationDt) == true)) &&
                ((this.Byline == null && other.Byline == null) || (this.Byline?.Equals(other.Byline) == true)) &&
                ((this.BookTitle == null && other.BookTitle == null) || (this.BookTitle?.Equals(other.BookTitle) == true)) &&
                ((this.BookAuthor == null && other.BookAuthor == null) || (this.BookAuthor?.Equals(other.BookAuthor) == true)) &&
                ((this.Summary == null && other.Summary == null) || (this.Summary?.Equals(other.Summary) == true)) &&
                ((this.Isbn13 == null && other.Isbn13 == null) || (this.Isbn13?.Equals(other.Isbn13) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.PublicationDt = {(this.PublicationDt == null ? "null" : this.PublicationDt == string.Empty ? "" : this.PublicationDt)}");
            toStringOutput.Add($"this.Byline = {(this.Byline == null ? "null" : this.Byline == string.Empty ? "" : this.Byline)}");
            toStringOutput.Add($"this.BookTitle = {(this.BookTitle == null ? "null" : this.BookTitle == string.Empty ? "" : this.BookTitle)}");
            toStringOutput.Add($"this.BookAuthor = {(this.BookAuthor == null ? "null" : this.BookAuthor == string.Empty ? "" : this.BookAuthor)}");
            toStringOutput.Add($"this.Summary = {(this.Summary == null ? "null" : this.Summary == string.Empty ? "" : this.Summary)}");
            toStringOutput.Add($"this.Isbn13 = {(this.Isbn13 == null ? "null" : $"[{string.Join(", ", this.Isbn13)} ]")}");
        }
    }
}