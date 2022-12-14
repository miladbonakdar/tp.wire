# profile.wire - the C# library for the TP.Profile.Service

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdminAuthApi(config);
            var emailPasswordLoginReq = new EmailPasswordLoginReq?(); // EmailPasswordLoginReq? |  (optional) 

            try
            {
                LoginRes result = apiInstance.AdminAuthLoginPost(emailPasswordLoginReq);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminAuthApi.AdminAuthLoginPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdminAuthApi* | [**AdminAuthLoginPost**](docs/AdminAuthApi.md#adminauthloginpost) | **POST** /AdminAuth/Login | 
*AdminAuthApi* | [**AdminAuthRefreshTokenPost**](docs/AdminAuthApi.md#adminauthrefreshtokenpost) | **POST** /AdminAuth/RefreshToken | 
*AssistantListingApi* | [**AssistantListingListingPost**](docs/AssistantListingApi.md#assistantlistinglistingpost) | **POST** /AssistantListing/Listing | 
*AssistantListingApi* | [**AssistantListingUserListingPost**](docs/AssistantListingApi.md#assistantlistinguserlistingpost) | **POST** /AssistantListing/UserListing | 
*HealthApi* | [**HealthGet**](docs/HealthApi.md#healthget) | **GET** /Health | 
*InterestApi* | [**InterestForceUpdateCachePost**](docs/InterestApi.md#interestforceupdatecachepost) | **POST** /Interest/ForceUpdateCache | 
*InterestApi* | [**InterestGet**](docs/InterestApi.md#interestget) | **GET** /Interest | 
*InterestApi* | [**InterestPatch**](docs/InterestApi.md#interestpatch) | **PATCH** /Interest | 
*InterestApi* | [**InterestPost**](docs/InterestApi.md#interestpost) | **POST** /Interest | 
*ProfileApi* | [**ProfileCanBeAssistantGet**](docs/ProfileApi.md#profilecanbeassistantget) | **GET** /Profile/CanBeAssistant | 
*ProfileApi* | [**ProfileConvertToAssistantPost**](docs/ProfileApi.md#profileconverttoassistantpost) | **POST** /Profile/ConvertToAssistant | 
*ProfileApi* | [**ProfileMeGet**](docs/ProfileApi.md#profilemeget) | **GET** /Profile/Me | 
*ProfileApi* | [**ProfileProfileIdGet**](docs/ProfileApi.md#profileprofileidget) | **GET** /Profile/{profileId} | 
*ProfileApi* | [**ProfileUpdateInterestsPost**](docs/ProfileApi.md#profileupdateinterestspost) | **POST** /Profile/UpdateInterests | 
*ProfileApi* | [**ProfileUpdateProfilePatch**](docs/ProfileApi.md#profileupdateprofilepatch) | **PATCH** /Profile/UpdateProfile | 
*ProfileApi* | [**ProfileUploadAvatarPatch**](docs/ProfileApi.md#profileuploadavatarpatch) | **PATCH** /Profile/UploadAvatar | 
*ProfileSecurityApi* | [**ProfileSecurityEmailVerifyPatch**](docs/ProfileSecurityApi.md#profilesecurityemailverifypatch) | **PATCH** /ProfileSecurity/EmailVerify | 
*ProfileSecurityApi* | [**ProfileSecuritySendEmailVerifyRequestPost**](docs/ProfileSecurityApi.md#profilesecuritysendemailverifyrequestpost) | **POST** /ProfileSecurity/SendEmailVerifyRequest | 
*ProfileSecurityApi* | [**ProfileSecurityUpdatePasswordOtpRequestPost**](docs/ProfileSecurityApi.md#profilesecurityupdatepasswordotprequestpost) | **POST** /ProfileSecurity/UpdatePasswordOtpRequest | 
*ProfileSecurityApi* | [**ProfileSecurityUpdatePasswordOtpVerifyPatch**](docs/ProfileSecurityApi.md#profilesecurityupdatepasswordotpverifypatch) | **PATCH** /ProfileSecurity/UpdatePasswordOtpVerify | 
*ProfileSecurityApi* | [**ProfileSecurityUpdatePasswordPatch**](docs/ProfileSecurityApi.md#profilesecurityupdatepasswordpatch) | **PATCH** /ProfileSecurity/UpdatePassword | 
*ProfileSecurityApi* | [**ProfileSecurityUpdatePhoneRequestPost**](docs/ProfileSecurityApi.md#profilesecurityupdatephonerequestpost) | **POST** /ProfileSecurity/UpdatePhoneRequest | 
*ProfileSecurityApi* | [**ProfileSecurityUpdatePhoneVerifyPatch**](docs/ProfileSecurityApi.md#profilesecurityupdatephoneverifypatch) | **PATCH** /ProfileSecurity/UpdatePhoneVerify | 
*ProfileSettingApi* | [**ProfileSettingUpdateProfileSettingPatch**](docs/ProfileSettingApi.md#profilesettingupdateprofilesettingpatch) | **PATCH** /ProfileSetting/UpdateProfileSetting | 
*UserAuthApi* | [**UserAuthGoogleLoginPost**](docs/UserAuthApi.md#userauthgoogleloginpost) | **POST** /UserAuth/GoogleLogin | 
*UserAuthApi* | [**UserAuthLoginPost**](docs/UserAuthApi.md#userauthloginpost) | **POST** /UserAuth/Login | 
*UserAuthApi* | [**UserAuthOtpLoginRequestPost**](docs/UserAuthApi.md#userauthotploginrequestpost) | **POST** /UserAuth/OtpLoginRequest | 
*UserAuthApi* | [**UserAuthOtpLoginValidatePost**](docs/UserAuthApi.md#userauthotploginvalidatepost) | **POST** /UserAuth/OtpLoginValidate | 
*UserAuthApi* | [**UserAuthRefreshTokenPost**](docs/UserAuthApi.md#userauthrefreshtokenpost) | **POST** /UserAuth/RefreshToken | 
*UserAuthApi* | [**UserAuthRegisterPost**](docs/UserAuthApi.md#userauthregisterpost) | **POST** /UserAuth/Register | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddInterestReq](docs/AddInterestReq.md)
 - [Model.AssistantListItem](docs/AssistantListItem.md)
 - [Model.AssistantListingReq](docs/AssistantListingReq.md)
 - [Model.AssistantListingRes](docs/AssistantListingRes.md)
 - [Model.CanBeAssistantRes](docs/CanBeAssistantRes.md)
 - [Model.EmailPasswordLoginReq](docs/EmailPasswordLoginReq.md)
 - [Model.EmptyResponse](docs/EmptyResponse.md)
 - [Model.GenderType](docs/GenderType.md)
 - [Model.HealthRes](docs/HealthRes.md)
 - [Model.InterestDto](docs/InterestDto.md)
 - [Model.InterestUpdateReq](docs/InterestUpdateReq.md)
 - [Model.LoginRes](docs/LoginRes.md)
 - [Model.OtpForgetPasswordRes](docs/OtpForgetPasswordRes.md)
 - [Model.OtpLoginReq](docs/OtpLoginReq.md)
 - [Model.OtpLoginValidateReq](docs/OtpLoginValidateReq.md)
 - [Model.OtpRequestRes](docs/OtpRequestRes.md)
 - [Model.ProfileDto](docs/ProfileDto.md)
 - [Model.ProfileSettingDto](docs/ProfileSettingDto.md)
 - [Model.ProfileType](docs/ProfileType.md)
 - [Model.RefreshTokenReq](docs/RefreshTokenReq.md)
 - [Model.SendEmailVerifyRes](docs/SendEmailVerifyRes.md)
 - [Model.UpdateInterestsReq](docs/UpdateInterestsReq.md)
 - [Model.UpdatePasswordReq](docs/UpdatePasswordReq.md)
 - [Model.UpdateProfileReq](docs/UpdateProfileReq.md)
 - [Model.UpdateProfileSettingReq](docs/UpdateProfileSettingReq.md)
 - [Model.UserRegisterReq](docs/UserRegisterReq.md)
 - [Model.ValidateEmailReq](docs/ValidateEmailReq.md)
 - [Model.ValidateOtpUpdatePasswordReq](docs/ValidateOtpUpdatePasswordReq.md)
 - [Model.ValidatePhoneVerificationReq](docs/ValidatePhoneVerificationReq.md)
 - [Model.VerifyPhoneReq](docs/VerifyPhoneReq.md)
 - [Model.VerifyPhoneRes](docs/VerifyPhoneRes.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: Bearer Authentication

