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
    /// Results of the buckling analysis
    /// </summary>
    [DataContract(Name = "BucklingRes")]
    public partial class BucklingRes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucklingRes" /> class.
        /// </summary>
        /// <param name="loadCaseId">loadCaseId.</param>
        /// <param name="shape">Shape lc calculated by solver.</param>
        /// <param name="factor">Buckling factor.</param>
        public BucklingRes(int loadCaseId = default(int), int shape = default(int), double factor = default(double))
        {
            this.LoadCaseId = loadCaseId;
            this.Shape = shape;
            this.Factor = factor;
        }

        /// <summary>
        /// Gets or Sets LoadCaseId
        /// </summary>
        [DataMember(Name = "loadCaseId", EmitDefaultValue = false)]
        public int LoadCaseId { get; set; }

        /// <summary>
        /// Shape lc calculated by solver
        /// </summary>
        /// <value>Shape lc calculated by solver</value>
        [DataMember(Name = "shape", EmitDefaultValue = false)]
        public int Shape { get; set; }

        /// <summary>
        /// Buckling factor
        /// </summary>
        /// <value>Buckling factor</value>
        [DataMember(Name = "factor", EmitDefaultValue = false)]
        public double Factor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BucklingRes {\n");
            sb.Append("  LoadCaseId: ").Append(LoadCaseId).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
