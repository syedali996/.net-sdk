// <copyright file="Book1.cs" company="APIMatic">
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
    /// Book1.
    /// </summary>
    public class Book1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Book1"/> class.
        /// </summary>
        public Book1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book1"/> class.
        /// </summary>
        /// <param name="rank">rank.</param>
        /// <param name="rankLastWeek">rank_last_week.</param>
        /// <param name="weeksOnList">weeks_on_list.</param>
        /// <param name="asterisk">asterisk.</param>
        /// <param name="dagger">dagger.</param>
        /// <param name="primaryIsbn10">primary_isbn10.</param>
        /// <param name="primaryIsbn13">primary_isbn13.</param>
        /// <param name="publisher">publisher.</param>
        /// <param name="description">description.</param>
        /// <param name="price">price.</param>
        /// <param name="title">title.</param>
        /// <param name="author">author.</param>
        /// <param name="contributor">contributor.</param>
        /// <param name="contributorNote">contributor_note.</param>
        /// <param name="bookImage">book_image.</param>
        /// <param name="amazonProductUrl">amazon_product_url.</param>
        /// <param name="ageGroup">age_group.</param>
        /// <param name="bookReviewLink">book_review_link.</param>
        /// <param name="firstChapterLink">first_chapter_link.</param>
        /// <param name="sundayReviewLink">sunday_review_link.</param>
        /// <param name="articleChapterLink">article_chapter_link.</param>
        /// <param name="isbns">isbns.</param>
        public Book1(
            int? rank = null,
            int? rankLastWeek = null,
            int? weeksOnList = null,
            int? asterisk = null,
            int? dagger = null,
            string primaryIsbn10 = null,
            string primaryIsbn13 = null,
            string publisher = null,
            string description = null,
            int? price = null,
            string title = null,
            string author = null,
            string contributor = null,
            string contributorNote = null,
            string bookImage = null,
            string amazonProductUrl = null,
            string ageGroup = null,
            string bookReviewLink = null,
            string firstChapterLink = null,
            string sundayReviewLink = null,
            string articleChapterLink = null,
            List<Models.Isbn> isbns = null)
        {
            this.Rank = rank;
            this.RankLastWeek = rankLastWeek;
            this.WeeksOnList = weeksOnList;
            this.Asterisk = asterisk;
            this.Dagger = dagger;
            this.PrimaryIsbn10 = primaryIsbn10;
            this.PrimaryIsbn13 = primaryIsbn13;
            this.Publisher = publisher;
            this.Description = description;
            this.Price = price;
            this.Title = title;
            this.Author = author;
            this.Contributor = contributor;
            this.ContributorNote = contributorNote;
            this.BookImage = bookImage;
            this.AmazonProductUrl = amazonProductUrl;
            this.AgeGroup = ageGroup;
            this.BookReviewLink = bookReviewLink;
            this.FirstChapterLink = firstChapterLink;
            this.SundayReviewLink = sundayReviewLink;
            this.ArticleChapterLink = articleChapterLink;
            this.Isbns = isbns;
        }

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
        /// Gets or sets Publisher.
        /// </summary>
        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

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
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

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
        /// Gets or sets BookImage.
        /// </summary>
        [JsonProperty("book_image", NullValueHandling = NullValueHandling.Ignore)]
        public string BookImage { get; set; }

        /// <summary>
        /// Gets or sets AmazonProductUrl.
        /// </summary>
        [JsonProperty("amazon_product_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AmazonProductUrl { get; set; }

        /// <summary>
        /// Gets or sets AgeGroup.
        /// </summary>
        [JsonProperty("age_group", NullValueHandling = NullValueHandling.Ignore)]
        public string AgeGroup { get; set; }

        /// <summary>
        /// Gets or sets BookReviewLink.
        /// </summary>
        [JsonProperty("book_review_link", NullValueHandling = NullValueHandling.Ignore)]
        public string BookReviewLink { get; set; }

        /// <summary>
        /// Gets or sets FirstChapterLink.
        /// </summary>
        [JsonProperty("first_chapter_link", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstChapterLink { get; set; }

        /// <summary>
        /// Gets or sets SundayReviewLink.
        /// </summary>
        [JsonProperty("sunday_review_link", NullValueHandling = NullValueHandling.Ignore)]
        public string SundayReviewLink { get; set; }

        /// <summary>
        /// Gets or sets ArticleChapterLink.
        /// </summary>
        [JsonProperty("article_chapter_link", NullValueHandling = NullValueHandling.Ignore)]
        public string ArticleChapterLink { get; set; }

        /// <summary>
        /// Gets or sets Isbns.
        /// </summary>
        [JsonProperty("isbns", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Isbn> Isbns { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Book1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Book1 other &&
                ((this.Rank == null && other.Rank == null) || (this.Rank?.Equals(other.Rank) == true)) &&
                ((this.RankLastWeek == null && other.RankLastWeek == null) || (this.RankLastWeek?.Equals(other.RankLastWeek) == true)) &&
                ((this.WeeksOnList == null && other.WeeksOnList == null) || (this.WeeksOnList?.Equals(other.WeeksOnList) == true)) &&
                ((this.Asterisk == null && other.Asterisk == null) || (this.Asterisk?.Equals(other.Asterisk) == true)) &&
                ((this.Dagger == null && other.Dagger == null) || (this.Dagger?.Equals(other.Dagger) == true)) &&
                ((this.PrimaryIsbn10 == null && other.PrimaryIsbn10 == null) || (this.PrimaryIsbn10?.Equals(other.PrimaryIsbn10) == true)) &&
                ((this.PrimaryIsbn13 == null && other.PrimaryIsbn13 == null) || (this.PrimaryIsbn13?.Equals(other.PrimaryIsbn13) == true)) &&
                ((this.Publisher == null && other.Publisher == null) || (this.Publisher?.Equals(other.Publisher) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Author == null && other.Author == null) || (this.Author?.Equals(other.Author) == true)) &&
                ((this.Contributor == null && other.Contributor == null) || (this.Contributor?.Equals(other.Contributor) == true)) &&
                ((this.ContributorNote == null && other.ContributorNote == null) || (this.ContributorNote?.Equals(other.ContributorNote) == true)) &&
                ((this.BookImage == null && other.BookImage == null) || (this.BookImage?.Equals(other.BookImage) == true)) &&
                ((this.AmazonProductUrl == null && other.AmazonProductUrl == null) || (this.AmazonProductUrl?.Equals(other.AmazonProductUrl) == true)) &&
                ((this.AgeGroup == null && other.AgeGroup == null) || (this.AgeGroup?.Equals(other.AgeGroup) == true)) &&
                ((this.BookReviewLink == null && other.BookReviewLink == null) || (this.BookReviewLink?.Equals(other.BookReviewLink) == true)) &&
                ((this.FirstChapterLink == null && other.FirstChapterLink == null) || (this.FirstChapterLink?.Equals(other.FirstChapterLink) == true)) &&
                ((this.SundayReviewLink == null && other.SundayReviewLink == null) || (this.SundayReviewLink?.Equals(other.SundayReviewLink) == true)) &&
                ((this.ArticleChapterLink == null && other.ArticleChapterLink == null) || (this.ArticleChapterLink?.Equals(other.ArticleChapterLink) == true)) &&
                ((this.Isbns == null && other.Isbns == null) || (this.Isbns?.Equals(other.Isbns) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Rank = {(this.Rank == null ? "null" : this.Rank.ToString())}");
            toStringOutput.Add($"this.RankLastWeek = {(this.RankLastWeek == null ? "null" : this.RankLastWeek.ToString())}");
            toStringOutput.Add($"this.WeeksOnList = {(this.WeeksOnList == null ? "null" : this.WeeksOnList.ToString())}");
            toStringOutput.Add($"this.Asterisk = {(this.Asterisk == null ? "null" : this.Asterisk.ToString())}");
            toStringOutput.Add($"this.Dagger = {(this.Dagger == null ? "null" : this.Dagger.ToString())}");
            toStringOutput.Add($"this.PrimaryIsbn10 = {(this.PrimaryIsbn10 == null ? "null" : this.PrimaryIsbn10 == string.Empty ? "" : this.PrimaryIsbn10)}");
            toStringOutput.Add($"this.PrimaryIsbn13 = {(this.PrimaryIsbn13 == null ? "null" : this.PrimaryIsbn13 == string.Empty ? "" : this.PrimaryIsbn13)}");
            toStringOutput.Add($"this.Publisher = {(this.Publisher == null ? "null" : this.Publisher == string.Empty ? "" : this.Publisher)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Author = {(this.Author == null ? "null" : this.Author == string.Empty ? "" : this.Author)}");
            toStringOutput.Add($"this.Contributor = {(this.Contributor == null ? "null" : this.Contributor == string.Empty ? "" : this.Contributor)}");
            toStringOutput.Add($"this.ContributorNote = {(this.ContributorNote == null ? "null" : this.ContributorNote == string.Empty ? "" : this.ContributorNote)}");
            toStringOutput.Add($"this.BookImage = {(this.BookImage == null ? "null" : this.BookImage == string.Empty ? "" : this.BookImage)}");
            toStringOutput.Add($"this.AmazonProductUrl = {(this.AmazonProductUrl == null ? "null" : this.AmazonProductUrl == string.Empty ? "" : this.AmazonProductUrl)}");
            toStringOutput.Add($"this.AgeGroup = {(this.AgeGroup == null ? "null" : this.AgeGroup == string.Empty ? "" : this.AgeGroup)}");
            toStringOutput.Add($"this.BookReviewLink = {(this.BookReviewLink == null ? "null" : this.BookReviewLink == string.Empty ? "" : this.BookReviewLink)}");
            toStringOutput.Add($"this.FirstChapterLink = {(this.FirstChapterLink == null ? "null" : this.FirstChapterLink == string.Empty ? "" : this.FirstChapterLink)}");
            toStringOutput.Add($"this.SundayReviewLink = {(this.SundayReviewLink == null ? "null" : this.SundayReviewLink == string.Empty ? "" : this.SundayReviewLink)}");
            toStringOutput.Add($"this.ArticleChapterLink = {(this.ArticleChapterLink == null ? "null" : this.ArticleChapterLink == string.Empty ? "" : this.ArticleChapterLink)}");
            toStringOutput.Add($"this.Isbns = {(this.Isbns == null ? "null" : $"[{string.Join(", ", this.Isbns)} ]")}");
        }
    }
}