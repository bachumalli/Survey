using System;
using ObjCRuntime;
[Native]
public enum CreativeType : long
{
    Notification = 0,
    PopOver = 1,
    EmbeddedFeedback = 2
}

[Native]
public enum targetingResultStatus : long
{
    Passed = 0,
    FailedLogic = 1,
    SampledOut = 2,
    MultipleDisplayPrevented = 3,
    Error = 4,
    Inactive = 5,
    ContactFrequencyFailed = 6
}


