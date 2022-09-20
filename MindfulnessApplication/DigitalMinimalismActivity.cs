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
    [Activity(Label = "DigitalMinimalismActivity")]
    public class DigitalMinimalismActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.digitalMinimalismLayout);

            TextView digitalMinimalismTitle = FindViewById<TextView>(Resource.Id.digitalMinimalismTitle);
            digitalMinimalismTitle.Text = "The Philosophy of the Digital Minimalism";

            TextView digitalMinimalismDescription = FindViewById<TextView>(Resource.Id.digitalMinimalismDescription);
            digitalMinimalismDescription.Text = "In this book Newport produces a new idea of a “digital minimalism” an approach that could be an interesting way of dealing with a “clutter.” I like how Newport does not always blame technology and see it as an evil thing, he recognizes the need of technology in our life, and the fact that it is extremely helpful in a lot of cases. He instead recognizes that many of the technology that we use today is designed to make us more addictive to it and bring profit to the companies making them, and that sometimes we went beyond of the features we initially wanted in technology." +
                                                "He, in his own words describes “digital minimalism” as a “A philosophy of technology use in which you focus your online time on a small number of carefully selected and optimized activities that strongly support things you value, and then happily miss out on everything else.” (Newport, 2019)" + System.Environment.NewLine +
                                                "He also outlines the three principles of the digital minimalist:" + System.Environment.NewLine +
                                                "\t\u2022 Clutter is costly(the cost of overstimulating ourselves with technology outweighs the small benefit that we receive in exchange)" + System.Environment.NewLine +
                                                "\t\u2022 Optimization is important(simply getting rid or reducing technology is not enough, we must change the way we think about technology)" + System.Environment.NewLine +
                                                "\t\u2022Intentionality is satisfying(we must be mindful and fully decisive about how we use technology)";



            // Create your application here
        }
    }
}