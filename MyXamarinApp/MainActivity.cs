using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MyXamarinApp
{
    [Activity(Label = "MyXamarinApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        EditText inputbill;
        Button calculateButton;
        TextView outputTip;
        TextView outputTotal;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            inputbill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += CalculateButton_Click;
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        { 
            string text = inputbill.Text;
            var bill = double.Parse(text);
            var tip = bill * 0.15;
            var total = bill + tip;
            outputTip.Text = tip.ToString();
            outputTotal.Text = total.ToString();

        }
    }
}

