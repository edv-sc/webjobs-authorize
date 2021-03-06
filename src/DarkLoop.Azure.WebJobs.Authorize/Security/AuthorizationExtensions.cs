﻿using System;
using System.Collections.Generic;
using System.Text;
using DarkLoop.Azure.WebJobs.Authorize.Bindings;
using DarkLoop.Azure.WebJobs.Authorize.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AuthorizationExtensions
    {
        public static IWebJobsBuilder AddAuthorization(this IWebJobsBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Services.AddAuthorization();
            return builder;
        }

        public static IWebJobsBuilder AddAuthorization(this IWebJobsBuilder builder, Action<AuthorizationOptions> configure)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            if (configure == null)
            {
                throw new ArgumentNullException(nameof(configure));
            }

            builder.Services.Configure(configure);
            return builder.AddAuthorization();
        }
    }
}
