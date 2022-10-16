# profile.wire.Api.ProfileApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProfileCanBeAssistantGet**](ProfileApi.md#profilecanbeassistantget) | **GET** /Profile/CanBeAssistant |  |
| [**ProfileConvertToAssistantPost**](ProfileApi.md#profileconverttoassistantpost) | **POST** /Profile/ConvertToAssistant |  |
| [**ProfileMeGet**](ProfileApi.md#profilemeget) | **GET** /Profile/Me |  |
| [**ProfileProfileIdGet**](ProfileApi.md#profileprofileidget) | **GET** /Profile/{profileId} |  |
| [**ProfileUpdateInterestsPost**](ProfileApi.md#profileupdateinterestspost) | **POST** /Profile/UpdateInterests |  |
| [**ProfileUpdateProfilePatch**](ProfileApi.md#profileupdateprofilepatch) | **PATCH** /Profile/UpdateProfile |  |
| [**ProfileUploadAvatarPatch**](ProfileApi.md#profileuploadavatarpatch) | **PATCH** /Profile/UploadAvatar |  |

<a name="profilecanbeassistantget"></a>
# **ProfileCanBeAssistantGet**
> CanBeAssistantRes ProfileCanBeAssistantGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileCanBeAssistantGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);

            try
            {
                CanBeAssistantRes result = apiInstance.ProfileCanBeAssistantGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ProfileCanBeAssistantGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileCanBeAssistantGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CanBeAssistantRes> response = apiInstance.ProfileCanBeAssistantGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ProfileCanBeAssistantGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CanBeAssistantRes**](CanBeAssistantRes.md)

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

<a name="profileconverttoassistantpost"></a>
# **ProfileConvertToAssistantPost**
> EmptyResponse ProfileConvertToAssistantPost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileConvertToAssistantPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);

            try
            {
                EmptyResponse result = apiInstance.ProfileConvertToAssistantPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ProfileConvertToAssistantPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileConvertToAssistantPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmptyResponse> response = apiInstance.ProfileConvertToAssistantPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ProfileConvertToAssistantPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EmptyResponse**](EmptyResponse.md)

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

<a name="profilemeget"></a>
# **ProfileMeGet**
> ProfileDto ProfileMeGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileMeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);

            try
            {
                ProfileDto result = apiInstance.ProfileMeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ProfileMeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileMeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProfileDto> response = apiInstance.ProfileMeGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ProfileMeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ProfileDto**](ProfileDto.md)

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

<a name="profileprofileidget"></a>
# **ProfileProfileIdGet**
> ProfileDto ProfileProfileIdGet (string profileId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileProfileIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var profileId = "profileId_example";  // string | 

            try
            {
                ProfileDto result = apiInstance.ProfileProfileIdGet(profileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ProfileProfileIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileProfileIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProfileDto> response = apiInstance.ProfileProfileIdGetWithHttpInfo(profileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ProfileProfileIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |

### Return type

[**ProfileDto**](ProfileDto.md)

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

<a name="profileupdateinterestspost"></a>
# **ProfileUpdateInterestsPost**
> ProfileDto ProfileUpdateInterestsPost (UpdateInterestsReq? updateInterestsReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileUpdateInterestsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var updateInterestsReq = new UpdateInterestsReq?(); // UpdateInterestsReq? |  (optional) 

            try
            {
                ProfileDto result = apiInstance.ProfileUpdateInterestsPost(updateInterestsReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ProfileUpdateInterestsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileUpdateInterestsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProfileDto> response = apiInstance.ProfileUpdateInterestsPostWithHttpInfo(updateInterestsReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ProfileUpdateInterestsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateInterestsReq** | [**UpdateInterestsReq?**](UpdateInterestsReq?.md) |  | [optional]  |

### Return type

[**ProfileDto**](ProfileDto.md)

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

<a name="profileupdateprofilepatch"></a>
# **ProfileUpdateProfilePatch**
> ProfileDto ProfileUpdateProfilePatch (UpdateProfileReq? updateProfileReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileUpdateProfilePatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var updateProfileReq = new UpdateProfileReq?(); // UpdateProfileReq? |  (optional) 

            try
            {
                ProfileDto result = apiInstance.ProfileUpdateProfilePatch(updateProfileReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ProfileUpdateProfilePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileUpdateProfilePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProfileDto> response = apiInstance.ProfileUpdateProfilePatchWithHttpInfo(updateProfileReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ProfileUpdateProfilePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateProfileReq** | [**UpdateProfileReq?**](UpdateProfileReq?.md) |  | [optional]  |

### Return type

[**ProfileDto**](ProfileDto.md)

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

<a name="profileuploadavatarpatch"></a>
# **ProfileUploadAvatarPatch**
> ProfileDto ProfileUploadAvatarPatch (System.IO.Stream? file = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileUploadAvatarPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                ProfileDto result = apiInstance.ProfileUploadAvatarPatch(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ProfileUploadAvatarPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileUploadAvatarPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProfileDto> response = apiInstance.ProfileUploadAvatarPatchWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ProfileUploadAvatarPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

### Return type

[**ProfileDto**](ProfileDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

