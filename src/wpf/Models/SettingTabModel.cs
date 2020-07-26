using System.Collections.Generic;
using System.Collections.ObjectModel;
using Mitheti.Core;

namespace Mitheti.Wpf.Models
{
    public sealed class SettingTabModel
    {
        public Dictionary<string, string> Localization { get; set; }

        public List<NumberRangeSetting> NumberRangeSettingsList { get; set; }
        public bool FilterMode { get; set; }
        public ObservableCollection<string> FilterList { get; set; }

        public TimePeriod ClearSetting { get; set; }
        public string ClearButtonLabel { get; set; }
    }
}