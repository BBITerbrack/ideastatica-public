/*
 * Connection Rest API 1.0
 *
 * API for designing steel connections
 *
 * The version of the OpenAPI document: 1.0
 * Contact: info@ideastatica.com
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
    /// Text
    /// </summary>
    [DataContract(Name = "Text")]
    public partial class Text : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Text" /> class.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="value">value.</param>
        /// <param name="position">position.</param>
        /// <param name="fontSize">fontSize.</param>
        /// <param name="tag">tag.</param>
        public Text(List<int> color = default(List<int>), string value = default(string), TextPosition position = default(TextPosition), double fontSize = default(double), double tag = default(double))
        {
            this.Color = color;
            this.Value = value;
            this.Position = position;
            this.FontSize = fontSize;
            this.Tag = tag;
        }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public List<int> Color { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public TextPosition Position { get; set; }

        /// <summary>
        /// Gets or Sets FontSize
        /// </summary>
        [DataMember(Name = "fontSize", EmitDefaultValue = false)]
        public double FontSize { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public double Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Text {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
