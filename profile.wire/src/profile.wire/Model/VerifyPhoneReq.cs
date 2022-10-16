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
    /// VerifyPhoneReq
    /// </summary>
    [DataContract(Name = "VerifyPhoneReq")]
    public partial class VerifyPhoneReq : IEquatable<VerifyPhoneReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPhoneReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyPhoneReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPhoneReq" /> class.
        /// </summary>
        /// <param name="phone">phone (required).</param>
        public VerifyPhoneReq(string phone = default(string))
        {
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new ArgumentNullException("phone is a required property for VerifyPhoneReq and cannot be null");
            }
            this.Phone = phone;
        }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", IsRequired = true, EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerifyPhoneReq {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(input as VerifyPhoneReq);
        }

        /// <summary>
        /// Returns true if VerifyPhoneReq instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyPhoneReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyPhoneReq input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
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
            yield break;
        }
    }

}