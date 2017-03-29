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


namespace Game
{
    [Activity(Label = "CreateChar")]
    public class CreateChar : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.creation);

            string gender = "";
            string charName = "";
            Button continueBtn = FindViewById<Button>(Resource.Id.continueBtn);

            continueBtn.Click += delegate {
                //save name and gender to DB
            };
        }
    }
}