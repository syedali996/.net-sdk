// <copyright file="StatusEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PetstoreBooksAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PetstoreBooksAPI.Standard;
    using PetstoreBooksAPI.Standard.Utilities;

    /// <summary>
    /// StatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Available.
        /// </summary>
        [EnumMember(Value = "available")]
        Available,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Sold.
        /// </summary>
        [EnumMember(Value = "sold")]
        Sold
    }
}