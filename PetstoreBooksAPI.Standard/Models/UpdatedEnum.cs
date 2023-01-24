// <copyright file="UpdatedEnum.cs" company="APIMatic">
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
    /// UpdatedEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpdatedEnum
    {
        /// <summary>
        /// WEEKLY.
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY,

        /// <summary>
        /// MONTHLY.
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY
    }
}