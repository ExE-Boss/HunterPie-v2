﻿namespace HunterPie.UI.Overlay.Widgets.Activities.ViewModel
{
    internal class MockActivitiesViewModel : ActivitiesViewModel
    {
        public MockActivitiesViewModel()
        {
            var argosyActivity = new SubmarinesViewModel();
            argosyActivity.Submarines.Add(new SubmarineViewModel() { 
                Count = 12,
                MaxCount = 20,
                DaysLeft = 5,
                IsActive = true
            });
            argosyActivity.Submarines.Add(new SubmarineViewModel()
            {
                Count = 20,
                MaxCount = 20,
                DaysLeft = 0,
                IsActive = true
            });
            argosyActivity.Submarines.Add(new SubmarineViewModel()
            {
                Count = 0,
                MaxCount = 20,
                DaysLeft = 0,
                IsActive = false
            });

            Activities.Add(argosyActivity);

            var trainingDojoActivity = new TrainingDojoViewModel()
            {
                Boosts = 5,
                MaxBoosts = 10,
                Rounds = 5,
                MaxRounds = 10
            };
            trainingDojoActivity.Buddies.Add(
                new BuddyViewModel() 
                { 
                    IsEmpty = false, 
                    Level = 38, 
                    Name = "Poke" 
                }
            );
            trainingDojoActivity.Buddies.Add(
                new BuddyViewModel()
                {
                    IsEmpty = false,
                    Level = 31,
                    Name = "Pia"
                }
            );
            trainingDojoActivity.Buddies.Add(
                new BuddyViewModel()
                {
                    IsEmpty = false,
                    Level = 25,
                    Name = "Poggers"
                }
            );
            trainingDojoActivity.Buddies.Add(
                new BuddyViewModel()
                {
                    IsEmpty = false,
                    Level = 18,
                    Name = "Uwu"
                }
            );
            trainingDojoActivity.Buddies.Add(
                new BuddyViewModel()
                {
                    IsEmpty = true,
                }
            );
            trainingDojoActivity.Buddies.Add(
                new BuddyViewModel()
                {
                    IsEmpty = true,
                }
            );
            Activities.Add(trainingDojoActivity);

            
            InVisibleStage = true;
        }
    }
}
