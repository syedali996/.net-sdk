// <copyright file="Results1.cs" company="APIMatic">
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
    /// Results1.
    /// </summary>
    public class Results1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Results1"/> class.
        /// </summary>
        public Results1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Results1"/> class.
        /// </summary>
        /// <param name="listName">list_name.</param>
        /// <param name="displayName">display_name.</param>
        /// <param name="bestsellersDate">bestsellers_date.</param>
        /// <param name="publishedDate">published_date.</param>
        /// <param name="rank">rank.</param>
        /// <param name="rankLastWeek">rank_last_week.</param>
        /// <param name="weeksOnList">weeks_on_list.</param>
        /// <param name="asterisk">asterisk.</param>
        /// <param name="dagger">dagger.</param>
        /// <param name="amazonProductUrl">amazon_product_url.</param>
        /// <param name="isbns">isbns.</param>
        /// <param name="bookDetails">book_details.</param>
        /// <param name="reviews">reviews.</param>
        public Results1(
            string listName = null,
            string displayName = null,
            string bestsellersDate = null,
            string publishedDate = null,
            int? rank = null,
            int? rankLastWeek = null,
            int? weeksOnList = null,
            int? asterisk = null,
            int? dagger = null,
            string amazonProductUrl = null,
            List<Models.Isbn> isbns = null,
            List<Models.BookDetail> bookDetails = null,
            List<Models.Review> reviews = null)
        {
            this.ListName = listName;
            this.DisplayName = displayName;
            this.BestsellersDate = bestsellersDate;
            this.PublishedDate = publishedDate;
            this.Rank = rank;
            this.RankLastWeek = rankLastWeek;
            this.WeeksOnList = weeksOnList;
            this.Asterisk = asterisk;
            this.Dagger = dagger;
            this.AmazonProductUrl = amazonProductUrl;
            this.Isbns = isbns;
            this.BookDetails = bookDetails;
            this.Reviews = reviews;
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
        /// Gets or sets Rank.
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// Gets or sets RankLastWeek.
        /// </summary>
        [JsonProperty("rank_last_week", NullValueHandling = NullValueHandling.Ignore)]
        public int? RankLastWeek { get; set; }

        /// <summary>
        /// Gets or sets WeeksOnList.
        /// </summary>
        [JsonProperty("weeks_on_list", NullValueHandling = NullValueHandling.Ignore)]
        public int? WeeksOnList { get; set; }

        /// <summary>
        /// Gets or sets Asterisk.
        /// </summary>
        [JsonProperty("asterisk", NullValueHandling = NullValueHandling.Ignore)]
        public int? Asterisk { get; set; }

        /// <summary>
        /// Gets or sets Dagger.
        /// </summary>
        [JsonProperty("dagger", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dagger { get; set; }

        /// <summary>
        /// Gets or sets AmazonProductUrl.
        /// </summary>
        [JsonProperty("amazon_product_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AmazonProductUrl { get; set; }

        /// <summary>
        /// Gets or sets Isbns.
        /// </summary>
        [JsonProperty("isbns", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Isbn> Isbns { get; set; }

        /// <summary>
        /// Gets or sets BookDetails.
        /// </summary>
        [JsonProperty("book_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BookDetail> BookDetails { get; set; }

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

            return $"Results1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Results1 other &&
                ((this.ListName == null && other.ListName == null) || (this.ListName?.Equals(other.ListName) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.BestsellersDate == null && other.BestsellersDate == null) || (this.BestsellersDate?.Equals(other.BestsellersDate) == true)) &&
                ((this.PublishedDate == null && other.PublishedDate == null) || (this.PublishedDate?.Equals(other.PublishedDate) == true)) &&
                ((this.Rank == null && other.Rank == null) || (this.Rank?.Equals(other.Rank) == true)) &&
                ((this.RankLastWeek == null && other.RankLastWeek == null) || (this.RankLastWeek?.Equals(other.RankLastWeek) == true)) &&
                ((this.WeeksOnList == null && other.WeeksOnList == null) || (this.WeeksOnList?.Equals(other.WeeksOnList) == true)) &&
                ((this.Asterisk == null && other.Asterisk == null) || (this.Asterisk?.Equals(other.Asterisk) == true)) &&
                ((this.Dagger == null && other.Dagger == null) || (this.Dagger?.Equals(other.Dagger) == true)) &&
                ((this.AmazonProductUrl == null && other.AmazonProductUrl == null) || (this.AmazonProductUrl?.Equals(other.AmazonProductUrl) == true)) &&
                ((this.Isbns == null && other.Isbns == null) || (this.Isbns?.Equals(other.Isbns) == true)) &&
                ((this.BookDetails == null && other.BookDetails == null) || (this.BookDetails?.Equals(other.BookDetails) == true)) &&
                ((this.Reviews == null && other.Reviews == null) || (this.Reviews?.Equals(other.Reviews) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ListName = {(this.ListName == null ? "null" : this.ListName == string.Empty ? "" : this.ListName)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName == string.Empty ? "" : this.DisplayName)}");
            toStringOutput.Add($"this.BestsellersDate = {(this.BestsellersDate == null ? "null" : this.BestsellersDate == string.Empty ? "" : this.BestsellersDate)}");
            toStringOutput.Add($"this.PublishedDate = {(this.PublishedDate == null ? "null" : this.PublishedDate == string.Empty ? "" : this.PublishedDate)}");
            toStringOutput.Add($"this.Rank = {(this.Rank == null ? "null" : this.Rank.ToString())}");
            toStringOutput.Add($"this.RankLastWeek = {(this.RankLastWeek == null ? "null" : this.RankLastWeek.ToString())}");
            toStringOutput.Add($"this.WeeksOnList = {(this.WeeksOnList == null ? "null" : this.WeeksOnList.ToString())}");
            toStringOutput.Add($"this.Asterisk = {(this.Asterisk == null ? "null" : this.Asterisk.ToString())}");
            toStringOutput.Add($"this.Dagger = {(this.Dagger == null ? "null" : this.Dagger.ToString())}");
            toStringOutput.Add($"this.AmazonProductUrl = {(this.AmazonProductUrl == null ? "null" : this.AmazonProductUrl == string.Empty ? "" : this.AmazonProductUrl)}");
            toStringOutput.Add($"this.Isbns = {(this.Isbns == null ? "null" : $"[{string.Join(", ", this.Isbns)} ]")}");
            toStringOutput.Add($"this.BookDetails = {(this.BookDetails == null ? "null" : $"[{string.Join(", ", this.BookDetails)} ]")}");
            toStringOutput.Add($"this.Reviews = {(this.Reviews == null ? "null" : $"[{string.Join(", ", this.Reviews)} ]")}");
        }
    }
}