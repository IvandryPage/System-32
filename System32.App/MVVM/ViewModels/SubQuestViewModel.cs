using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System32.App.MVVM.Models;

namespace System32.App.MVVM.ViewModels
{
    public partial class SubQuestViewModel : ObservableObject
    {
        private readonly SubQuest _subQuest;

        public string Name => _subQuest.Detail;
        public string Target => _subQuest.Target.ToString();

        [ObservableProperty]
        private int progress;
        [ObservableProperty]
        private bool done;

        public SubQuestViewModel(SubQuest subQuest)
        {
            _subQuest = subQuest;
            Progress = _subQuest.Progress;
            done = _subQuest.Done;
        }

        [RelayCommand]
        private void AddProgress () 
        {
            Progress += 1;
            if (Progress == Convert.ToInt32(Target))
            {
                Done = true; // write to database
            }
        }
    }
}
