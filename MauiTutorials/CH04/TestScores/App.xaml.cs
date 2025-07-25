﻿using Microsoft.VisualBasic;

namespace TestScores
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Title = "My Score Calculator";
            return window;
        }
    }
}