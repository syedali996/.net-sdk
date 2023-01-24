// <copyright file="Results4.cs" company="APIMatic">
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
    /// Results4.
    /// </summary>
    public class Results4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Results4"/> class.
        /// </summary>
        public Results4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Results4"/> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="contributor">contributor.</param>
        /// <param name="author">author.</param>
        /// <param name="contributorNote">contributor_note.</param>
        /// <param name="price">price.</param>
        /// <param name="ageGroup">age_group.</param>
        /// <param name="publisher">publisher.</param>
        /// <param name="isbns">isbns.</param>
        /// <param name="ranksHistory">ranks_history.</param>
        /// <param name="reviews">reviews.</param>
        public Results4(
            string title = null,
            string description = null,
            string contributor = null,
            string author = null,
            string contributorNote = null,
            int? price = null,
            string ageGroup = null,
            string publisher = null,
            List<Models.Isbn> isbns = null,
            List<Models.RanksHistory> ranksHistory = null,
            List<Models.Review> reviews = null)
        {
            this.Title = title;
            this.Description = description;
            this.Contributor = contributor;
            this.Author = author;
            this.ContributorNote = contributorNote;
            this.Price = price;
            this.AgeGroup = ageGroup;
            this.Publisher = publisher;
            this.Isbns = isbns;
            this.RanksHistory = ranksHistory;
            this.Reviews = reviews;
        }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Contributor.
        /// </summary>
        [JsonProperty("contributor", NullValueHandling = NullValueHandling.Ignore)]
        public string Contributor { get; set; }

        /// <summary>
        /// Gets or sets Author.
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets ContributorNote.
        /// </summary>
        [JsonProperty("contributor_note", NullValueHandling = NullValueHandling.Ignore)]
        public string ContributorNote { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public int? Price { get; set; }

        /// <summary>
        /// Gets or sets AgeGroup.
        /// </summary>
        [JsonProperty("age_group", NullValueHandling = NullValueHandling.Ignore)]
        public string AgeGroup { get; set; }

        /// <summary>
        /// Gets or sets Publisher.
        /// </summary>
        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets Isbns.
        /// </summary>
        [JsonProperty("isbns", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Isbn> Isbns { get; set; }

        /// <summary>
        /// Gets or sets RanksHistory.
        /// </summary>
        [JsonProperty("ranks_history", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RanksHistory> RanksHistory { get; set; }

        /// <summary>
        /// Gets or sets Reviews.
        /// </summary>
        [JsonProperty("reviews", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Review> Reviews { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Results4 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Results4 other &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Contributor == null && other.Contributor == null) || (this.Contributor?.Equals(other.Contributor) == true)) &&
                ((this.Author == null && other.Author == null) || (this.Author?.Equals(other.Author) == true)) &&
                ((this.ContributorNote == null && other.ContributorNote == null) || (this.ContributorNote?.Equals(other.ContributorNote) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.AgeGroup == null && other.AgeGroup == null) || (this.AgeGroup?.Equals(other.AgeGroup) == true)) &&
                ((this.Publisher == null && other.Publisher == null) || (this.Publisher?.Equals(other.Publisher) == true)) &&
                ((this.Isbns == null && other.Isbns == null) || (this.Isbns?.Equals(other.Isbns) == true)) &&
                ((this.RanksHistory == null && other.RanksHistory == null) || (this.RanksHistory?.Equals(other.RanksHistory) == true)) &&
                ((this.Reviews == null && other.Reviews == null) || (this.Reviews?.Equals(other.Reviews) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Contributor = {(this.Contributor == null ? "null" : this.Contributor == string.Empty ? "" : this.Contributor)}");
            toStringOutput.Add($"this.Author = {(this.Author == null ? "null" : this.Author == string.Empty ? "" : this.Author)}");
            toStringOutput.Add($"this.ContributorNote = {(this.ContributorNote == null ? "null" : this.ContributorNote == string.Empty ? "" : this.ContributorNote)}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.AgeGroup = {(this.AgeGroup == null ? "null" : this.AgeGroup == string.Empty ? "" : this.AgeGroup)}");
            toStringOutput.Add($"this.Publisher = {(this.Publisher == null ? "null" : this.Publisher == string.Empty ? "" : this.Publisher)}");
            toStringOutput.Add($"this.Isbns = {(this.Isbns == null ? "null" : $"[{string.Join(", ", this.Isbns)} ]")}");
            toStringOutput.Add($"this.RanksHistory = {(this.RanksHistory == null ? "null" : $"[{string.Join(", ", this.RanksHistory)} ]")}");
            toStringOutput.Add($"this.Reviews = {(this.Reviews == null ? "null" : $"[{string.Join(", ", this.Reviews)} ]")}");
        }
    }
}