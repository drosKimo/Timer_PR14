using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Timer_PR14
{
    public partial class MainPage : ContentPage
    {
        bool alive = true;
        private DateTime StartTime;
        public MainPage()
        {
            InitializeComponent();

            timerButton.Clicked += TimerButton_Clicked;

            StartTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(0), OnTimerTick);
        }

        private bool OnTimerTick()
        {
            TimerText.Text = (DateTime.Now - StartTime).ToString(@"hh':'mm':'ss'.'f");
            return alive;
        }

        private void TimerButton_Clicked(object sender, EventArgs e)
        {
            if (alive == true)
            {
                alive = false;
            }
            else
            {
                alive = true;
                StartTime = DateTime.Now;
                Device.StartTimer(TimeSpan.FromSeconds(0), OnTimerTick);
            }
        }
    }
}
