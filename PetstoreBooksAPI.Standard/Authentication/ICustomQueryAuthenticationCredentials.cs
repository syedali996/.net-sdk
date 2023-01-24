// <copyright file="ICustomQueryAuthenticationCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PetstoreBooksAPI.Standard.Authentication
{
    using System;

    public interface ICustomQueryAuthenticationCredentials
    {
        /// <summary>
        /// Gets string value for apiKey.
        /// </summary>
        string ApiKey { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="apiKey"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string apiKey);
    }
}