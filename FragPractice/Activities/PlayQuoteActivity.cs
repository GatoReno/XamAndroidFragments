using System;
using Android.App;
using Android.OS;
using AndroidX.Fragment.App;
using FragPractice.Fragments;

namespace FragPractice.Activities
{
    [Activity(Label = "PlayQuoteActivity")]
    public class PlayQuoteActivity : AndroidX.Fragment.App.FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var playId = Intent.Extras.GetInt("current_play_id", 0);
            var detailsFrag = PlayQuoteFragment.NewInstance(playId);
            SupportFragmentManager.BeginTransaction()
                            .Add(
                                Android.Resource.Id.Content, detailsFrag)
                            .Commit();
        }
    }
}