# profile.wire.Api.AssistantListingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssistantListingListingPost**](AssistantListingApi.md#assistantlistinglistingpost) | **POST** /AssistantListing/Listing |  |
| [**AssistantListingUserListingPost**](AssistantListingApi.md#assistantlistinguserlistingpost) | **POST** /AssistantListing/UserListing |  |

<a name="assistantlistinglistingpost"></a>
# **AssistantListingListingPost**
> AssistantListingRes AssistantListingListingPost (AssistantListingReq? assistantListingReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class AssistantListingListingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AssistantListingApi(config);
            var assistantListingReq = new AssistantListingReq?(); // AssistantListingReq? |  (optional) 

            try
            {
                AssistantListingRes result = apiInstance.AssistantListingListingPost(assistantListingReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssistantListingApi.AssistantListingListingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssistantListingListingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssistantListingRes> response = apiInstance.AssistantListingListingPostWithHttpInfo(assistantListingReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssistantListingApi.AssistantListingListingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assistantListingReq** | [**AssistantListingReq?**](AssistantListingReq?.md) |  | [optional]  |

### Return type

[**AssistantListingRes**](AssistantListingRes.md)

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

<a name="assistantlistinguserlistingpost"></a>
# **AssistantListingUserListingPost**
> AssistantListingRes AssistantListingUserListingPost (AssistantListingReq? assistantListingReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class AssistantListingUserListingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AssistantListingApi(config);
            var assistantListingReq = new AssistantListingReq?(); // AssistantListingReq? |  (optional) 

            try
            {
                AssistantListingRes result = apiInstance.AssistantListingUserListingPost(assistantListingReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssistantListingApi.AssistantListingUserListingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssistantListingUserListingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssistantListingRes> response = apiInstance.AssistantListingUserListingPostWithHttpInfo(assistantListingReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssistantListingApi.AssistantListingUserListingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assistantListingReq** | [**AssistantListingReq?**](AssistantListingReq?.md) |  | [optional]  |

### Return type

[**AssistantListingRes**](AssistantListingRes.md)

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

