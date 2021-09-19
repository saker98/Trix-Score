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

namespace Trix_Score
{
    [Activity(Label = "King")]
    public class King : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.King);

            var x1 = FindViewById<Button>(Resource.Id.x1);
            var x2 = FindViewById<Button>(Resource.Id.x2);
            var doub = FindViewById<Button>(Resource.Id.doub);
            var calculate = FindViewById<Button>(Resource.Id.calculate);
            var res = FindViewById<TextView>(Resource.Id.res);
            var clear = FindViewById<Button>(Resource.Id.clear);

            x1.Click += delegate
            { res.Text = "75"; };
            x2.Click += delegate
            { res.Text = "150"; };
            doub.Click += delegate
            { res.Text = "-75"; };
            clear.Click += delegate
            { res.Text = "0"; };

            calculate.Click += delegate
            {
                var intent = new Intent(this, typeof(with_partner));
                intent.PutExtra("king", res.Text);
                StartActivity(intent);
            };

        }
    }
}