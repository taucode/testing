using FluentValidation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using TauCode.Testing.Tests.Core.Validators;

namespace TauCode.Testing.Tests.Core.Features.SystemWatchers.GetSystemWatcher
{
    public class GetSystemWatcherQueryValidator : SinglePropertyValidator<GetSystemWatcherQuery>
    {
        public GetSystemWatcherQueryValidator()
            : base(new Dictionary<string, IPropertyValidator>
            {
                { nameof(GetSystemWatcherQuery.Id), new LongIdValidator<GetSystemWatcherQuery>() },
                { nameof(GetSystemWatcherQuery.Guid), new NullableNotEmptyValidator<GetSystemWatcherQuery, Guid>() },
                { nameof(GetSystemWatcherQuery.Code), new SystemWatcherCodeValidator<GetSystemWatcherQuery>() },
            })
        {
            this.CascadeMode = CascadeMode.Stop;
        }
    }
}
