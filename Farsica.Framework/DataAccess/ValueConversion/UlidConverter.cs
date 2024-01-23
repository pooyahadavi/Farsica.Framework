﻿namespace Farsica.Framework.DataAccess.ValueConversion
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
    using NUlid;

    public class UlidConverter : ValueConverter<Ulid, string>
    {
        private static readonly Expression<Func<string, Ulid>> Deserialize = t => new Ulid(t);

        private static readonly Expression<Func<Ulid, string>> Serialize = t => t.ToString();

        public UlidConverter()
            : base(Serialize, Deserialize, null)
        {
        }
    }
}
