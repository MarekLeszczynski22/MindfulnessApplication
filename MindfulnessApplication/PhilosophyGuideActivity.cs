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
    [Activity(Label = "@string/philosophyGuide")]
    public class PhilosophyGuideActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.philosophyGuideLayout);

            Button absurdism = FindViewById<Button>(Resource.Id.absurdism);
            absurdism.Click += delegate { StartActivity(typeof(AbsurdismActivity)); };

            Button digitalMinimalism = FindViewById<Button>(Resource.Id.digitalminimalism);
            digitalMinimalism.Click += delegate { StartActivity(typeof(DigitalMinimalismActivity)); };

            // Create your application here
        }
    }
}