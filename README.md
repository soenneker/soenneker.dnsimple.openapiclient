[![](https://img.shields.io/nuget/v/soenneker.dnsimple.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dnsimple.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dnsimple.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dnsimple.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dnsimple.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dnsimple.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dnsimple.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dnsimple.openapiclient/actions/workflows/codeql.yml)

# Soenneker.DNSimple.OpenApiClient

A generated .NET client for DNSimple's accounts, domains, DNS records, registrar, contacts, certificates, services, templates, TLDs, and identity APIs.

## Installation

```bash
dotnet add package Soenneker.DNSimple.OpenApiClient
```

## Create the client directly

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.DNSimple.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiToken);

var authentication = new AnonymousAuthenticationProvider();
using var adapter = new HttpClientRequestAdapter(authentication, httpClient: httpClient);
var client = new DNSimpleOpenApiClient(adapter);

var identity = await client.Whoami.GetAsync(cancellationToken: cancellationToken);
```

The generated client defaults to `https://api.dnsimple.com/v2`. Set `adapter.BaseUrl` to `https://api.sandbox.dnsimple.com/v2` before constructing the client when using sandbox credentials.

Account-scoped endpoints are selected with the root indexer, for example `client[accountId].Domains`. Request and response types live in `Soenneker.DNSimple.OpenApiClient.Models`, and generated endpoint methods accept request-configuration callbacks and cancellation tokens.

For managed transport reuse and configuration, use `Soenneker.DNSimple.OpenApiClientUtil`. Higher-level packages such as `Soenneker.DNSimple.Domains`, `Soenneker.DNSimple.Registrar`, and `Soenneker.DNSimple.Contacts` wrap common operations.

This repository contains generated source. Keep application-specific behavior in wrapper services or separate partial-class files because regeneration can replace generated files.
