/*
 * Connection Rest API 1.0
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = IdeaStatiCa.ConnectionApi.Client.OpenAPIDateConverter;

namespace IdeaStatiCa.ConnectionApi.Model
{
    /// <summary>
    /// Represents the result of comparison of distances of two object from the same point
    /// </summary>
    /// <value>Represents the result of comparison of distances of two object from the same point</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DistanceComparison
    {
        /// <summary>
        /// Enum Closer for value: closer
        /// </summary>
        [EnumMember(Value = "closer")]
        Closer = 1,

        /// <summary>
        /// Enum Farther for value: farther
        /// </summary>
        [EnumMember(Value = "farther")]
        Farther = 2,

        /// <summary>
        /// Enum Same for value: same
        /// </summary>
        [EnumMember(Value = "same")]
        Same = 3
    }

}
