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
        // fungsi main page : display main quest dan juga display seluruh data tentang user
        [ObservableProperty]
        private Quest mainQuest;
        [ObservableProperty]
        private User mainUser;

        public MainPageViewModel()
        {
            // Bikin mock data dulu nggak sih
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
                 SubQuest = new List<string>() 
                 { 
                     "Sub-Quest 1", 
                     "Sub-Quest 2" 
                 },
                 StatusReward = new Dictionary<string, int>()
                 {
                     {"Health", 1 },
                     {"Intelligence", 2 },
                     {"Charisma", 3 },
                 }
            };
        }
    }
}
