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
    /// Check value for Concrete Block
    /// </summary>
    [DataContract(Name = "CheckResConcreteBlock")]
    public partial class CheckResConcreteBlock : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckResConcreteBlock" /> class.
        /// </summary>
        /// <param name="name">Name of Concrete Block.</param>
        /// <param name="unityCheck">Unity Check.</param>
        /// <param name="checkStatus">Status of the Check.</param>
        /// <param name="loadCaseId">Id of Load Case.</param>
        public CheckResConcreteBlock(string name = default(string), double unityCheck = default(double), bool checkStatus = default(bool), int loadCaseId = default(int))
        {
            this.Name = name;
            this.UnityCheck = unityCheck;
            this.CheckStatus = checkStatus;
            this.LoadCaseId = loadCaseId;
        }

        /// <summary>
        /// Name of Concrete Block
        /// </summary>
        /// <value>Name of Concrete Block</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Unity Check
        /// </summary>
        /// <value>Unity Check</value>
        [DataMember(Name = "unityCheck", EmitDefaultValue = false)]
        public double UnityCheck { get; set; }

        /// <summary>
        /// Status of the Check
        /// </summary>
        /// <value>Status of the Check</value>
        [DataMember(Name = "checkStatus", EmitDefaultValue = true)]
        public bool CheckStatus { get; set; }

        /// <summary>
        /// Id of Load Case
        /// </summary>
        /// <value>Id of Load Case</value>
        [DataMember(Name = "loadCaseId", EmitDefaultValue = false)]
        public int LoadCaseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckResConcreteBlock {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UnityCheck: ").Append(UnityCheck).Append("\n");
            sb.Append("  CheckStatus: ").Append(CheckStatus).Append("\n");
            sb.Append("  LoadCaseId: ").Append(LoadCaseId).Append("\n");
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
