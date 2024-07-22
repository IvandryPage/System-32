using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System32.App.MVVM.Models
{
    public class SubQuest
    {
        public string Detail { get; set; }
        public int Target { get; set; }
        public int Progress { get; set; } = 0;
        public bool Done { get; set; }
    }
}
