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
    /// Defines ConAnalysisTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConAnalysisTypeEnum
    {
        /// <summary>
        /// Enum StressStrain for value: stress_Strain
        /// </summary>
        [EnumMember(Value = "stress_Strain")]
        StressStrain = 1,

        /// <summary>
        /// Enum Stiffness for value: stiffness
        /// </summary>
        [EnumMember(Value = "stiffness")]
        Stiffness = 2,

        /// <summary>
        /// Enum CapacityDesign for value: capacity_Design
        /// </summary>
        [EnumMember(Value = "capacity_Design")]
        CapacityDesign = 3,

        /// <summary>
        /// Enum Fatigues for value: fatigues
        /// </summary>
        [EnumMember(Value = "fatigues")]
        Fatigues = 4,

        /// <summary>
        /// Enum TotalDesign for value: total_Design
        /// </summary>
        [EnumMember(Value = "total_Design")]
        TotalDesign = 5,

        /// <summary>
        /// Enum HorizontalTying for value: horizontalTying
        /// </summary>
        [EnumMember(Value = "horizontalTying")]
        HorizontalTying = 6,

        /// <summary>
        /// Enum CapacityLoadLevels for value: capacityLoadLevels
        /// </summary>
        [EnumMember(Value = "capacityLoadLevels")]
        CapacityLoadLevels = 7,

        /// <summary>
        /// Enum FireRestance for value: fireRestance
        /// </summary>
        [EnumMember(Value = "fireRestance")]
        FireRestance = 8,

        /// <summary>
        /// Enum Buckling for value: buckling
        /// </summary>
        [EnumMember(Value = "buckling")]
        Buckling = 9
    }

}
