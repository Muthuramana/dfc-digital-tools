﻿using Autofac;

namespace DFC.Digital.Tools.Core
{
    public static class AutofacExtensions
    {
        public static RunMode RunningMode(this ContainerBuilder builder)
        {
            object runMode = RunMode.Azure;
            builder?.Properties.TryGetValue(nameof(RunMode), out runMode);
            return (RunMode)runMode;
        }
    }
}
