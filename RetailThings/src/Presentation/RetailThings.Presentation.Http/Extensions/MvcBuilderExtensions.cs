// <copyright file="MvcBuilderExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThings.Presentation.Http.Extensions;

#pragma warning disable
public static class MvcBuilderExtensions
{
    public static IMvcBuilder AddPresentationHttp(this IMvcBuilder builder)
    {
        return builder.AddApplicationPart(typeof(IAssemblyMarker).Assembly);
    }
}