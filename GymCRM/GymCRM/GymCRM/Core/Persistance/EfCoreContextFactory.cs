using GymCRM.Core.Application.Common.Helpers;
using GymCRM.Core.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymCRM.Core.Persistance
{
    public static class EfCoreContextFactory
    {
        public static IEfCoreContext Create()
        {
            DbContextOptions<EfCoreContext> options = new DbContextOptionsBuilder<EfCoreContext>()
                                                     .UseSqlite($"Data Source={DatabasePathHelper.DbPath}")
                                                     .Options;

            var context = new EfCoreContext(options);
            context.Database.Migrate();
            return context;
        }
    }
}
