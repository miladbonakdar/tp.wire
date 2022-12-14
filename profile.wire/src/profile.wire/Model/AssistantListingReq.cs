/*
 * TP.Profile.Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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
using OpenAPIDateConverter = profile.wire.Client.OpenAPIDateConverter;

namespace profile.wire.Model
{
    /// <summary>
    /// AssistantListingReq
    /// </summary>
    [DataContract(Name = "AssistantListingReq")]
    public partial class AssistantListingReq : IEquatable<AssistantListingReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantListingReq" /> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="size">size.</param>
        /// <param name="search">search.</param>
        /// <param name="sort">sort.</param>
        public AssistantListingReq(int page = default(int), int size = default(int), string search = default(string), string sort = default(string))
        {
            this.Page = page;
            this.Size = size;
            this.Search = search;
            this.Sort = sort;
        }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Gets or Sets Search
        /// </summary>
        [DataMember(Name = "search", EmitDefaultValue = true)]
        public string Search { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name = "sort", EmitDefaultValue = true)]
        public string Sort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssistantListingReq {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssistantListingReq);
        }

        /// <summary>
        /// Returns true if AssistantListingReq instances are equal
        /// </summary>
        /// <param name="input">Instance of AssistantListingReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssistantListingReq input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                if (this.Search != null)
                {
                    hashCode = (hashCode * 59) + this.Search.GetHashCode();
                }
                if (this.Sort != null)
                {
                    hashCode = (hashCode * 59) + this.Sort.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Page (int) maximum
            if (this.Page > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Page, must be a value less than or equal to 2147483647.", new [] { "Page" });
            }

            // Page (int) minimum
            if (this.Page < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Page, must be a value greater than or equal to 0.", new [] { "Page" });
            }

            // Size (int) maximum
            if (this.Size > (int)40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Size, must be a value less than or equal to 40.", new [] { "Size" });
            }

            // Size (int) minimum
            if (this.Size < (int)5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Size, must be a value greater than or equal to 5.", new [] { "Size" });
            }

            yield break;
        }
    }

}
