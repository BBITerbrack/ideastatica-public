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
    /// Provides data of the single weld
    /// </summary>
    [DataContract(Name = "WeldData")]
    public partial class WeldData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets WeldType
        /// </summary>
        [DataMember(Name = "weldType", EmitDefaultValue = false)]
        public WeldType? WeldType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WeldData" /> class.
        /// </summary>
        /// <param name="id">Id of the weld.</param>
        /// <param name="name">Name of the weld.</param>
        /// <param name="thickness">Thickness of the weld.</param>
        /// <param name="material">Name of the material.</param>
        /// <param name="weldMaterial">weldMaterial.</param>
        /// <param name="weldType">weldType.</param>
        /// <param name="connectedPartIds">Id of the weld.</param>
        /// <param name="start">start.</param>
        /// <param name="end">end.</param>
        public WeldData(int id = default(int), string name = default(string), double thickness = default(double), string material = default(string), ReferenceElement weldMaterial = default(ReferenceElement), WeldType? weldType = default(WeldType?), List<string> connectedPartIds = default(List<string>), Point3D start = default(Point3D), Point3D end = default(Point3D))
        {
            this.Id = id;
            this.Name = name;
            this.Thickness = thickness;
            this.Material = material;
            this.WeldMaterial = weldMaterial;
            this.WeldType = weldType;
            this.ConnectedPartIds = connectedPartIds;
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Id of the weld
        /// </summary>
        /// <value>Id of the weld</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Name of the weld
        /// </summary>
        /// <value>Name of the weld</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Thickness of the weld
        /// </summary>
        /// <value>Thickness of the weld</value>
        [DataMember(Name = "thickness", EmitDefaultValue = false)]
        public double Thickness { get; set; }

        /// <summary>
        /// Name of the material
        /// </summary>
        /// <value>Name of the material</value>
        [DataMember(Name = "material", EmitDefaultValue = true)]
        public string Material { get; set; }

        /// <summary>
        /// Gets or Sets WeldMaterial
        /// </summary>
        [DataMember(Name = "weldMaterial", EmitDefaultValue = false)]
        public ReferenceElement WeldMaterial { get; set; }

        /// <summary>
        /// Id of the weld
        /// </summary>
        /// <value>Id of the weld</value>
        [DataMember(Name = "connectedPartIds", EmitDefaultValue = true)]
        public List<string> ConnectedPartIds { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public Point3D Start { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public Point3D End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WeldData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  Material: ").Append(Material).Append("\n");
            sb.Append("  WeldMaterial: ").Append(WeldMaterial).Append("\n");
            sb.Append("  WeldType: ").Append(WeldType).Append("\n");
            sb.Append("  ConnectedPartIds: ").Append(ConnectedPartIds).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
