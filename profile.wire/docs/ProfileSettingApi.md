# profile.wire.Api.ProfileSettingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProfileSettingUpdateProfileSettingPatch**](ProfileSettingApi.md#profilesettingupdateprofilesettingpatch) | **PATCH** /ProfileSetting/UpdateProfileSetting |  |

<a name="profilesettingupdateprofilesettingpatch"></a>
# **ProfileSettingUpdateProfileSettingPatch**
> EmptyResponse ProfileSettingUpdateProfileSettingPatch (UpdateProfileSettingReq? updateProfileSettingReq = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using profile.wire.Api;
using profile.wire.Client;
using profile.wire.Model;

namespace Example
{
    public class ProfileSettingUpdateProfileSettingPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileSettingApi(config);
            var updateProfileSettingReq = new UpdateProfileSettingReq?(); // UpdateProfileSettingReq? |  (optional) 

            try
            {
                EmptyResponse result = apiInstance.ProfileSettingUpdateProfileSettingPatch(updateProfileSettingReq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileSettingApi.ProfileSettingUpdateProfileSettingPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileSettingUpdateProfileSettingPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmptyResponse> response = apiInstance.ProfileSettingUpdateProfileSettingPatchWithHttpInfo(updateProfileSettingReq);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileSettingApi.ProfileSettingUpdateProfileSettingPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateProfileSettingReq** | [**UpdateProfileSettingReq?**](UpdateProfileSettingReq?.md) |  | [optional]  |

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

