// <copyright file="RanksHistory.cs" company="APIMatic">
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
    /// RanksHistory.
    /// </summary>
    public class RanksHistory
    {
        private string ranksLastWeek;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ranks_last_week", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RanksHistory"/> class.
        /// </summary>
        public RanksHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RanksHistory"/> class.
        /// </summary>
        /// <param name="primaryIsbn10">primary_isbn10.</param>
        /// <param name="primaryIsbn13">primary_isbn13.</param>
        /// <param name="rank">rank.</param>
        /// <param name="listName">list_name.</param>
        /// <param name="displayName">display_name.</param>
        /// <param name="publishedDate">published_date.</param>
        /// <param name="bestsellersDate">bestsellers_date.</param>
        /// <param name="weeksOnList">weeks_on_list.</param>
        /// <param name="ranksLastWeek">ranks_last_week.</param>
        /// <param name="asterisk">asterisk.</param>
        /// <param name="dagger">dagger.</param>
        public RanksHistory(
            string primaryIsbn10 = null,
            string primaryIsbn13 = null,
            int? rank = null,
            string listName = null,
            string displayName = null,
            string publishedDate = null,
            string bestsellersDate = null,
            int? weeksOnList = null,
            string ranksLastWeek = null,
            int? asterisk = null,
            int? dagger = null)
        {
            this.PrimaryIsbn10 = primaryIsbn10;
            this.PrimaryIsbn13 = primaryIsbn13;
            this.Rank = rank;
            this.ListName = listName;
            this.DisplayName = displayName;
            this.PublishedDate = publishedDate;
            this.BestsellersDate = bestsellersDate;
            this.WeeksOnList = weeksOnList;
            if (ranksLastWeek != null)
            {
                this.RanksLastWeek = ranksLastWeek;
            }

            this.Asterisk = asterisk;
            this.Dagger = dagger;
        }

        /// <summary>
        /// Gets or sets PrimaryIsbn10.
        /// </summary>
        [JsonProperty("primary_isbn10", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryIsbn10 { get; set; }

        /// <summary>
        /// Gets or sets PrimaryIsbn13.
        /// </summary>
        [JsonProperty("primary_isbn13", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryIsbn13 { get; set; }

        /// <summary>
        /// Gets or sets Rank.
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

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
        /// Gets or sets PublishedDate.
        /// </summary>
        [JsonProperty("published_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets BestsellersDate.
        /// </summary>
        [JsonProperty("bestsellers_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BestsellersDate { get; set; }

        /// <summary>
        /// Gets or sets WeeksOnList.
        /// </summary>
        [JsonProperty("weeks_on_list", NullValueHandling = NullValueHandling.Ignore)]
        public int? WeeksOnList { get; set; }

        /// <summary>
        /// Gets or sets RanksLastWeek.
        /// </summary>
        [JsonProperty("ranks_last_week")]
        public string RanksLastWeek
        {
            get
            {
                return this.ranksLastWeek;
            }

            set
            {
                this.shouldSerialize["ranks_last_week"] = true;
                this.ranksLastWeek = value;
            }
        }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RanksHistory : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRanksLastWeek()
        {
            this.shouldSerialize["ranks_last_week"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRanksLastWeek()
        {
            return this.shouldSerialize["ranks_last_week"];
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

            return obj is RanksHistory other &&
                ((this.PrimaryIsbn10 == null && other.PrimaryIsbn10 == null) || (this.PrimaryIsbn10?.Equals(other.PrimaryIsbn10) == true)) &&
                ((this.PrimaryIsbn13 == null && other.PrimaryIsbn13 == null) || (this.PrimaryIsbn13?.Equals(other.PrimaryIsbn13) == true)) &&
                ((this.Rank == null && other.Rank == null) || (this.Rank?.Equals(other.Rank) == true)) &&
                ((this.ListName == null && other.ListName == null) || (this.ListName?.Equals(other.ListName) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.PublishedDate == null && other.PublishedDate == null) || (this.PublishedDate?.Equals(other.PublishedDate) == true)) &&
                ((this.BestsellersDate == null && other.BestsellersDate == null) || (this.BestsellersDate?.Equals(other.BestsellersDate) == true)) &&
                ((this.WeeksOnList == null && other.WeeksOnList == null) || (this.WeeksOnList?.Equals(other.WeeksOnList) == true)) &&
                ((this.RanksLastWeek == null && other.RanksLastWeek == null) || (this.RanksLastWeek?.Equals(other.RanksLastWeek) == true)) &&
                ((this.Asterisk == null && other.Asterisk == null) || (this.Asterisk?.Equals(other.Asterisk) == true)) &&
                ((this.Dagger == null && other.Dagger == null) || (this.Dagger?.Equals(other.Dagger) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrimaryIsbn10 = {(this.PrimaryIsbn10 == null ? "null" : this.PrimaryIsbn10 == string.Empty ? "" : this.PrimaryIsbn10)}");
            toStringOutput.Add($"this.PrimaryIsbn13 = {(this.PrimaryIsbn13 == null ? "null" : this.PrimaryIsbn13 == string.Empty ? "" : this.PrimaryIsbn13)}");
            toStringOutput.Add($"this.Rank = {(this.Rank == null ? "null" : this.Rank.ToString())}");
            toStringOutput.Add($"this.ListName = {(this.ListName == null ? "null" : this.ListName == string.Empty ? "" : this.ListName)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName == string.Empty ? "" : this.DisplayName)}");
            toStringOutput.Add($"this.PublishedDate = {(this.PublishedDate == null ? "null" : this.PublishedDate == string.Empty ? "" : this.PublishedDate)}");
            toStringOutput.Add($"this.BestsellersDate = {(this.BestsellersDate == null ? "null" : this.BestsellersDate == string.Empty ? "" : this.BestsellersDate)}");
            toStringOutput.Add($"this.WeeksOnList = {(this.WeeksOnList == null ? "null" : this.WeeksOnList.ToString())}");
            toStringOutput.Add($"this.RanksLastWeek = {(this.RanksLastWeek == null ? "null" : this.RanksLastWeek == string.Empty ? "" : this.RanksLastWeek)}");
            toStringOutput.Add($"this.Asterisk = {(this.Asterisk == null ? "null" : this.Asterisk.ToString())}");
            toStringOutput.Add($"this.Dagger = {(this.Dagger == null ? "null" : this.Dagger.ToString())}");
        }
    }
}