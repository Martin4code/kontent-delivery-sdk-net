﻿using System;
using Kentico.Kontent.Delivery.Abstractions;

namespace Kentico.Kontent.Delivery.Caching
{
    /// <summary>
    /// Represents configuration of the <see cref="IDeliveryCacheManager"/>
    /// </summary>
    public class DeliveryCacheOptions
    {
        /// <summary>
        /// Gets or sets the default expiration time
        /// </summary>
        public TimeSpan DefaultExpiration { get; set; } = TimeSpan.FromMinutes(10);

        /// <summary>
        /// Gets or sets expiration time when the response is stale.
        /// </summary>
        public TimeSpan StaleContentExpiration { get; set; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// Determines whether to use <see cref="Microsoft.Extensions.Caching.Distributed.IDistributedCache" /> or <inheritdoc cref="Microsoft.Extensions.Caching.Memory.IMemoryCache"/>
        /// </summary>
        public CacheTypeEnum CacheType { get; set; } = CacheTypeEnum.Memory;

        /// <summary>
        /// Name of an <see cref="IDeliveryCacheManager"/> instance the options are bound to.
        /// </summary>
        internal string Name { get; set; }
    }
}
