using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System32.App.MVVM.Models
{
    public class Quest
    {
        // Quest pastinya punya judul, deskripsi, sub-task yang harus dikerjakan satu-satu, reward penambahan status user, 

        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> SubQuest { get; set; } // Perlu ekspansi ke model baru? sebuah subQuest memiliki target dan juga progress yang telah dilakukan user? atau User memiliki List<int> QuestProgresses?
        public Dictionary<string, int> StatusReward { get; set; }
    }
}
