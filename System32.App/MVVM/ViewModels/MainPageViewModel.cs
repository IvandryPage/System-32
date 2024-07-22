using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System32.App.MVVM.Models;

namespace System32.App.MVVM.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Quest mainQuest;

        [ObservableProperty]
        private User mainUser;
        
        [ObservableProperty]
        private ObservableCollection<SubQuestViewModel> subQuests;

        public MainPageViewModel()
        {
            MockDataUser();
            MockDataQuest();
        }

        private void MockDataUser()
        {
            mainUser = new User()
            {
                Id = 1,
                Name = "Daniel the Johnny",
                Health = 10,
                Charisma = 5,
                Intelligence = 10
            };
        }

        private void MockDataQuest()
        {
            // Harusnya punya banyak quest yang nantinya di randomize setiap 1 hari sekali
            mainQuest = new Quest()
            {
                 Title = "Quest Title Numbawan",
                 Description = "Test for Quest Model on View Model",
                 SubQuests = new List<SubQuest>() 
                 { 
                     new SubQuest()
                     {
                         Detail = "Sub Quest 1",
                         Target = 10
                     },
                     new SubQuest()
                     {
                         Detail = "Sub Quest 2",
                         Target = 20
                     },
                     new SubQuest()
                     {
                         Detail = "Sub Quest 3",
                         Target = 30
                     },
                 },
                 StatusReward = new Dictionary<string, int>()
                 {
                     {"Health", 1 },
                     {"Intelligence", 2 },
                     {"Charisma", 3 },
                 }
            };

            SubQuests = new ObservableCollection<SubQuestViewModel>();

            foreach(var subQuest in MainQuest.SubQuests)
            {
                SubQuests.Add(new SubQuestViewModel(subQuest));
            }
        }
    }
}
