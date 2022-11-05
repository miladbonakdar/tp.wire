# profile.wire.Api.ProfileSecurityApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProfileSecurityEmailVerifyPatch**](ProfileSecurityApi.md#profilesecurityemailverifypatch) | **PATCH** /ProfileSecurity/EmailVerify |  |
| [**ProfileSecuritySendEmailVerifyRequestPost**](ProfileSecurityApi.md#profilesecuritysendemailverifyrequestpost) | **POST** /ProfileSecurity/SendEmailVerifyRequest |  |
| [**ProfileSecurityUpdatePasswordOtpRequestPost**](ProfileSecurityApi.md#profilesecurityupdatepasswordotprequestpost) | **POST** /ProfileSecurity/UpdatePasswordOtpRequest |  |
| [**ProfileSecurityUpdatePasswordOtpVerifyPatch**](ProfileSecurityApi.md#profilesecurityupdatepasswordotpverifypatch) | **PATCH** /ProfileSecurity/UpdatePasswordOtpVerify |  |
| [**ProfileSecurityUpdatePasswordPatch**](ProfileSecurityApi.md#profilesecurityupdatepasswordpatch) | **PATCH** /ProfileSecurity/UpdatePassword |  |
| [**ProfileSecurityUpdatePhoneRequestPost**](ProfileSecurityApi.md#profilesecurityupdatephonerequestpost) | **POST** /ProfileSecurity/UpdatePhoneRequest |  |
| [**ProfileSecurityUpdatePhoneVerifyPatch**](ProfileSecurityApi.md#profilesecurityupdatephoneverifypatch) | **PATCH** /ProfileSecurity/UpdatePhoneVerify |  |

<a name="profilesecurityemailverifypatch"></a>
# **ProfileSecurityEmailVerifyPatch**
> EmptyResponse ProfileSecurityEmailVerifyPatch (ValidateEmailReq? validateEmailReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileSecurityEmailVerifyPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileSecurityApi(config);
            var validateEmailReq = new ValidateEmailReq?(); // ValidateEmailReq? |  (optional) 

            try
            {
                EmptyResponse result = apiInstance.ProfileSecurityEmailVerifyPatch(validateEmailReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityEmailVerifyPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileSecurityEmailVerifyPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmptyResponse> response = apiInstance.ProfileSecurityEmailVerifyPatchWithHttpInfo(validateEmailReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityEmailVerifyPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateEmailReq** | [**ValidateEmailReq?**](ValidateEmailReq?.md) |  | [optional]  |

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesecuritysendemailverifyrequestpost"></a>
# **ProfileSecuritySendEmailVerifyRequestPost**
> SendEmailVerifyRes ProfileSecuritySendEmailVerifyRequestPost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileSecuritySendEmailVerifyRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileSecurityApi(config);

            try
            {
                SendEmailVerifyRes result = apiInstance.ProfileSecuritySendEmailVerifyRequestPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecuritySendEmailVerifyRequestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileSecuritySendEmailVerifyRequestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SendEmailVerifyRes> response = apiInstance.ProfileSecuritySendEmailVerifyRequestPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecuritySendEmailVerifyRequestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SendEmailVerifyRes**](SendEmailVerifyRes.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesecurityupdatepasswordotprequestpost"></a>
# **ProfileSecurityUpdatePasswordOtpRequestPost**
> OtpForgetPasswordRes ProfileSecurityUpdatePasswordOtpRequestPost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileSecurityUpdatePasswordOtpRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileSecurityApi(config);

            try
            {
                OtpForgetPasswordRes result = apiInstance.ProfileSecurityUpdatePasswordOtpRequestPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePasswordOtpRequestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileSecurityUpdatePasswordOtpRequestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OtpForgetPasswordRes> response = apiInstance.ProfileSecurityUpdatePasswordOtpRequestPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePasswordOtpRequestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OtpForgetPasswordRes**](OtpForgetPasswordRes.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesecurityupdatepasswordotpverifypatch"></a>
# **ProfileSecurityUpdatePasswordOtpVerifyPatch**
> EmptyResponse ProfileSecurityUpdatePasswordOtpVerifyPatch (ValidateOtpUpdatePasswordReq? validateOtpUpdatePasswordReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileSecurityUpdatePasswordOtpVerifyPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileSecurityApi(config);
            var validateOtpUpdatePasswordReq = new ValidateOtpUpdatePasswordReq?(); // ValidateOtpUpdatePasswordReq? |  (optional) 

            try
            {
                EmptyResponse result = apiInstance.ProfileSecurityUpdatePasswordOtpVerifyPatch(validateOtpUpdatePasswordReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePasswordOtpVerifyPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileSecurityUpdatePasswordOtpVerifyPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmptyResponse> response = apiInstance.ProfileSecurityUpdatePasswordOtpVerifyPatchWithHttpInfo(validateOtpUpdatePasswordReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePasswordOtpVerifyPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateOtpUpdatePasswordReq** | [**ValidateOtpUpdatePasswordReq?**](ValidateOtpUpdatePasswordReq?.md) |  | [optional]  |

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesecurityupdatepasswordpatch"></a>
# **ProfileSecurityUpdatePasswordPatch**
> EmptyResponse ProfileSecurityUpdatePasswordPatch (UpdatePasswordReq? updatePasswordReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileSecurityUpdatePasswordPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileSecurityApi(config);
            var updatePasswordReq = new UpdatePasswordReq?(); // UpdatePasswordReq? |  (optional) 

            try
            {
                EmptyResponse result = apiInstance.ProfileSecurityUpdatePasswordPatch(updatePasswordReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePasswordPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileSecurityUpdatePasswordPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmptyResponse> response = apiInstance.ProfileSecurityUpdatePasswordPatchWithHttpInfo(updatePasswordReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePasswordPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updatePasswordReq** | [**UpdatePasswordReq?**](UpdatePasswordReq?.md) |  | [optional]  |

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesecurityupdatephonerequestpost"></a>
# **ProfileSecurityUpdatePhoneRequestPost**
> VerifyPhoneRes ProfileSecurityUpdatePhoneRequestPost (VerifyPhoneReq? verifyPhoneReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileSecurityUpdatePhoneRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileSecurityApi(config);
            var verifyPhoneReq = new VerifyPhoneReq?(); // VerifyPhoneReq? |  (optional) 

            try
            {
                VerifyPhoneRes result = apiInstance.ProfileSecurityUpdatePhoneRequestPost(verifyPhoneReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePhoneRequestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileSecurityUpdatePhoneRequestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VerifyPhoneRes> response = apiInstance.ProfileSecurityUpdatePhoneRequestPostWithHttpInfo(verifyPhoneReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePhoneRequestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verifyPhoneReq** | [**VerifyPhoneReq?**](VerifyPhoneReq?.md) |  | [optional]  |

### Return type

[**VerifyPhoneRes**](VerifyPhoneRes.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesecurityupdatephoneverifypatch"></a>
# **ProfileSecurityUpdatePhoneVerifyPatch**
> EmptyResponse ProfileSecurityUpdatePhoneVerifyPatch (ValidatePhoneVerificationReq? validatePhoneVerificationReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileSecurityUpdatePhoneVerifyPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileSecurityApi(config);
            var validatePhoneVerificationReq = new ValidatePhoneVerificationReq?(); // ValidatePhoneVerificationReq? |  (optional) 

            try
            {
                EmptyResponse result = apiInstance.ProfileSecurityUpdatePhoneVerifyPatch(validatePhoneVerificationReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePhoneVerifyPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileSecurityUpdatePhoneVerifyPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmptyResponse> response = apiInstance.ProfileSecurityUpdatePhoneVerifyPatchWithHttpInfo(validatePhoneVerificationReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileSecurityApi.ProfileSecurityUpdatePhoneVerifyPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validatePhoneVerificationReq** | [**ValidatePhoneVerificationReq?**](ValidatePhoneVerificationReq?.md) |  | [optional]  |

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

