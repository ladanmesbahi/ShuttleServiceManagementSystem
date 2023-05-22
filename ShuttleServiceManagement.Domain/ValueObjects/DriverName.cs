﻿using ShuttleServiceManagement.Domain.Errors;
using ShuttleServiceManagement.Domain.Infrastructure;
using ShuttleServiceManagement.Domain.Shared;

namespace ShuttleServiceManagement.Domain.ValueObjects
{
    public sealed class DriverName : ValueObject
    {
        public const int MaxLength = 50;
        public string Value { get; }

        private DriverName(string value)
        {
            Value = value;
        }
        public static Result<DriverName> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return Result.Failure<DriverName>(DomainErrors.DriverName.Empty);
            if (value.Length > MaxLength)
                return Result.Failure<DriverName>(DomainErrors.DriverName.MaxLength);
            return new DriverName(value);
        }
        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
