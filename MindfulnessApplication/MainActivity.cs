using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace MindfulnessApplication
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button philosophyGuideButton = FindViewById<Button>(Resource.Id.philosophyGuide);
            philosophyGuideButton.Click += delegate { StartActivity(typeof(PhilosophyGuideActivity)); };

            Button mindfulnessExercise = FindViewById<Button>(Resource.Id.mindfulnessExercise);
            mindfulnessExercise.Click += delegate { StartActivity(typeof(MindfulnessExerciseActivity)); };

            Button dailyChallenges = FindViewById<Button>(Resource.Id.dailyChallenges);
            dailyChallenges.Click += delegate { StartActivity(typeof(DailyChallengesActivity)); };


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}