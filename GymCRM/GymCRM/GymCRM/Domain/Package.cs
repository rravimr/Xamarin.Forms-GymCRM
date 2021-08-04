using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GymCRM.Domain
{
    public class Package
    {
        private Package() { }

        public Package(string name, int months, double amount)
        {
            CreationTime = DateTime.Now;
            UpdateData(name, months, amount);
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [Required] public string Name { get; private set; } = "";

        [Required]
        public int Months { get; set; }


        [Required]
        public double Amount { get; set; }

        public DateTime ModificationDate { get; private set; }

        public DateTime CreationTime { get; private set; }

        public void UpdateData(string name, int months, double amount)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Months = months;
            Amount = amount;
            ModificationDate = DateTime.Now;
        }
    }
}
