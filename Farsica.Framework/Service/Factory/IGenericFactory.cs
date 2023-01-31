﻿namespace Farsica.Framework.Service.Factory
{
    using Farsica.Framework.Data.Enumeration;

    [DataAnnotation.Injectable]
    public interface IGenericFactory<TProvider, TProviderType>
        where TProvider : IProvider<TProviderType>
        where TProviderType : Enumeration<byte>
    {
        TProvider GetProvider(TProviderType providerType, bool returnFirstItemIfNotMatch = true);
    }
}
