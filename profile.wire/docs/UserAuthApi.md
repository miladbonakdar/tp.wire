# profile.wire.Api.UserAuthApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserAuthGoogleLoginPost**](UserAuthApi.md#userauthgoogleloginpost) | **POST** /UserAuth/GoogleLogin |  |
| [**UserAuthLoginPost**](UserAuthApi.md#userauthloginpost) | **POST** /UserAuth/Login |  |
| [**UserAuthOtpLoginRequestPost**](UserAuthApi.md#userauthotploginrequestpost) | **POST** /UserAuth/OtpLoginRequest |  |
| [**UserAuthOtpLoginValidatePost**](UserAuthApi.md#userauthotploginvalidatepost) | **POST** /UserAuth/OtpLoginValidate |  |
| [**UserAuthRefreshTokenPost**](UserAuthApi.md#userauthrefreshtokenpost) | **POST** /UserAuth/RefreshToken |  |
| [**UserAuthRegisterPost**](UserAuthApi.md#userauthregisterpost) | **POST** /UserAuth/Register |  |

<a name="userauthgoogleloginpost"></a>
# **UserAuthGoogleLoginPost**
> LoginRes UserAuthGoogleLoginPost (RefreshTokenReq? refreshTokenReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class UserAuthGoogleLoginPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserAuthApi(config);
            var refreshTokenReq = new RefreshTokenReq?(); // RefreshTokenReq? |  (optional) 

            try
            {
                LoginRes result = apiInstance.UserAuthGoogleLoginPost(refreshTokenReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAuthApi.UserAuthGoogleLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAuthGoogleLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoginRes> response = apiInstance.UserAuthGoogleLoginPostWithHttpInfo(refreshTokenReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAuthApi.UserAuthGoogleLoginPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refreshTokenReq** | [**RefreshTokenReq?**](RefreshTokenReq?.md) |  | [optional]  |

### Return type

[**LoginRes**](LoginRes.md)

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

<a name="userauthloginpost"></a>
# **UserAuthLoginPost**
> LoginRes UserAuthLoginPost (EmailPasswordLoginReq? emailPasswordLoginReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class UserAuthLoginPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserAuthApi(config);
            var emailPasswordLoginReq = new EmailPasswordLoginReq?(); // EmailPasswordLoginReq? |  (optional) 

            try
            {
                LoginRes result = apiInstance.UserAuthLoginPost(emailPasswordLoginReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAuthApi.UserAuthLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAuthLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoginRes> response = apiInstance.UserAuthLoginPostWithHttpInfo(emailPasswordLoginReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAuthApi.UserAuthLoginPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailPasswordLoginReq** | [**EmailPasswordLoginReq?**](EmailPasswordLoginReq?.md) |  | [optional]  |

### Return type

[**LoginRes**](LoginRes.md)

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

<a name="userauthotploginrequestpost"></a>
# **UserAuthOtpLoginRequestPost**
> OtpRequestRes UserAuthOtpLoginRequestPost (OtpLoginReq? otpLoginReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class UserAuthOtpLoginRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserAuthApi(config);
            var otpLoginReq = new OtpLoginReq?(); // OtpLoginReq? |  (optional) 

            try
            {
                OtpRequestRes result = apiInstance.UserAuthOtpLoginRequestPost(otpLoginReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAuthApi.UserAuthOtpLoginRequestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAuthOtpLoginRequestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OtpRequestRes> response = apiInstance.UserAuthOtpLoginRequestPostWithHttpInfo(otpLoginReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAuthApi.UserAuthOtpLoginRequestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **otpLoginReq** | [**OtpLoginReq?**](OtpLoginReq?.md) |  | [optional]  |

### Return type

[**OtpRequestRes**](OtpRequestRes.md)

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

<a name="userauthotploginvalidatepost"></a>
# **UserAuthOtpLoginValidatePost**
> LoginRes UserAuthOtpLoginValidatePost (OtpLoginValidateReq? otpLoginValidateReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class UserAuthOtpLoginValidatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserAuthApi(config);
            var otpLoginValidateReq = new OtpLoginValidateReq?(); // OtpLoginValidateReq? |  (optional) 

            try
            {
                LoginRes result = apiInstance.UserAuthOtpLoginValidatePost(otpLoginValidateReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAuthApi.UserAuthOtpLoginValidatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAuthOtpLoginValidatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoginRes> response = apiInstance.UserAuthOtpLoginValidatePostWithHttpInfo(otpLoginValidateReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAuthApi.UserAuthOtpLoginValidatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **otpLoginValidateReq** | [**OtpLoginValidateReq?**](OtpLoginValidateReq?.md) |  | [optional]  |

### Return type

[**LoginRes**](LoginRes.md)

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

<a name="userauthrefreshtokenpost"></a>
# **UserAuthRefreshTokenPost**
> LoginRes UserAuthRefreshTokenPost (RefreshTokenReq? refreshTokenReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class UserAuthRefreshTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserAuthApi(config);
            var refreshTokenReq = new RefreshTokenReq?(); // RefreshTokenReq? |  (optional) 

            try
            {
                LoginRes result = apiInstance.UserAuthRefreshTokenPost(refreshTokenReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAuthApi.UserAuthRefreshTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAuthRefreshTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoginRes> response = apiInstance.UserAuthRefreshTokenPostWithHttpInfo(refreshTokenReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAuthApi.UserAuthRefreshTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refreshTokenReq** | [**RefreshTokenReq?**](RefreshTokenReq?.md) |  | [optional]  |

### Return type

[**LoginRes**](LoginRes.md)

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

<a name="userauthregisterpost"></a>
# **UserAuthRegisterPost**
> LoginRes UserAuthRegisterPost (UserRegisterReq? userRegisterReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class UserAuthRegisterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserAuthApi(config);
            var userRegisterReq = new UserRegisterReq?(); // UserRegisterReq? |  (optional) 

            try
            {
                LoginRes result = apiInstance.UserAuthRegisterPost(userRegisterReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAuthApi.UserAuthRegisterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAuthRegisterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoginRes> response = apiInstance.UserAuthRegisterPostWithHttpInfo(userRegisterReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAuthApi.UserAuthRegisterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userRegisterReq** | [**UserRegisterReq?**](UserRegisterReq?.md) |  | [optional]  |

### Return type

[**LoginRes**](LoginRes.md)

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

