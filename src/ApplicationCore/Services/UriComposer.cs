using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;

namespace Microsoft.eShopWeb.ApplicationCore.Services;

public class UriComposer : IUriComposer
{
    private readonly CatalogSettings _catalogSettings;

    public UriComposer(CatalogSettings catalogSettings) => _catalogSettings = catalogSettings;

    public string ComposePicUri(string uriTemplate)
    {
        // PI - Modified to use environment variable
        return uriTemplate.Replace("http://catalogbaseurltobereplaced", Environment.GetEnvironmentVariable("CATALOG_BASE_URL"));
    }
}
