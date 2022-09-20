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
    [Activity(Label = "DailyChallengesActivity")]
    public class DailyChallengesActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.dailyChallengesActivity);

            List<String> randomChallenge = new List<String>(new string[]
                {"Leave your phone at home, and go for a 30 minute walk",
                 "Do the Mindfulness Exercise from the Home Page",
                 "Read 20 pages of your choosen book",
                 "30 minutes of deep focused work",
                 "Read a chapter on chosen philosophy from Philosophy Guide",});

            TextView challenge = FindViewById<TextView>(Resource.Id.dailyChallengesText);

            Random rnd = new Random();
            challenge.Text = randomChallenge[rnd.Next(randomChallenge.Count)];



            // Create your application here
        }
    }
}