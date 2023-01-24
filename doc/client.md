
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `ApiKey` | `string` | *Default*: `"S36VNES3R5jDxeBwfdVeWvqKUQoWem8l"` |

The API client can be initialized as follows:

```csharp
PetstoreBooksAPI.Standard.PetstoreBooksAPIClient client = new PetstoreBooksAPI.Standard.PetstoreBooksAPIClient.Builder()
    .CustomQueryAuthenticationCredentials("S36VNES3R5jDxeBwfdVeWvqKUQoWem8l")
    .Environment(PetstoreBooksAPI.Standard.Environment.Production)
    .HttpClientConfig(config => config.NumberOfRetries(0))
    .Build();
```

## Petstore & Books APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| APIController | Gets APIController controller. |
| PetController | Gets PetController controller. |
| StoreController | Gets StoreController controller. |
| UserController | Gets UserController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Petstore & Books APIClient using the values provided for the builder. | `Builder` |

## Petstore & Books APIClient Builder Class

Class to build instances of Petstore & Books APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |

