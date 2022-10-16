# profile.wire.Api.InterestApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InterestForceUpdateCachePost**](InterestApi.md#interestforceupdatecachepost) | **POST** /Interest/ForceUpdateCache |  |
| [**InterestGet**](InterestApi.md#interestget) | **GET** /Interest |  |
| [**InterestPatch**](InterestApi.md#interestpatch) | **PATCH** /Interest |  |
| [**InterestPost**](InterestApi.md#interestpost) | **POST** /Interest |  |

<a name="interestforceupdatecachepost"></a>
# **InterestForceUpdateCachePost**
> EmptyResponse InterestForceUpdateCachePost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class InterestForceUpdateCachePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterestApi(config);

            try
            {
                EmptyResponse result = apiInstance.InterestForceUpdateCachePost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterestApi.InterestForceUpdateCachePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterestForceUpdateCachePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmptyResponse> response = apiInstance.InterestForceUpdateCachePostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterestApi.InterestForceUpdateCachePostWithHttpInfo: " + e.Message);
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

<a name="interestget"></a>
# **InterestGet**
> List&lt;InterestDto&gt; InterestGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class InterestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterestApi(config);

            try
            {
                List<InterestDto> result = apiInstance.InterestGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterestApi.InterestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<InterestDto>> response = apiInstance.InterestGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterestApi.InterestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;InterestDto&gt;**](InterestDto.md)

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

<a name="interestpatch"></a>
# **InterestPatch**
> EmptyResponse InterestPatch (InterestUpdateReq? interestUpdateReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class InterestPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterestApi(config);
            var interestUpdateReq = new InterestUpdateReq?(); // InterestUpdateReq? |  (optional) 

            try
            {
                EmptyResponse result = apiInstance.InterestPatch(interestUpdateReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterestApi.InterestPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterestPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmptyResponse> response = apiInstance.InterestPatchWithHttpInfo(interestUpdateReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterestApi.InterestPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **interestUpdateReq** | [**InterestUpdateReq?**](InterestUpdateReq?.md) |  | [optional]  |

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

<a name="interestpost"></a>
# **InterestPost**
> InterestDto InterestPost (AddInterestReq? addInterestReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class InterestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterestApi(config);
            var addInterestReq = new AddInterestReq?(); // AddInterestReq? |  (optional) 

            try
            {
                InterestDto result = apiInstance.InterestPost(addInterestReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterestApi.InterestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InterestDto> response = apiInstance.InterestPostWithHttpInfo(addInterestReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterestApi.InterestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addInterestReq** | [**AddInterestReq?**](AddInterestReq?.md) |  | [optional]  |

### Return type

[**InterestDto**](InterestDto.md)

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

