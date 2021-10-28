
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace FragPractice.Fragments
{
    
    public class PlayQuoteFragment : AndroidX.Fragment.App.Fragment
    {
        public int PlayId => Arguments.GetInt("current_play_id", 0);


        public static PlayQuoteFragment NewInstance(int playId)
        {
            var bundle = new Bundle();
            bundle.PutInt("current_play_id", playId);
            return new PlayQuoteFragment { Arguments = bundle };
        }


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            if (container == null)
            {
                return null;
            }

            var textView = new TextView(Activity);
            var padding = Convert.ToInt32(TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Activity.Resources.DisplayMetrics));
            textView.SetPadding(padding, padding, padding, padding);
            textView.TextSize = 24;
            textView.Text = Shakespeare.Dialogue[PlayId];

            var scroller = new ScrollView(Activity);
            scroller.AddView(textView);

            return scroller;
        }
    }
}
