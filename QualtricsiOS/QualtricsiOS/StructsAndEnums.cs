using System;
using ObjCRuntime;

namespace QualtricsiOS
{
    [Native]
    public enum TargetingResultStatus : long
    {
        Passed = 0,
        FailedLogic = 1,
        SampledOut = 2,
        MultipleDisplayPrevented = 3,
        Error = 4
    }
}
