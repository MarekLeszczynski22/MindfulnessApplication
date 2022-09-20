using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MindfulnessApplication
{
    [Activity(Label = "MindfulnessExerciseActivity")]
    public class MindfulnessExerciseActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.mindfulnessExerciseLayout);

            TextView wecolemeText = FindViewById<TextView>(Resource.Id.mindfulnessExercise);
            wecolemeText.Text = "Hello user, welcome to your daily mindfulness practice exercise, please relax and follow the instructions below. Whenever you are ready, start below timer and focus on deep and regular breaths, with deep breath in and out";

        }
    }
}