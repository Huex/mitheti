using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace Mitheti.Core.Services
{
    public class FilterApp : IFilterApp
    {
        public const string AppListConfigKey = "applist";

        private readonly ISavingService _database;
        private readonly List<string> _appList;

        public FilterApp(IConfiguration config, ISavingService database)
        {
            _database = database;

            _appList = GetList<string>(config, AppListConfigKey);
        }

        private List<T> GetList<T>(IConfiguration config, string key) => config.GetSection(key).Get<T[]>()?.ToList();

        private bool ShouldAddToDatabase(string app) => (app != null) && (_appList.Count == 0 || _appList.Contains(app));

        public void Add(string app, int delay)
        {
            if (ShouldAddToDatabase(app))
            {
                _database.Add(new AppTimeModel(app, delay, DateTime.Now));
            }
        }
    }
}