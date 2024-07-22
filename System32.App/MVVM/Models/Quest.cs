using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System32.App.MVVM.Models
{
    public class Quest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SubQuest> SubQuests { get; set; }
        public Dictionary<string, int> StatusReward { get; set; }
    }
}
