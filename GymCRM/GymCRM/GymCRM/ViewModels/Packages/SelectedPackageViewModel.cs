using GalaSoft.MvvmLight;
using GymCRM.Core.Application.Common.Interfaces;
using GymCRM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymCRM.ViewModels
{
    public class SelectedPackageViewModel : ViewModelBase, IMapFrom<Package>
    {

        private int id;
        private string name = "";
        private int months;
        private double amount;
        private DateTime creationTime;
        private DateTime modificationDate;

        public int Id
        {
            get => id;
            set
            {
                if (id == value)
                {
                    return;
                }

                id = value;
                RaisePropertyChanged();
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (name == value)
                {
                    return;
                }

                name = value;
                RaisePropertyChanged();
            }
        }

        public int Months
        {
            get => months;
            set
            {
                if (months == value)
                {
                    return;
                }

                months = value;
                RaisePropertyChanged();
            }
        }

        public DateTime CreationTime
        {
            get => creationTime;
            set
            {
                if (creationTime == value)
                {
                    return;
                }

                creationTime = value;
                RaisePropertyChanged();
            }
        }

        public DateTime ModificationDate
        {
            get => modificationDate;
            set
            {
                if (modificationDate == value)
                {
                    return;
                }

                modificationDate = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Additional details about the CategoryViewModel
        /// </summary>
        public double Amount
        {
            get => amount;
            set
            {
                if (amount == value)
                {
                    return;
                }

                amount = value;
                RaisePropertyChanged();
            }
        }
    }
}
