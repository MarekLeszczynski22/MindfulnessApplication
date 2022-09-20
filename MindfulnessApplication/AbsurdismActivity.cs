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
    [Activity(Label = "AbsurdismActivity")]
    public class AbsurdismActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.absudrismLayout);

            TextView absurdismTitle = FindViewById<TextView>(Resource.Id.absurdismTitle);
            absurdismTitle.Text = "The Philosophy of the Absurd";

            TextView absurdismDescription = FindViewById<TextView>(Resource.Id.absurdismDescription);
            absurdismDescription.Text = "In his book The Myth of Sisyphus, Algerian born Author and Philosopher attempts to explain the philosophy of the absurd, and how to deal with the absurd word. What is “the absurd”? Camus claims that it is the gap between our basic human need to understand things and have meaning for everything, and “the unreasonable silence” of the universe whenever humans call to it for a meaning of life. As opposed to many modern or ancient philosophers, we do not need to concern ourselves with finding the meaning of the universe, instead we should acknowledge “the absurd” gap, and carry on with our lives regardless of it, better yet, he also claims that the one who acknowledges “the absurd” can use it to live a paradoxically meaningful life." +
                "But how can we do that? Camus believes that after discovering “the absurd” (awakening) (Camus, 2013) there are three things that might potentially happen to a man:" + System.Environment.NewLine +
                "\t\u2022 Suicide (There is but one truly serious philosophical problem and that is suicide)" + System.Environment.NewLine +
                "\t\u2022 Philosophical suicide (turning into deity to find comfort and meaning)" + System.Environment.NewLine +
                "\t\u2022 Revolt, freedom, and passion (accepting “the absurd” and living despite of it)";




            // Create your application here
        }
    }
}