using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Preferences;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Trix_Score
{
    [Activity(Label = "with_partner")]
    public class with_partner : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.with_partner);

            ISharedPreferences prefer = PreferenceManager.GetDefaultSharedPreferences(this);
            int ress = prefer.GetInt("result", 0);

            var trix = FindViewById<Button>(Resource.Id.trix);
            var king = FindViewById<Button>(Resource.Id.king);
            var ltoosh = FindViewById<Button>(Resource.Id.ltoosh);
            var diamond = FindViewById<Button>(Resource.Id.diamond);
            var queens = FindViewById<Button>(Resource.Id.queens);
            var res = FindViewById<TextView>(Resource.Id.result);
            var clear = FindViewById<Button>(Resource.Id.clear);

            trix.Click += delegate
            {
                var intent = new Intent(this, typeof(trix));
                StartActivity(intent);
            };
            king.Click += delegate
            {
                var intent = new Intent(this, typeof(King));
                StartActivity(intent);
            };
            ltoosh.Click += delegate
            {
                var intent = new Intent(this, typeof(Ltoosh));
                StartActivity(intent);
            };
            diamond.Click += delegate
            {
                var intent = new Intent(this, typeof(diamond));
                StartActivity(intent);
            };
            queens.Click += delegate
            {
                var intent = new Intent(this, typeof(queens));
                StartActivity(intent);
            };
            clear.Click += delegate
             {
                 ress = 0;
                 SaveData(ress);
                 res.Text = "0";
             };

            //diamond
            string res_dim = Intent.GetStringExtra("dim");
            ress -= Convert.ToInt32(res_dim);
            res.Text = ress.ToString();
            SaveData(ress);

            //king
            string res_king = Intent.GetStringExtra("king");
            ress -= Convert.ToInt32(res_king);
            res.Text = ress.ToString();
            SaveData(ress);

            //ltoosh
            string res_ltsh = Intent.GetStringExtra("ltsh");
            ress -= Convert.ToInt32(res_ltsh);
            res.Text = ress.ToString();
            SaveData(ress);

            //queens
            string res_queens = Intent.GetStringExtra("queens");
            ress -= Convert.ToInt32(res_queens);
            res.Text = ress.ToString();
            SaveData(ress);

            //trix
            string res_trix = Intent.GetStringExtra("trix");
            ress += Convert.ToInt32(res_trix);
            res.Text = ress.ToString();
            SaveData(ress);

            void SaveData(int r)
            {
                ISharedPreferences prefe = PreferenceManager.GetDefaultSharedPreferences(this);
                ISharedPreferencesEditor editor = prefe.Edit();
                editor.PutInt("result", r);
                editor.Apply();
            }
           
        }
    }
}