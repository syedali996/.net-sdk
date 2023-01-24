// <copyright file="List.cs" company="APIMatic">
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
    /// List.
    /// </summary>
    public class List
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="List"/> class.
        /// </summary>
        public List()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="List"/> class.
        /// </summary>
        /// <param name="listId">list_id.</param>
        /// <param name="listName">list_name.</param>
        /// <param name="displayName">display_name.</param>
        /// <param name="updated">updated.</param>
        /// <param name="listImage">list_image.</param>
        /// <param name="books">books.</param>
        public List(
            int? listId = null,
            string listName = null,
            string displayName = null,
            string updated = null,
            string listImage = null,
            List<Models.Book> books = null)
        {
            this.ListId = listId;
            this.ListName = listName;
            this.DisplayName = displayName;
            this.Updated = updated;
            this.ListImage = listImage;
            this.Books = books;
        }

        /// <summary>
        /// Gets or sets ListId.
        /// </summary>
        [JsonProperty("list_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ListId { get; set; }

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
        /// Gets or sets Updated.
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// Gets or sets ListImage.
        /// </summary>
        [JsonProperty("list_image", NullValueHandling = NullValueHandling.Ignore)]
        public string ListImage { get; set; }

        /// <summary>
        /// Gets or sets Books.
        /// </summary>
        [JsonProperty("books", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Book> Books { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"List : ({string.Join(", ", toStringOutput)})";
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

            return obj is List other &&
                ((this.ListId == null && other.ListId == null) || (this.ListId?.Equals(other.ListId) == true)) &&
                ((this.ListName == null && other.ListName == null) || (this.ListName?.Equals(other.ListName) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.Updated == null && other.Updated == null) || (this.Updated?.Equals(other.Updated) == true)) &&
                ((this.ListImage == null && other.ListImage == null) || (this.ListImage?.Equals(other.ListImage) == true)) &&
                ((this.Books == null && other.Books == null) || (this.Books?.Equals(other.Books) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ListId = {(this.ListId == null ? "null" : this.ListId.ToString())}");
            toStringOutput.Add($"this.ListName = {(this.ListName == null ? "null" : this.ListName == string.Empty ? "" : this.ListName)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName == string.Empty ? "" : this.DisplayName)}");
            toStringOutput.Add($"this.Updated = {(this.Updated == null ? "null" : this.Updated == string.Empty ? "" : this.Updated)}");
            toStringOutput.Add($"this.ListImage = {(this.ListImage == null ? "null" : this.ListImage == string.Empty ? "" : this.ListImage)}");
            toStringOutput.Add($"this.Books = {(this.Books == null ? "null" : $"[{string.Join(", ", this.Books)} ]")}");
        }
    }
}