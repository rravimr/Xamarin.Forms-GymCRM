using GymCRM.Core.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymCRM.Core.Persistance
{
    public class ContextAdapter : IContextAdapter
    {
        public IEfCoreContext Context { get; private set; } = EfCoreContextFactory.Create();

        public void RecreateContext()
        {
            Context.Dispose();
            Context = EfCoreContextFactory.Create();
        }
    }
}
