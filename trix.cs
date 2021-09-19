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
    [Activity(Label = "trix")]
    public class trix : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.trix);

            var b1 = FindViewById<Button>(Resource.Id.b1);
            var b2 = FindViewById<Button>(Resource.Id.b2);
            var b3 = FindViewById<Button>(Resource.Id.b3);
            var b4 = FindViewById<Button>(Resource.Id.b4);
            var b5 = FindViewById<Button>(Resource.Id.b5);
            var b6 = FindViewById<Button>(Resource.Id.b6);
            var calc = FindViewById<Button>(Resource.Id.calc);
            var res = FindViewById<TextView>(Resource.Id.res);
            var clear = FindViewById<Button>(Resource.Id.clear);

            b1.Click += delegate
            { res.Text = "350"; };
            b2.Click += delegate
            { res.Text = "300"; };
            b3.Click += delegate
            { res.Text = "250"; };
            b4.Click += delegate
            { res.Text = "250"; };
            b5.Click += delegate
            { res.Text = "200"; };
            b6.Click += delegate
            { res.Text = "150"; };

            clear.Click += delegate
            { res.Text = "0"; };

            calc.Click += delegate
            {
                var intent = new Intent(this, typeof(with_partner));
                intent.PutExtra("trix", res.Text);
                StartActivity(intent);
            };
        }
    }
}