using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymCRM.Core.Domain.Commands
{
    public class CreatePackageCommand : IRequest
    {
        public CreatePackageCommand(string name, int months , double amount)
        {
            Name = name;
            Months = months;
            Amount = amount;
        }

        public string Name { get; }
        public int Months { get; }
        public double Amount { get; }
    }

}
