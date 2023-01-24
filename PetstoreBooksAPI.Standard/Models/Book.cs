// <copyright file="Book.cs" company="APIMatic">
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
    /// Book.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        public Book()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="ageGroup">age_group.</param>
        /// <param name="author">author.</param>
        /// <param name="contributor">contributor.</param>
        /// <param name="contributorNote">contributor_note.</param>
        /// <param name="createdDate">created_date.</param>
        /// <param name="description">description.</param>
        /// <param name="price">price.</param>
        /// <param name="primaryIsbn13">primary_isbn13.</param>
        /// <param name="primaryIsbn10">primary_isbn10.</param>
        /// <param name="publisher">publisher.</param>
        /// <param name="rank">rank.</param>
        /// <param name="title">title.</param>
        /// <param name="updatedDate">updated_date.</param>
        public Book(
            string ageGroup = null,
            string author = null,
            string contributor = null,
            string contributorNote = null,
            string createdDate = null,
            string description = null,
            int? price = null,
            string primaryIsbn13 = null,
            string primaryIsbn10 = null,
            string publisher = null,
            int? rank = null,
            string title = null,
            string updatedDate = null)
        {
            this.AgeGroup = ageGroup;
            this.Author = author;
            this.Contributor = contributor;
            this.ContributorNote = contributorNote;
            this.CreatedDate = createdDate;
            this.Description = description;
            this.Price = price;
            this.PrimaryIsbn13 = primaryIsbn13;
            this.PrimaryIsbn10 = primaryIsbn10;
            this.Publisher = publisher;
            this.Rank = rank;
            this.Title = title;
            this.UpdatedDate = updatedDate;
        }

        /// <summary>
        /// Gets or sets AgeGroup.
        /// </summary>
        [JsonProperty("age_group", NullValueHandling = NullValueHandling.Ignore)]
        public string AgeGroup { get; set; }

        /// <summary>
        /// Gets or sets Author.
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets Contributor.
        /// </summary>
        [JsonProperty("contributor", NullValueHandling = NullValueHandling.Ignore)]
        public string Contributor { get; set; }

        /// <summary>
        /// Gets or sets ContributorNote.
        /// </summary>
        [JsonProperty("contributor_note", NullValueHandling = NullValueHandling.Ignore)]
        public string ContributorNote { get; set; }

        /// <summary>
        /// Gets or sets CreatedDate.
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public int? Price { get; set; }

        /// <summary>
        /// Gets or sets PrimaryIsbn13.
        /// </summary>
        [JsonProperty("primary_isbn13", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryIsbn13 { get; set; }

        /// <summary>
        /// Gets or sets PrimaryIsbn10.
        /// </summary>
        [JsonProperty("primary_isbn10", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryIsbn10 { get; set; }

        /// <summary>
        /// Gets or sets Publisher.
        /// </summary>
        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets Rank.
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets UpdatedDate.
        /// </summary>
        [JsonProperty("updated_date", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Book : ({string.Join(", ", toStringOutput)})";
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

            return obj is Book other &&
                ((this.AgeGroup == null && other.AgeGroup == null) || (this.AgeGroup?.Equals(other.AgeGroup) == true)) &&
                ((this.Author == null && other.Author == null) || (this.Author?.Equals(other.Author) == true)) &&
                ((this.Contributor == null && other.Contributor == null) || (this.Contributor?.Equals(other.Contributor) == true)) &&
                ((this.ContributorNote == null && other.ContributorNote == null) || (this.ContributorNote?.Equals(other.ContributorNote) == true)) &&
                ((this.CreatedDate == null && other.CreatedDate == null) || (this.CreatedDate?.Equals(other.CreatedDate) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.PrimaryIsbn13 == null && other.PrimaryIsbn13 == null) || (this.PrimaryIsbn13?.Equals(other.PrimaryIsbn13) == true)) &&
                ((this.PrimaryIsbn10 == null && other.PrimaryIsbn10 == null) || (this.PrimaryIsbn10?.Equals(other.PrimaryIsbn10) == true)) &&
                ((this.Publisher == null && other.Publisher == null) || (this.Publisher?.Equals(other.Publisher) == true)) &&
                ((this.Rank == null && other.Rank == null) || (this.Rank?.Equals(other.Rank) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.UpdatedDate == null && other.UpdatedDate == null) || (this.UpdatedDate?.Equals(other.UpdatedDate) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AgeGroup = {(this.AgeGroup == null ? "null" : this.AgeGroup == string.Empty ? "" : this.AgeGroup)}");
            toStringOutput.Add($"this.Author = {(this.Author == null ? "null" : this.Author == string.Empty ? "" : this.Author)}");
            toStringOutput.Add($"this.Contributor = {(this.Contributor == null ? "null" : this.Contributor == string.Empty ? "" : this.Contributor)}");
            toStringOutput.Add($"this.ContributorNote = {(this.ContributorNote == null ? "null" : this.ContributorNote == string.Empty ? "" : this.ContributorNote)}");
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate == string.Empty ? "" : this.CreatedDate)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.PrimaryIsbn13 = {(this.PrimaryIsbn13 == null ? "null" : this.PrimaryIsbn13 == string.Empty ? "" : this.PrimaryIsbn13)}");
            toStringOutput.Add($"this.PrimaryIsbn10 = {(this.PrimaryIsbn10 == null ? "null" : this.PrimaryIsbn10 == string.Empty ? "" : this.PrimaryIsbn10)}");
            toStringOutput.Add($"this.Publisher = {(this.Publisher == null ? "null" : this.Publisher == string.Empty ? "" : this.Publisher)}");
            toStringOutput.Add($"this.Rank = {(this.Rank == null ? "null" : this.Rank.ToString())}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.UpdatedDate = {(this.UpdatedDate == null ? "null" : this.UpdatedDate == string.Empty ? "" : this.UpdatedDate)}");
        }
    }
}