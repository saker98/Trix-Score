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
    [Activity(Label = "diamond")]
    public class diamond : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.diamond);

            var b1 = FindViewById<Button>(Resource.Id.b1);
            var b2 = FindViewById<Button>(Resource.Id.b2);
            var b3 = FindViewById<Button>(Resource.Id.b3);
            var b4 = FindViewById<Button>(Resource.Id.b4);
            var b5 = FindViewById<Button>(Resource.Id.b5);
            var b6 = FindViewById<Button>(Resource.Id.b6);
            var b7 = FindViewById<Button>(Resource.Id.b7);
            var b8 = FindViewById<Button>(Resource.Id.b8);
            var b9 = FindViewById<Button>(Resource.Id.b9);
            var b10 = FindViewById<Button>(Resource.Id.b10);
            var b11 = FindViewById<Button>(Resource.Id.b11);
            var b12 = FindViewById<Button>(Resource.Id.b12);
            var b13 = FindViewById<Button>(Resource.Id.b13);

            var calc = FindViewById<Button>(Resource.Id.calc);
            var result = FindViewById<TextView>(Resource.Id.res);
            var clear = FindViewById<Button>(Resource.Id.clear);

            b1.Click += delegate
            { result.Text = "10"; };
            b2.Click += delegate
            { result.Text = "20"; };
            b3.Click += delegate
            { result.Text = "30"; };
            b4.Click += delegate
            { result.Text = "40"; };
            b5.Click += delegate
            { result.Text = "50"; };
            b6.Click += delegate
            { result.Text = "60"; };
            b7.Click += delegate
            { result.Text = "70"; };
            b8.Click += delegate
            { result.Text = "80"; };
            b9.Click += delegate
            { result.Text = "90"; };
            b10.Click += delegate
            { result.Text = "100"; };
            b11.Click += delegate
            { result.Text = "110"; };
            b12.Click += delegate
            { result.Text = "120"; };
            b13.Click += delegate
            { result.Text = "130"; };

            clear.Click += delegate
            { result.Text = "0"; };

            calc.Click += delegate
            {
                var intent = new Intent(this, typeof(with_partner));
                intent.PutExtra("dim", result.Text);
                StartActivity(intent);
            };
        }
    }
}