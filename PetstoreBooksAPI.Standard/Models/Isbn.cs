// <copyright file="Isbn.cs" company="APIMatic">
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
    /// Isbn.
    /// </summary>
    public class Isbn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Isbn"/> class.
        /// </summary>
        public Isbn()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Isbn"/> class.
        /// </summary>
        /// <param name="isbn10">isbn10.</param>
        /// <param name="isbn13">isbn13.</param>
        public Isbn(
            string isbn10 = null,
            string isbn13 = null)
        {
            this.Isbn10 = isbn10;
            this.Isbn13 = isbn13;
        }

        /// <summary>
        /// Gets or sets Isbn10.
        /// </summary>
        [JsonProperty("isbn10", NullValueHandling = NullValueHandling.Ignore)]
        public string Isbn10 { get; set; }

        /// <summary>
        /// Gets or sets Isbn13.
        /// </summary>
        [JsonProperty("isbn13", NullValueHandling = NullValueHandling.Ignore)]
        public string Isbn13 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Isbn : ({string.Join(", ", toStringOutput)})";
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

            return obj is Isbn other &&
                ((this.Isbn10 == null && other.Isbn10 == null) || (this.Isbn10?.Equals(other.Isbn10) == true)) &&
                ((this.Isbn13 == null && other.Isbn13 == null) || (this.Isbn13?.Equals(other.Isbn13) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Isbn10 = {(this.Isbn10 == null ? "null" : this.Isbn10 == string.Empty ? "" : this.Isbn10)}");
            toStringOutput.Add($"this.Isbn13 = {(this.Isbn13 == null ? "null" : this.Isbn13 == string.Empty ? "" : this.Isbn13)}");
        }
    }
}