using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GymCRM.Core.Application.Common.Helpers
{
    public static class DatabasePathHelper
    {

        private const string DATABASE_NAME = "GYMCRM.db";

        public static string DbPath
        {
            get
            {
                string databasePath;
                switch (ExecutingPlatform.Current)
                {
                    case AppPlatform.Android:
                        databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), DATABASE_NAME);
                        break;

                    case AppPlatform.UWP:
                        databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME);
                        break;

                    default:
                        throw new NotSupportedException("Platform not supported");
                }

                return databasePath;
            }
        }
    }
}
