# profile.wire.Api.AdminAuthApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdminAuthLoginPost**](AdminAuthApi.md#adminauthloginpost) | **POST** /AdminAuth/Login |  |
| [**AdminAuthRefreshTokenPost**](AdminAuthApi.md#adminauthrefreshtokenpost) | **POST** /AdminAuth/RefreshToken |  |

<a name="adminauthloginpost"></a>
# **AdminAuthLoginPost**
> LoginRes AdminAuthLoginPost (EmailPasswordLoginReq? emailPasswordLoginReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class AdminAuthLoginPostExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminAuthApi.AdminAuthLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdminAuthLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoginRes> response = apiInstance.AdminAuthLoginPostWithHttpInfo(emailPasswordLoginReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminAuthApi.AdminAuthLoginPostWithHttpInfo: " + e.Message);
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

<a name="adminauthrefreshtokenpost"></a>
# **AdminAuthRefreshTokenPost**
> LoginRes AdminAuthRefreshTokenPost (RefreshTokenReq? refreshTokenReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class AdminAuthRefreshTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdminAuthApi(config);
            var refreshTokenReq = new RefreshTokenReq?(); // RefreshTokenReq? |  (optional) 

            try
            {
                LoginRes result = apiInstance.AdminAuthRefreshTokenPost(refreshTokenReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminAuthApi.AdminAuthRefreshTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdminAuthRefreshTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoginRes> response = apiInstance.AdminAuthRefreshTokenPostWithHttpInfo(refreshTokenReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminAuthApi.AdminAuthRefreshTokenPostWithHttpInfo: " + e.Message);
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

