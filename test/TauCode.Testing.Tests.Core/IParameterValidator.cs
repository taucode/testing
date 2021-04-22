using System.Collections.Generic;

namespace TauCode.Testing.Tests.Core
{
    public interface IParameterValidator
    {
        IDictionary<string, object> Parameters { get; set; }
    }
}
