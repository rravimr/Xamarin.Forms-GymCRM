using System;
using System.Collections.Generic;
using System.Text;

namespace GymCRM.Core.Application.Common.Interfaces
{
    public interface IContextAdapter
    {
        IEfCoreContext Context { get; }

        void RecreateContext();
    }
}
