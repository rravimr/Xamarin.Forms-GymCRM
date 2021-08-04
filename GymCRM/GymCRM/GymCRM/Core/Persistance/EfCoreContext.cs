using GymCRM.Core.Application.Common.Interfaces;
using GymCRM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymCRM.Core.Persistance
{
    public class EfCoreContext : DbContext, IEfCoreContext
    {
        public EfCoreContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Package> Packages { get; set; }
    }
}
