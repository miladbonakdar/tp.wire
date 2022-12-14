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
    /// ProfileDto
    /// </summary>
    [DataContract(Name = "ProfileDto")]
    public partial class ProfileDto : IEquatable<ProfileDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ProfileType? Type { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public GenderType? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfileDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="lastname">lastname (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="phone">phone.</param>
        /// <param name="emailVerified">emailVerified.</param>
        /// <param name="phoneVerified">phoneVerified.</param>
        /// <param name="type">type.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="birthDate">birthDate.</param>
        /// <param name="bio">bio.</param>
        /// <param name="gender">gender.</param>
        /// <param name="interests">interests.</param>
        /// <param name="image">image.</param>
        /// <param name="setting">setting.</param>
        public ProfileDto(string id = default(string), string name = default(string), string lastname = default(string), string email = default(string), string phone = default(string), bool emailVerified = default(bool), bool phoneVerified = default(bool), ProfileType? type = default(ProfileType?), long createdAt = default(long), long updatedAt = default(long), long? birthDate = default(long?), string bio = default(string), GenderType? gender = default(GenderType?), List<InterestDto> interests = default(List<InterestDto>), string image = default(string), ProfileSettingDto setting = default(ProfileSettingDto))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ProfileDto and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ProfileDto and cannot be null");
            }
            this.Name = name;
            // to ensure "lastname" is required (not null)
            if (lastname == null)
            {
                throw new ArgumentNullException("lastname is a required property for ProfileDto and cannot be null");
            }
            this.Lastname = lastname;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for ProfileDto and cannot be null");
            }
            this.Email = email;
            this.Phone = phone;
            this.EmailVerified = emailVerified;
            this.PhoneVerified = phoneVerified;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.BirthDate = birthDate;
            this.Bio = bio;
            this.Gender = gender;
            this.Interests = interests;
            this.Image = image;
            this.Setting = setting;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name = "lastname", IsRequired = true, EmitDefaultValue = true)]
        public string Lastname { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets EmailVerified
        /// </summary>
        [DataMember(Name = "emailVerified", EmitDefaultValue = true)]
        public bool EmailVerified { get; set; }

        /// <summary>
        /// Gets or Sets PhoneVerified
        /// </summary>
        [DataMember(Name = "phoneVerified", EmitDefaultValue = true)]
        public bool PhoneVerified { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public long UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", EmitDefaultValue = true)]
        public long? BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name = "bio", EmitDefaultValue = true)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets Interests
        /// </summary>
        [DataMember(Name = "interests", EmitDefaultValue = true)]
        public List<InterestDto> Interests { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Setting
        /// </summary>
        [DataMember(Name = "setting", EmitDefaultValue = false)]
        public ProfileSettingDto Setting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProfileDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  PhoneVerified: ").Append(PhoneVerified).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Interests: ").Append(Interests).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Setting: ").Append(Setting).Append("\n");
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
            return this.Equals(input as ProfileDto);
        }

        /// <summary>
        /// Returns true if ProfileDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.EmailVerified == input.EmailVerified ||
                    this.EmailVerified.Equals(input.EmailVerified)
                ) && 
                (
                    this.PhoneVerified == input.PhoneVerified ||
                    this.PhoneVerified.Equals(input.PhoneVerified)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    this.UpdatedAt.Equals(input.UpdatedAt)
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.Gender == input.Gender ||
                    this.Gender.Equals(input.Gender)
                ) && 
                (
                    this.Interests == input.Interests ||
                    this.Interests != null &&
                    input.Interests != null &&
                    this.Interests.SequenceEqual(input.Interests)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Setting == input.Setting ||
                    (this.Setting != null &&
                    this.Setting.Equals(input.Setting))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Lastname != null)
                {
                    hashCode = (hashCode * 59) + this.Lastname.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EmailVerified.GetHashCode();
                hashCode = (hashCode * 59) + this.PhoneVerified.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                if (this.BirthDate != null)
                {
                    hashCode = (hashCode * 59) + this.BirthDate.GetHashCode();
                }
                if (this.Bio != null)
                {
                    hashCode = (hashCode * 59) + this.Bio.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                if (this.Interests != null)
                {
                    hashCode = (hashCode * 59) + this.Interests.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Setting != null)
                {
                    hashCode = (hashCode * 59) + this.Setting.GetHashCode();
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
