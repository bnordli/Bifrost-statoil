﻿using System;
using Bifrost.Reflection;

namespace Bifrost.Client.Specs.Reflection.for_InvocationHandler
{
    public abstract class ImplementationNeedingTargetInstance : Interface, INeedTargetInstance
    {
        public abstract string Something { get; set; }

        public abstract string DoSomething(int value, string message);

        public abstract Interface TargetInstance { get; set; }
    }
}
