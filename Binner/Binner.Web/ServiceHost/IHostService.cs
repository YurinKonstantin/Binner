﻿using System;
using Topshelf;

namespace Binner.Web.ServiceHost
{
    /// <summary>
    /// A host service
    /// </summary>
    public interface IHostService : ServiceControl
    {
        IServiceProvider ServiceProvider { get; }
    }
}
