// <copyright file="Review.cs" company="APIMatic">
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
    /// Review.
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class.
        /// </summary>
        public Review()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class.
        /// </summary>
        /// <param name="bookReviewLink">book_review_link.</param>
        /// <param name="firstChapterLink">first_chapter_link.</param>
        /// <param name="sundayReviewLink">sunday_review_link.</param>
        /// <param name="articleChapterLink">article_chapter_link.</param>
        public Review(
            string bookReviewLink = null,
            string firstChapterLink = null,
            string sundayReviewLink = null,
            string articleChapterLink = null)
        {
            this.BookReviewLink = bookReviewLink;
            this.FirstChapterLink = firstChapterLink;
            this.SundayReviewLink = sundayReviewLink;
            this.ArticleChapterLink = articleChapterLink;
        }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Review : ({string.Join(", ", toStringOutput)})";
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

            return obj is Review other &&
                ((this.BookReviewLink == null && other.BookReviewLink == null) || (this.BookReviewLink?.Equals(other.BookReviewLink) == true)) &&
                ((this.FirstChapterLink == null && other.FirstChapterLink == null) || (this.FirstChapterLink?.Equals(other.FirstChapterLink) == true)) &&
                ((this.SundayReviewLink == null && other.SundayReviewLink == null) || (this.SundayReviewLink?.Equals(other.SundayReviewLink) == true)) &&
                ((this.ArticleChapterLink == null && other.ArticleChapterLink == null) || (this.ArticleChapterLink?.Equals(other.ArticleChapterLink) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BookReviewLink = {(this.BookReviewLink == null ? "null" : this.BookReviewLink == string.Empty ? "" : this.BookReviewLink)}");
            toStringOutput.Add($"this.FirstChapterLink = {(this.FirstChapterLink == null ? "null" : this.FirstChapterLink == string.Empty ? "" : this.FirstChapterLink)}");
            toStringOutput.Add($"this.SundayReviewLink = {(this.SundayReviewLink == null ? "null" : this.SundayReviewLink == string.Empty ? "" : this.SundayReviewLink)}");
            toStringOutput.Add($"this.ArticleChapterLink = {(this.ArticleChapterLink == null ? "null" : this.ArticleChapterLink == string.Empty ? "" : this.ArticleChapterLink)}");
        }
    }
}