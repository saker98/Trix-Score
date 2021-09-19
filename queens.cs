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
    [Activity(Label = "queens")]
    public class queens : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.queens);

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
            var calc = FindViewById<Button>(Resource.Id.calc);
            var res = FindViewById<TextView>(Resource.Id.res);
            var clear= FindViewById<Button>(Resource.Id.clear);

            b1.Click += delegate
            { res.Text = "25"; };
            b2.Click += delegate
            { res.Text = "50"; };
            b3.Click += delegate
            { res.Text = "75"; };
            b4.Click += delegate
            { res.Text = "100"; };
            b5.Click += delegate
            { res.Text = (Convert.ToInt32(res.Text) + 50).ToString(); };
            b6.Click += delegate
            { res.Text = (Convert.ToInt32(res.Text) + 100).ToString(); };
            b7.Click += delegate
            { res.Text = (Convert.ToInt32(res.Text) + 150).ToString(); };
            b8.Click += delegate
            { res.Text = (Convert.ToInt32(res.Text) + 200).ToString(); };
            b9.Click += delegate
            {
                res.Text = (Convert.ToInt32(res.Text) - 25).ToString();
            };
            b10.Click += delegate
            {
                res.Text = (Convert.ToInt32(res.Text) - 50).ToString();
            };
            b11.Click += delegate
            {
                res.Text = (Convert.ToInt32(res.Text) - 75).ToString();
            };
            b12.Click += delegate
            {
                res.Text = (Convert.ToInt32(res.Text) - 100).ToString();
            };

            clear.Click += delegate
            { res.Text = "0"; };

            calc.Click += delegate
            {
                var intent = new Intent(this, typeof(with_partner));
                intent.PutExtra("queens", res.Text);
                StartActivity(intent);
            };
        }
    }
}