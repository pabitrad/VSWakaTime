﻿// Guids.cs
// MUST match guids.h
using System;

namespace Wakatime.VSPackageWakaTime
{
    static class GuidList
    {
        public const string guidVSPackageWakaTimePkgString = "52d9c3ff-c893-408e-95e4-d7484ec7fa47";
        public const string guidVSPackageWakaTimeCmdSetString = "054caf12-7fba-40d1-8dc8-bd69f838b910";

        public static readonly Guid guidVSPackageWakaTimeCmdSet = new Guid(guidVSPackageWakaTimeCmdSetString);
    };
}